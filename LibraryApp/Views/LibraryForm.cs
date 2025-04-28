using System;
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

        private List<Book> _books;

        public LibraryForm(BookService bookService, ClientService clientService)
        {
            _bookService = bookService;
            _clientService = clientService;
            _books = new List<Book>();

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
            confirmLoanButton.Click += ConfirmLoanButton_Click;
        }

        private void LibraryForm_Load(object? sender, EventArgs e)
        {
            _books = _bookService.GetAllBooks();

            // bookTabPage
            LoadBooksOnDataGridView(_books);

            // loanTabPage
            CustomizeLoanCalendar();
            LoadBooksOnComboBox(_books.ToArray());
        }

        #endregion

        #region EventHandlers

        // bookTabPage
        private void AddBookButton_Click(object? sender, EventArgs e)
        {
            new StoreBookForm(_bookService).ShowDialog();

            _books = _bookService.GetAllBooks();
            LoadBooksOnDataGridView(_books);
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
                    LoadBooksOnDataGridView(_bookService.GetAllBooks());
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
            confirmLoanButton.Enabled = bookComboBox.SelectedIndex != -1
                                  && quantityComboBox.SelectedIndex != -1;
        }

        private void ConfirmLoanButton_Click(object? sender, EventArgs e)
        {
            try
            {
                var client = SearchClient(documentTextBox.Text.Trim());
                if (client != null)
                {
                    documentTextBox.Text = client.Document;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        #endregion

        private void LoadBooksOnDataGridView(List<Book> books)
        {
            advancedDataGridView.Rows.Clear();
            foreach (var book in books) advancedDataGridView.Rows.Add(book.Title, book.Author, book.Publisher, book.ISBN, book.Total, book.QuantityAvailable);
        }

        private void CustomizeLoanCalendar()
        {
            devolutionDateTimePicker.MaxDate = DateTime.Today.AddMonths(3);
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

            for (int i=1; i<=quantity; i++)
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
    }
}
