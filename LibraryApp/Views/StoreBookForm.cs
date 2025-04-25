using System;
using LibraryApp.Exceptions;
using LibraryApp.Helpers;
using LibraryApp.Models;
using LibraryApp.Services;
using MaterialSkin.Controls;

namespace LibraryApp.Views
{
    internal partial class StoreBookForm : MaterialForm
    {
        private readonly BookService _bookService;
        private readonly Book? _editBook;

        public StoreBookForm(BookService bookService, Book? book = null)
        {
            _bookService = bookService;
            _editBook = book;

            InitializeComponent();
            AttachEventHandlers();
        }

        #region Initialize

        private void AttachEventHandlers()
        {
            Load += StoreBookForm_Load;

            titleTextBox.TextChanged += InputFields_TextChanged;
            authorTextBox.TextChanged += InputFields_TextChanged;
            publisherTextBox.TextChanged += InputFields_TextChanged;
            yearComboBox.TextChanged += InputFields_TextChanged;
            isbnMaskedTextBox.TextChanged += InputFields_TextChanged;
            genreComboBox.SelectedIndexChanged += InputFields_TextChanged;
            totalTextBox.TextChanged += InputFields_TextChanged;

            totalTextBox.KeyPress += TotalTextBox_KeyPress;
            isbn10RadioButton.CheckedChanged += Isbn10RadioButton_CheckedChanged;

            cancelButton.Click += CancelButton_Click;
            addButton.Click += AddButton_Click;
            removeButton.Click += RemoveButton_Click;
        }

        private void StoreBookForm_Load(object? sender, EventArgs e)
        {
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                yearComboBox.Items.Add(year.ToString());
            }

            if (_editBook != null)
            {
                LoadBook(_editBook);
            }
        }

        #endregion


        #region EventHandlers

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show($"Deseja realmente remover o livro '{_editBook.Title}'?", 
                "Remover livro", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    _bookService.DeleteBookByIsbn(_editBook.ISBN);
                    ShowFeedbackMessage($"O livro '{_editBook.Title}' foi removido!'", "Livro removido");

                    this.Close();
                }
                catch (BookValidationException ex)
                {
                    ShowFeedbackMessage(ex.Message, "Erro");
                }
                catch (Exception)
                {
                    ShowFeedbackMessage("Ocorreu um erro ao tentar adicionar o livro", "Erro");
                }
            }
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            if (FormIsValid())
            {
                try
                {
                    var book = IsntantiateBook();
                    if (_editBook == null)
                    {
                        _bookService.CreateBook(book);
                        ShowFeedbackMessage("Livro adicionado com sucesso!", "Adicionar Livro");
                    }
                    else
                    {
                        _bookService.UpdateBook(_editBook, book);
                        ShowFeedbackMessage("Livro atualizado com sucesso!", "Editar Livro");
                    }

                    this.Close();
                }
                catch (BookValidationException ex)
                {
                    ShowFeedbackMessage(ex.Message, "Erro");
                }
                catch (Exception)
                {
                    ShowFeedbackMessage("Ocorreu um erro ao tentar adicionar o livro", "Erro");
                }
            }
        }

        private void InputFields_TextChanged(object? sender, EventArgs e)
        {
            addButton.Enabled = !string.IsNullOrWhiteSpace(titleTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(authorTextBox.Text)
                                  && !string.IsNullOrWhiteSpace(publisherTextBox.Text)
                                  && yearComboBox.SelectedIndex != -1
                                  && !string.IsNullOrWhiteSpace(isbnMaskedTextBox.Text)
                                  && genreComboBox.SelectedIndex != -1
                                  && !string.IsNullOrWhiteSpace(totalTextBox.Text);
        }

        private void TotalTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Isbn10RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (isbn10RadioButton.Checked)
                isbnMaskedTextBox.Mask = "000-0-00000-C";
            else
                isbnMaskedTextBox.Mask = "000-0-00-000000-0";
        }

        private void CancelButton_Click(object? sender, EventArgs e) => Close();

        #endregion

        private bool FormIsValid()
        {
            if (isbn10RadioButton.Checked && isbnMaskedTextBox.Text.Length != 10)
            {
                ShowFeedbackMessage("O ISBN-10 deve ser preenchido corretamente", "Adicionar Livro");
                return false;
            }
            else if (isbn13RadioButton.Checked && isbnMaskedTextBox.Text.Length != 13)
            {
                ShowFeedbackMessage("O ISBN-13 deve ser preenchido corretamente", "Adicionar Livro");
                return false;
            }

            if (!ISBNValidator.ValidateISBN(isbnMaskedTextBox.Text))
            {
                ShowFeedbackMessage("ISBN inválido", "Adicionar Livro");
                return false;
            }

            return true;
        }

        private Book IsntantiateBook()
        {
            return new Book()
            {
                Title = titleTextBox.Text.Trim(),
                Author = authorTextBox.Text.Trim(),
                Publisher = publisherTextBox.Text.Trim(),
                PublishYear = (string)yearComboBox.SelectedItem,
                ISBN = isbnMaskedTextBox.Text,
                Genre = (string)genreComboBox.SelectedItem,
                Total = int.Parse(totalTextBox.Text),
            };
        }

        private void LoadBook(Book book)
        {
            titleTextBox.Text = book.Title;
            authorTextBox.Text = book.Author;
            publisherTextBox.Text = book.Publisher;
            yearComboBox.SelectedItem = book.PublishYear;
            isbnMaskedTextBox.Text = book.ISBN;
            genreComboBox.SelectedItem = book.Genre;
            totalTextBox.Text = book.Total.ToString();

            AdjustsFormToUpdate(book);
        }

        private void AdjustsFormToUpdate(Book book)
        {
            if (book.ISBN.Length == 10)
                isbn10RadioButton.Checked = true;

            isbn10RadioButton.Visible = false;
            isbn13RadioButton.Visible = false;

            isbnMaskedTextBox.Enabled = false;

            removeButton.Visible = true;
            addButton.Text = "Atualizar";
        }

        private void ShowFeedbackMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
