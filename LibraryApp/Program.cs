using LibraryApp.Data;
using LibraryApp.Forms;
using LibraryApp.Helpers;
using LibraryApp.Security;
using LibraryApp.Services;
using LibraryApp.Views;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!DirectoriesManager.DirectoryExists())
            {
                DirectoriesManager.CreateDirectories();

                using var credentialsForm = new CredentialsForm();
                credentialsForm.ShowDialog();

                if (credentialsForm.DialogResult != DialogResult.OK)
                {
                    DirectoriesManager.RemoveDirectories();
                    return;
                }

                DbSecurity.ConfigureDatabase();
            }


            using var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                var dbContext = UnitOfWork.DbContext;
                var bookService = new BookService(dbContext);

                Application.Run(new LibraryForm(bookService, new ClientService(dbContext), new LoanService(dbContext), new LoanBooksService(dbContext, bookService)));
            }
        }
    }
}