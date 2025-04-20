using System;
using System.Data.Common;
using LibraryApp.Data;
using LibraryApp.Security;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Forms
{
    internal partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (!FormIsValid())
            {
                MessageBox.Show("Por favor, informe o usuário e senha.", "Login");
                return;
            }

            if (!IsValidCredential())
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)", "Login");
                return;
            }

            this.Hide();

            InitializeLibraryView();

            this.Close();
        }

        private bool FormIsValid()
        {
            return !(string.IsNullOrEmpty(usernameTextBox.Text.Trim()) || string.IsNullOrEmpty(passwordTextBox.Text.Trim()));
        }

        private bool IsValidCredential()
        {
            return UserSecurity.IsValidCredential(usernameTextBox.Text, passwordTextBox.Text);
        }

        private void InitializeLibraryView()
        {
            var connectionString = DbSecurity.LoadDatabaseConfig().BuildConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            AppDbContext dbContext = new AppDbContext(optionsBuilder.Options);

            var libraryForm = new LibraryForm(dbContext);
            libraryForm.ShowDialog();
        }
    }
}
