using System;
using LibraryApp.Data;
using LibraryApp.Exceptions;
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
            book.QuantityAvailable = book.Total;

            _dbContext.Books.Add(book);
            Commit();
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.AsNoTracking().Select(b => new Book
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Publisher = b.Publisher,
                ISBN = b.ISBN,
                Total = b.Total,
                QuantityAvailable = b.QuantityAvailable
            }).ToList();
        }

        public Book? FindBookByISBN(string isbn)
        {
            return _dbContext.Books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public void UpdateBook(Book savedBook, Book updatedBook)
        {
            int booksOnLoan = savedBook.Total - savedBook.QuantityAvailable;
            if (booksOnLoan > updatedBook.Total)
                throw new BookValidationException($"Titulo: {savedBook.Title}\nISBN: {savedBook.ISBN}\nEste livro possui {booksOnLoan} empréstimo(s) em andamento. Portanto, não é possivel que a quantidade total de livros seja menor que a quantidade de livros emprestados.");

            savedBook.Title = updatedBook.Title;
            savedBook.Author = updatedBook.Author;
            savedBook.Publisher = updatedBook.Publisher;
            savedBook.PublishYear = updatedBook.PublishYear;
            savedBook.Genre = updatedBook.Genre;

            savedBook.QuantityAvailable += (updatedBook.Total - savedBook.Total);
            savedBook.Total = updatedBook.Total;

            Commit();
        }

        public void DeleteBookByIsbn(string isbn)
        {
            var book = FindBookByISBN(isbn);

            if (book.Total > book.QuantityAvailable) throw new BookValidationException(
                $"Titulo: {book.Title}\nISBN: {book.ISBN}\nEste livro possui empréstimos em andamento. Portanto, não é possivel realizar a remoção deste no momento."
                );

            _dbContext.Books.Remove(book);
            Commit();
        }

        public Book? FindBookById(int id)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == id);
        }

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

    }
}
