using System;
using LibraryApp.Data;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    internal class LoanService
    {
        private readonly AppDbContext _dbContext;

        public LoanService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Loan loan)
        {
            _dbContext.Loans.Add(loan);
            Commit();
        }

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

    }
}
