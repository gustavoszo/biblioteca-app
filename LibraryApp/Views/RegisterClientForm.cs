using LibraryApp.Models;
using MaterialSkin.Controls;
using System.Net.Mail;
using LibraryApp.Services;
using LibraryApp.Exceptions;

namespace LibraryApp.Views
{
    internal partial class RegisterClientForm : MaterialForm
    {
        private readonly ClientService _clientService; 

        public Client Client { get; private set; }
        private string _document;

        public RegisterClientForm(ClientService clientService, string document = "")
        {
            _clientService = clientService;
            _document = document;

            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            Load += RegisterClientForm_Load;

            nameTextBox.TextChanged += InputFields_TextChanged;
            documentTextBox.TextChanged += InputFields_TextChanged;
            phoneMaskedTextBox.TextChanged += InputFields_TextChanged;
            emailTextBox.TextChanged += InputFields_TextChanged;

            documentTextBox.KeyPress += DocumentTextBox_KeyPress;

            addButton.Click += AddButton_Click;
        }

        private void RegisterClientForm_Load(object? sender, EventArgs e)
        {
            documentTextBox.Text = _document;
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            if(FormIsValid())
            {
                try
                {
                    Client = InstantiateClient();

                    _clientService.CreateClient(Client);
                    ShowFeedbackMessage("Usuário cadastrado!", "Cadastro de cliente");

                    this.Close();
                }
                catch (ClientValidationException ex)
                {
                    ShowFeedbackMessage(ex.Message, "Cadastro de cliente");
                }
                catch (Exception ex)
                {
                    ShowFeedbackMessage("Ocorreu um erro ao tentar cadastrar o cliente: " + ex.InnerException.Message, "Erro");
                }
            }
        }

        private void InputFields_TextChanged(object? sender, EventArgs e)
        {
            addButton.Enabled = !string.IsNullOrWhiteSpace(nameTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(documentTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(phoneMaskedTextBox.Text);
        }

        private void DocumentTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool FormIsValid()
        {
            bool isValid = true;
            
            try
            {
                if (emailTextBox.Text.Trim().Length > 0)
                {
                    var addr = new MailAddress(emailTextBox.Text);
                }
            }
            catch (Exception)
            {
                ShowFeedbackMessage("O endereço de e-mail está inválido", "Cadastrar cliente");
                isValid = false;
            }

            if (FormatPhoneNumber(phoneMaskedTextBox.Text).Length != 11)
            {
                ShowFeedbackMessage("O número de telefone deve conter 11 números", "Cadastrar cliente");
                isValid = false;
            }

            return isValid;
        }

        private Client InstantiateClient()
        {
            var client = new Client()
            {
                Name = nameTextBox.Text,
                Document = documentTextBox.Text,
                Phone = FormatPhoneNumber(phoneMaskedTextBox.Text) 
            };

            if (!string.IsNullOrEmpty(emailTextBox.Text)) client.Email = emailTextBox.Text;
            return client;
        }

        private void ShowFeedbackMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            return phoneNumber
                .Replace("(", "")
                .Replace(")", "")
                .Replace("-", "")
                .Replace(" ", "");
        }
    }
}
