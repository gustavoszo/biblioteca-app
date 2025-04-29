using LibraryApp.Models;
using LibraryApp.Services;
using MaterialSkin.Controls;
using System;
using System.Text;

namespace LibraryApp.Views
{
    internal partial class LoansForm : MaterialForm
    {

        private readonly LoanService _loanService;
        private List<Loan> _loans;

        public LoansForm(LoanService loanService)
        {
            _loanService = loanService;
            _loans = new List<Loan>();

            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            Load += LoansForm_Load;
            advancedDataGridView.CellClick += AdvancedDataGridView_CellClick;
        }

        private void LoansForm_Load(object? sender, EventArgs e)
        {
            _loans = _loanService.GetAllLoans();
            LoadBooksOnDataGridView(_loans);
        }

        private void AdvancedDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var idLoan = advancedDataGridView.Rows[e.RowIndex].Cells["idLoanColumn"].Value?.ToString();
                var loan = _loanService.FindLoanById(int.Parse(idLoan));

                if (advancedDataGridView.Columns[e.ColumnIndex].Name == "returnColumn")
                {
                    if (ReturnLoan(loan))
                    {
                        _loans = _loanService.GetAllLoans();
                        LoadBooksOnDataGridView(_loans);
                    }
                }

                else if (advancedDataGridView.Columns[e.ColumnIndex].Name == "booksColumn")
                {
                    ShowBooksByLoan(loan.Id);
                }
            }
        }

        private bool ReturnLoan(Loan loan)
        {
            var dialogResult = MessageBox.Show("Confirma a devolução do empréstimo?", "Devolução", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _loanService.ReturnLoan(loan);
                    MessageBox.Show("Devolucão realizada!", "Devolução");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao devolver o empréstimo", "Erro");
                }
            }
            return false;
        }

        private void LoadBooksOnDataGridView(List<Loan> loans)
        {
            advancedDataGridView.Rows.Clear();
            foreach (var loan in loans)
            {
                advancedDataGridView.Rows.Add(loan.Client.Name, loan.Client.Document, loan.Id, loan.DateLoan, loan.ReturnDate.ToShortDateString());
            }
        }

        private void ShowBooksByLoan(int id)
        {
            var loan = _loans.FirstOrDefault(l => l.Id == id); // Esse loan contém os relacionamentos atribuidos na busca GetAll do ef

            StringBuilder sb = new StringBuilder();

            foreach (var loanBook in loan.LoanBooks)
                sb.AppendLine($"Livro: {loanBook.Book.Title}\nQuantidade: {loanBook.Quantity}\n");

            MessageBox.Show(sb.ToString());
        }
    }
}
