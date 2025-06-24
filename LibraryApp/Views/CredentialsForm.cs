using LibraryApp.Security;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Views
{
    public partial class CredentialsForm : MaterialForm
    {
        public CredentialsForm()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            usernameTextBox.TextChanged += InputFields_TextChanged;
            passwordTextBox.TextChanged += InputFields_TextChanged;
            confirmPasswordTextBox.TextChanged += InputFields_TextChanged;

            registerButton.Click += RegisterButton_Click;
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            if (FormIsValid())
            {
                try
                {
                    UserSecurity.RegisterAdmin(usernameTextBox.Text.Trim(), passwordTextBox.Text);
                    MessageBox.Show("Usauário registrado!", "Registrar usuário");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar criar o usuário: " + ex.Message, "Registrar usuário");
                }
            }
        }

        private void InputFields_TextChanged(object? sender, EventArgs e)
        {
            registerButton.Enabled = !string.IsNullOrWhiteSpace(usernameTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(passwordTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text);
        }

        private bool FormIsValid()
        {
            if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                ShowValidationMessage("Senhas diferentes.");
                return false;
            }

            return true;
        }

        private void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "Registrar usuário");
        }

    }
}
