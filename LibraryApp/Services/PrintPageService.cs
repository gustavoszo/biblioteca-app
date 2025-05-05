using LibraryApp.Models;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace LibraryApp.Services
{
    internal class PrintPageService
    {
        private PrintDocument _printDocument;
        public Loan Loan { get; set; }

        public PrintPageService(PrintDocument printDocument)
        {
            _printDocument = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void PreviewPage()
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = _printDocument;
            previewDialog.WindowState = FormWindowState.Maximized;
            previewDialog.ShowDialog();
        }

        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font subtitleFont = new Font("Arial", 18, FontStyle.Bold);
            Font contentFont = new Font("Arial", 16, FontStyle.Regular);
            Brush brush = Brushes.Black;

            // Título
            DrawTitle(e.Graphics, ref x, ref y, titleFont, brush);
            y += titleFont.GetHeight(e.Graphics) + 20;

            // Seção do cliente
            DrawClientSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
            y += 10; // espaço extra entre seções

            // Seção dos livros
            DrawBookSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
            y += 10;
            
            // Seção de datas
            DrawDatesSection(e.Graphics, ref x, ref y, contentFont, brush);
            y += 60;

            DrawSignaturesSection(e.Graphics, ref x, ref y, contentFont, brush);
        }

        private void DrawTitle(Graphics e, ref float x, ref float y, Font font, Brush brush)
        {
            e.DrawString("RELATÓRIO DE LOCAÇÃO", font, brush, x, y);
        }

        private void DrawClientSection(Graphics e, ref float x, ref float y, Font subtitleFont, 
            Font contentFont, Brush brush)
        {
            e.DrawString("Dados do cliente", subtitleFont, brush, x, y);
            y += subtitleFont.GetHeight(e) + 5;

            // Conteúdo do cliente (linha por linha)
            var clientLines = BuildDocumentClientContent().Split('\n');
            foreach (var line in clientLines)
            {
                e.DrawString(line.Trim(), contentFont, brush, x, y);
                y += contentFont.GetHeight(e) + 2;
            }
        }

        private void DrawBookSection(Graphics e, ref float x, ref float y,
          Font subtitleFont, Font contentFont, Brush brush)
        {
            e.DrawString("Livros emprestados", subtitleFont, brush, x, y);
            y += subtitleFont.GetHeight(e) + 5;

            // Conteúdo do cliente (linha por linha)
            var bookLines = BuildDocumentBooksContent().Split('\n');
            foreach (var book in bookLines)
            {
                e.DrawString(book.Trim(), contentFont, brush, x, y);
                y += contentFont.GetHeight(e) + 2;
            }
        }

        private void DrawDatesSection(Graphics e, ref float x, ref float y,
         Font contentFont, Brush brush)
        {
            var dateLoanLine = $"Data de empréstimo: {Loan.DateLoan}";
            e.DrawString(dateLoanLine, contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 2;

            var dateReturnLine = $"Data de devolução: {Loan.ReturnDate.ToShortDateString()}";
            e.DrawString(dateReturnLine, contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 2;
        }

        private void DrawSignaturesSection(Graphics e, ref float x, ref float y,
            Font contentFont, Brush brush)
        {
            e.DrawString("Assinatura do cliente: ____________________________", contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 40;

            e.DrawString("Assinatura da locadora: __________________________", contentFont, brush, x, y);
        }

        private string BuildDocumentClientContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {Loan.Client.Name}");
            sb.AppendLine($"Documento: {Loan.DocumentClient}");
            sb.AppendLine($"Telefone: {Loan.Client.Phone}");
            return sb.ToString();
        }

        private string BuildDocumentBooksContent()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var loanBook in Loan.LoanBooks)
            {
                sb.AppendLine($" - {loanBook.Book.Title} (Autor: {loanBook.Book.Author})");
            }
            return sb.ToString();
        }

    }
}
