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
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = _printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Define a impressora selecionada
                    _printDocument.PrinterSettings = printDialog.PrinterSettings;

                    PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                    previewDialog.Document = _printDocument;
                    previewDialog.WindowState = FormWindowState.Maximized;
                    previewDialog.ShowDialog();
                }
            }
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
            DrawTitle(e.Graphics, ref y, titleFont, brush);
            y += titleFont.GetHeight(e.Graphics) + 50;

            // Seção do cliente
            DrawClientSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
            y += 50; // espaço extra entre seções

            // Seção dos livros
            DrawBookSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
            y += 20;

            // Seção de datas
            DrawDatesSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
            y += 140;

            DrawSignaturesSection(e.Graphics, ref x, ref y, subtitleFont, contentFont, brush);
        }

        private void DrawTitle(Graphics e, ref float y, Font font, Brush brush)
        {
            SizeF titleSize = e.MeasureString("RELATÓRIO DE LOCAÇÃO", font);
            float centerX = e.VisibleClipBounds.Left + (e.VisibleClipBounds.Width - titleSize.Width) / 2;

            e.DrawString("RELATÓRIO DE LOCAÇÃO", font, brush, centerX, y);
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
            var bookLines = BuildDocumentBooksContent().Split("\n\n");
            foreach (var book in bookLines)
            {
                e.DrawString(book.Trim(), contentFont, brush, x, y);
                y += contentFont.GetHeight(e) + 40;
            }
        }

        private void DrawDatesSection(Graphics e, ref float x, ref float y,
         Font subtitleFont, Font contentFont, Brush brush)
        {
            e.DrawString("Datas", subtitleFont, brush, x, y);
            y += subtitleFont.GetHeight(e) + 5;

            var dateLoanLine = $"Data de empréstimo: {Loan.DateLoan.ToShortDateString()} às {Loan.DateLoan.ToShortTimeString()}";
            e.DrawString(dateLoanLine, contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 2;

            var dateReturnLine = $"Data de devolução: {Loan.ReturnDate.ToShortDateString()}";
            e.DrawString(dateReturnLine, contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 2;
        }

        private void DrawSignaturesSection(Graphics e, ref float x, ref float y,
            Font subtitleFont, Font contentFont, Brush brush)
        {
            e.DrawString("Assinaturas", subtitleFont, brush, x, y);
            y += subtitleFont.GetHeight(e) + 10;

            e.DrawString("Assinatura do cliente: ___________________________________", contentFont, brush, x, y);
            y += contentFont.GetHeight(e) + 50;

            e.DrawString("Assinatura da locadora: _________________________________", contentFont, brush, x, y);
        }

        private string BuildDocumentClientContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Loan.Client.Name}");
            sb.AppendLine($"Documento: {Loan.DocumentClient}");
            sb.AppendLine($"Telefone: {Loan.Client.Phone}");
            return sb.ToString();
        }

        private string BuildDocumentBooksContent()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var loanBook in Loan.LoanBooks)
            {
                sb.AppendLine($" - {loanBook.Book.Title} (Autor: {loanBook.Book.Author})\n Quantidade: {loanBook.Quantity}\n\n");
            }
            return sb.ToString();
        }

    }
}
