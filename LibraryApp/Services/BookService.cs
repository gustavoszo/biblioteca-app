using System;
using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Services
{
    internal class BookService
    {
        private readonly AppDbContext _dbContext;
        
        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateBook(Book book)
        {
            try
            {
                book.QuantityAvailable = book.Total;

                _dbContext.Books.Add(book);
                Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetAllBooks()
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
            catch (Exception)
            {
                return new List<Book>();
            }
        }

        public Book? FindBookByISBN(string isbn)
        {
            try
            {
                return _dbContext.Books.FirstOrDefault(b => b.ISBN == isbn);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void UpdateBook(Book savedBook, Book updatedBook)
        {
            try
            {
                savedBook.Title = updatedBook.Title;
                savedBook.Author = updatedBook.Author;
                savedBook.Publisher = updatedBook.Publisher;
                savedBook.PublishYear = updatedBook.PublishYear;
                savedBook.Genre = updatedBook.Genre;
                
                savedBook.QuantityAvailable += (updatedBook.Total - savedBook.Total);
                savedBook.Total = updatedBook.Total;

                Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteBook(Book book)
        {
            try
            {
                if (book.Total > book.QuantityAvailable) throw new Exception(
                    $"Titulo: {book.Title}\nISBN: {book.ISBN}\nEste livro possui empréstimos em andamento. Portanto, não é possivel realizar a remoção deste no momento."
                    );

                _dbContext.Books.Remove(FindBookByISBN(book.ISBN));
                Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

    }
}
