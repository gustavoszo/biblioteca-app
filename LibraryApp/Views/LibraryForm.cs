using System;
using LibraryApp.Data;
using LibraryApp.Models;
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
        }

    }
}
