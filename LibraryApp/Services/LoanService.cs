using System;
using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Services
{
    internal class LoanService
    {
        private readonly AppDbContext _dbContext; 
        private readonly LoanBooksService _loanBooksService;

        public LoanService(AppDbContext dbContext, LoanBooksService loanBooksService)
        {
            _dbContext = dbContext;
            _loanBooksService = loanBooksService;
        }

        public void Create(Loan loan)
        {
            _dbContext.Loans.Add(loan);
            Commit();
        }

        public Loan FindBookById(int idLoan)
        {
            return _dbContext.Loans.FirstOrDefault(l => l.Id == idLoan);
        }

        public List<Loan> GetAllLoans()
        {
            return _dbContext.Loans.AsNoTracking()
                    .Include(l => l.LoanBooks)
                    .ThenInclude(lb => lb.Book)
                    .Include(l => l.Client)
                    .Where(l => !l.Returned)
                    .ToList();
        }

        public void ReturnLoan(Loan loan)
        {
            loan.Returned = true;
            _loanBooksService.ReturnBooksToAvailable(loan.LoanBooks.ToList());
            Commit();
        }

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

    }
}
