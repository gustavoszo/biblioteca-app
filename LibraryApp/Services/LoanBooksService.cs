using System;
using LibraryApp.Data;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    internal class LoanBooksService
    {
        private readonly AppDbContext _dbContext;
        private readonly BookService _bookService;

        public LoanBooksService(AppDbContext dbContext, BookService bookService)
        {
            _dbContext = dbContext;
            _bookService = bookService;
        }

        public void Create(LoanBook loanBook)
        {
            _dbContext.Loans_Books.Add(loanBook);

            var book = _bookService.FindBookById(loanBook.BookId);
            book.QuantityAvailable -= loanBook.Quantity;

            Commit();
        }

        public void ReturnBooksToAvailable(List<LoanBook> loanBooks)
        {
            foreach (var loanBook in loanBooks)
            {
                loanBook.Book.QuantityAvailable += loanBook.Quantity;
            }
            Commit();
        }

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

    }
}
