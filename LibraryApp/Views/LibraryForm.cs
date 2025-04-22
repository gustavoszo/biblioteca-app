using System;
using LibraryApp.Data;
using LibraryApp.Models;
using LibraryApp.Views;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    internal partial class LibraryForm : MaterialForm
    {

        private readonly AppDbContext _dbContext;

        public LibraryForm(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
            AttachEventHandlers();
        }

        # region Initialize

        public void AttachEventHandlers()
        {
            this.Load += LibraryForm_Load;
            exitButton.Click += ExitButton_Click;
            addBookButton.Click += AddBookButton_Click;
        }


        private void LibraryForm_Load(object? sender, EventArgs e)
        {
            LoadBooksOnDataGridView(LoadBooksFromDatabase());
        }

        #endregion

        # region EventHandlers

        private void AddBookButton_Click(object? sender, EventArgs e)
        {
            new StoreBookForm().ShowDialog();
        }

        private void ExitButton_Click(object? sender, EventArgs e) => Close();

        #endregion

        private List<Book> LoadBooksFromDatabase()
        {
            try
            {
                return _dbContext.Books.AsNoTracking().Select(b => new Book
                {
                    Title = b.Title,
                    Author = b.Author,
                    Publisher = b.Publisher,
                    ISBN = b.ISBN,
                    Total = b.Total,
                    QuantityAvailable = b.QuantityAvailable
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar livros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>();
            }
        }

        private void LoadBooksOnDataGridView(List<Book> books)
        {
            foreach (var book in books) advancedDataGridView.Rows.Add(book.Title, book.Author, book.Publisher, book.ISBN, book.Total, book.QuantityAvailable);
        }
    }
}
