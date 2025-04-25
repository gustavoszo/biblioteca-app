using LibraryApp.Data;
using LibraryApp.Forms;
using LibraryApp.Security;
using LibraryApp.Services;
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

            using var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                var connectionString = DbSecurity.LoadDatabaseConfig().BuildConnectionString();
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                var dbContext = new AppDbContext(optionsBuilder.Options);

                Application.Run(new LibraryForm(new BookService(dbContext)));
            }
        }
    }
}