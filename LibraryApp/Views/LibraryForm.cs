using System;
using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Views;
using MaterialSkin.Controls;

namespace LibraryApp
{
    internal partial class LibraryForm : MaterialForm
    {

        private readonly BookService _bookService;

        public LibraryForm(BookService bookService)
        {
            _bookService = bookService;
            InitializeComponent();
            AttachEventHandlers();
        }

        # region Initialize

        public void AttachEventHandlers()
        {
            this.Load += LibraryForm_Load;
            exitButton.Click += ExitButton_Click;
            addBookButton.Click += AddBookButton_Click;
            advancedDataGridView.CellClick += AdvancedDataGridView_CellClick;
        }

        private void LibraryForm_Load(object? sender, EventArgs e)
        {
            LoadBooksOnDataGridView(_bookService.GetAllBooks());
        }

        #endregion

        # region EventHandlers

        private void AddBookButton_Click(object? sender, EventArgs e)
        {
            new StoreBookForm(_bookService).ShowDialog();
            LoadBooksOnDataGridView(_bookService.GetAllBooks());
        }

        private void ExitButton_Click(object? sender, EventArgs e) => Close();

        #endregion

        private void LoadBooksOnDataGridView(List<Book> books)
        {
            advancedDataGridView.Rows.Clear();
            foreach (var book in books) advancedDataGridView.Rows.Add(book.Title, book.Author, book.Publisher, book.ISBN, book.Total, book.QuantityAvailable);
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

    }
}
