using System;
using System.Text;
using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Views;
using MaterialSkin.Controls;

namespace LibraryApp
{
    internal partial class LibraryForm : MaterialForm
    {

        private readonly BookService _bookService;
        private readonly ClientService _clientService;
        private readonly LoanService _loanService;
        private readonly LoanBooksService _loanBookService;

        private List<Book> _books; // Lista com todos os livros cadastrados
        private List<LoanBook> _loanBooks; // Lista com os livros a serem emprestados

        public LibraryForm(BookService bookService, ClientService clientService, LoanService loanService, LoanBooksService loanBookService)
        {
            _bookService = bookService;
            _clientService = clientService;
            _loanService = loanService;
            _loanBookService = loanBookService;

            InitializeVariables();
            InitializeComponent();
            AttachEventHandlers();
        }

        # region Initialize

        public void AttachEventHandlers()
        {
            this.Load += LibraryForm_Load;

            // bookTabPage
            exitButton.Click += ExitButton_Click;
            addBookButton.Click += AddBookButton_Click;
            advancedDataGridView.CellClick += AdvancedDataGridView_CellClick;

            // loanTabPage
            bookComboBox.SelectedIndexChanged += BookComboBox_SelectedIndexChanged;
            quantityComboBox.TextChanged += InputFields_TextChanged;
            loanBookButton.Click += LoanBookButton_Click;
            confirmLoanButton.Click += ConfirmLoanButton_Click;
            cancelButton.Click += CancelButton_Click;
            viewLoanButton.Click += ViewLoanButton_Click;
        }

        private void LibraryForm_Load(object? sender, EventArgs e)
        {
            LoadBooksAndBuildView();
            CustomizeLoanCalendar();
        }

        private void InitializeVariables()
        {
            _books = new List<Book>();
            _loanBooks = new List<LoanBook>();
        }

        #endregion

        #region EventHandlers

        // bookTabPage
        private void AddBookButton_Click(object? sender, EventArgs e)
        {
            new StoreBookForm(_bookService).ShowDialog();

            _books = _bookService.GetAllBooks();

            LoadBooksOnDataGridView(_books);
            LoadBooksOnComboBox(_books.ToArray());
        }

        private void AdvancedDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView.Columns[e.ColumnIndex].Name == "editColumn" && e.RowIndex >= 0)
            {
                var isbn = advancedDataGridView.Rows[e.RowIndex].Cells["isbnColumn"].Value?.ToString();
                var book = _bookService.FindBookByISBN(isbn);

                if (book != null)
                {
                    new StoreBookForm(_bookService, book).ShowDialog();
                    LoadBooksAndBuildView();
                }
            }
        }

        private void ExitButton_Click(object? sender, EventArgs e) => Close();

        // loanTabPage
        private void BookComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var book = bookComboBox.SelectedItem as Book;
            AdjustsQuantityToLoan(book.QuantityAvailable);

            InputFields_TextChanged(sender, e);
        }

        private void InputFields_TextChanged(object? sender, EventArgs e)
        {
            confirmLoanButton.Enabled = _loanBooks.Count > 0;

            loanBookButton.Enabled = bookComboBox.SelectedIndex != -1
                                  && quantityComboBox.SelectedIndex != -1;
        }

        private void LoanBookButton_Click(object? sender, EventArgs e)
        {
            var selectedBook = bookComboBox.SelectedItem as Book;
            _loanBooks.Add(new LoanBook()
            {
                BookId = selectedBook.Id,
                Quantity = int.Parse(quantityComboBox.SelectedItem.ToString())
            });

            quantityComboBox.SelectedIndex = -1;
            bookComboBox.Items.Remove(selectedBook);

            cancelButton.Enabled = true;
        }

        private void ConfirmLoanButton_Click(object? sender, EventArgs e)
        {
            try
            {
                var client = SearchClient(documentTextBox.Text.Trim());
                if (client != null)
                {
                    documentTextBox.Text = client.Document;

                    var loan = new Loan()
                    {
                        DocumentClient = client.Document,
                        ReturnDate = returnDateTimePicker.Value,
                    };
                    _loanService.Create(loan);

                    foreach (var loanBook in _loanBooks)
                    {
                        loanBook.LoanId = loan.Id;
                        _loanBookService.Create(loanBook);
                    }
                    MessageBox.Show("Locação realizada com sucesso!", "Locação");
                    CleanLoanBook();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a locação", "Erro");
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            CleanLoanBook();
        }

        private void ViewLoanButton_Click(object? sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var loanBook in _loanBooks)
                sb.AppendLine(loanBook.ToString() + "\n");

            MessageBox.Show(sb.ToString());
        }

        #endregion

        private void LoadBooksOnDataGridView(List<Book> books)
        {
            advancedDataGridView.Rows.Clear();
            foreach (var book in books) advancedDataGridView.Rows.Add(book.Title, book.Author, book.Publisher, book.ISBN, book.Total, book.QuantityAvailable);
        }

        private void CustomizeLoanCalendar()
        {
            returnDateTimePicker.MaxDate = DateTime.Today.AddMonths(3);
        }

        private void LoadBooksOnComboBox(Book[] books)
        {
            bookComboBox.Items.Clear();
            bookComboBox.Items.AddRange(books);
        }

        private void AdjustsQuantityToLoan(int quantity)
        {
            quantityComboBox.Items.Clear();

            if (quantity == 0)
            {
                MessageBox.Show("Sem livros disponíveis", "Indisponível");
                return;
            }

            for (int i = 1; i <= quantity; i++)
            {
                quantityComboBox.Items.Add(i);
            }
        }

        private Client SearchClient(string document)
        {
            var client = _clientService.FindClientByDocument(document);

            if (client == null)
            {
                MessageBox.Show("O cliente ainda não possui cadastro, realize o cadastro.", "Cadastro de cliente");

                var clientForm = new RegisterClientForm(new ClientService(UnitOfWork.DbContext), documentTextBox.Text);
                clientForm.ShowDialog();
                client = clientForm.Client;
            }

            return client;
        }

        private void CleanLoanBook()
        {
            _loanBooks.Clear();
            confirmLoanButton.Enabled = false;
            cancelButton.Enabled = false;

            LoadBooksAndBuildView();
        }

        private void LoadBooksAndBuildView()
        {
            _books = _bookService.GetAllBooks();

            // bookTabPage
            LoadBooksOnDataGridView(_books);

            // loanTabPage
            LoadBooksOnComboBox(_books.ToArray());
        }
    }
}
