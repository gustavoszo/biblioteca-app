using LibraryApp.Models;
using LibraryApp.Services;
using MaterialSkin.Controls;
using System;

namespace LibraryApp.Views
{
    internal partial class LoansForm : MaterialForm
    {

        private readonly LoanService _loanService;

        public LoansForm(LoanService loanService)
        {
            _loanService = loanService;

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
            LoadBooksOnDataGridView(_loanService.GetAllLoans());
        }

        private void AdvancedDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (advancedDataGridView.Columns[e.ColumnIndex].Name == "returnColumn" && e.RowIndex >= 0)
            {
                var idLoan = advancedDataGridView.Rows[e.RowIndex].Cells["idLoanColumn"].Value?.ToString();
                var loan = _loanService.FindBookById(int.Parse(idLoan));

                if (ReturnLoan(loan))
                {
                    LoadBooksOnDataGridView(_loanService.GetAllLoans());
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
                foreach (var loanBook in loan.LoanBooks)
                {
                    advancedDataGridView.Rows.Add(loan.Client.Name, loan.Client.Document, loan.Id, loan.DateLoan, loan.ReturnDate.ToShortDateString(), loanBook.Book.Title, loanBook.Quantity);
                }
            }
        }
    }
}
