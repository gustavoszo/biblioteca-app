namespace LibraryApp.Views
{
    partial class RegisterClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTableLayoutPanel = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            addButton = new ToolStripButton();
            cancelButton = new ToolStripButton();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            emailTableLayoutPanel = new TableLayoutPanel();
            emailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            emailLabel = new MaterialSkin.Controls.MaterialLabel();
            phoneTableLayoutPanel = new TableLayoutPanel();
            phoneLabel = new MaterialSkin.Controls.MaterialLabel();
            phoneMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            documentTableLayoutPanel = new TableLayoutPanel();
            documentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            documentLabel = new MaterialSkin.Controls.MaterialLabel();
            nameTableLayoutPanel = new TableLayoutPanel();
            nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            nameLabel = new MaterialSkin.Controls.MaterialLabel();
            mainTableLayoutPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            emailTableLayoutPanel.SuspendLayout();
            phoneTableLayoutPanel.SuspendLayout();
            documentTableLayoutPanel.SuspendLayout();
            nameTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(toolStrip1, 0, 1);
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 85);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(485, 348);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, cancelButton });
            toolStrip1.Location = new Point(1, 317);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(483, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.Alignment = ToolStripItemAlignment.Right;
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addButton.Enabled = false;
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 27);
            addButton.Text = "Adicionar";
            // 
            // cancelButton
            // 
            cancelButton.Alignment = ToolStripItemAlignment.Right;
            cancelButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelButton.ImageTransparentColor = Color.Magenta;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 27);
            cancelButton.Text = "Cancelar";
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.Controls.Add(emailTableLayoutPanel, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(phoneTableLayoutPanel, 1, 2);
            fieldsTableLayoutPanel.Controls.Add(documentTableLayoutPanel, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(nameTableLayoutPanel, 1, 0);
            fieldsTableLayoutPanel.Dock = DockStyle.Fill;
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(4, 4);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 5;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fieldsTableLayoutPanel.Size = new Size(477, 309);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // emailTableLayoutPanel
            // 
            emailTableLayoutPanel.AutoSize = true;
            emailTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            emailTableLayoutPanel.ColumnCount = 2;
            emailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            emailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            emailTableLayoutPanel.Controls.Add(emailTextBox, 0, 0);
            emailTableLayoutPanel.Controls.Add(emailLabel, 0, 0);
            emailTableLayoutPanel.Dock = DockStyle.Fill;
            emailTableLayoutPanel.Location = new Point(28, 199);
            emailTableLayoutPanel.Name = "emailTableLayoutPanel";
            emailTableLayoutPanel.RowCount = 1;
            emailTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            emailTableLayoutPanel.Size = new Size(419, 58);
            emailTableLayoutPanel.TabIndex = 17;
            // 
            // emailTextBox
            // 
            emailTextBox.AnimateReadOnly = false;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Depth = 0;
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextBox.LeadingIcon = null;
            emailTextBox.Location = new Point(109, 4);
            emailTextBox.MaxLength = 50;
            emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(306, 50);
            emailTextBox.TabIndex = 4;
            emailTextBox.Text = "";
            emailTextBox.TrailingIcon = null;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Depth = 0;
            emailLabel.Dock = DockStyle.Fill;
            emailLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLabel.Location = new Point(4, 1);
            emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(98, 56);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneTableLayoutPanel
            // 
            phoneTableLayoutPanel.AutoSize = true;
            phoneTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            phoneTableLayoutPanel.ColumnCount = 2;
            phoneTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            phoneTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            phoneTableLayoutPanel.Controls.Add(phoneLabel, 0, 0);
            phoneTableLayoutPanel.Controls.Add(phoneMaskedTextBox, 1, 0);
            phoneTableLayoutPanel.Dock = DockStyle.Fill;
            phoneTableLayoutPanel.Location = new Point(28, 134);
            phoneTableLayoutPanel.Name = "phoneTableLayoutPanel";
            phoneTableLayoutPanel.RowCount = 1;
            phoneTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            phoneTableLayoutPanel.Size = new Size(419, 58);
            phoneTableLayoutPanel.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Depth = 0;
            phoneLabel.Dock = DockStyle.Fill;
            phoneLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneLabel.Location = new Point(4, 1);
            phoneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(98, 56);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Telefone";
            phoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneMaskedTextBox
            // 
            phoneMaskedTextBox.AllowPromptAsInput = true;
            phoneMaskedTextBox.AnimateReadOnly = false;
            phoneMaskedTextBox.AsciiOnly = false;
            phoneMaskedTextBox.BackgroundImageLayout = ImageLayout.None;
            phoneMaskedTextBox.BeepOnError = false;
            phoneMaskedTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            phoneMaskedTextBox.Depth = 0;
            phoneMaskedTextBox.Dock = DockStyle.Fill;
            phoneMaskedTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneMaskedTextBox.HidePromptOnLeave = false;
            phoneMaskedTextBox.HideSelection = true;
            phoneMaskedTextBox.InsertKeyMode = InsertKeyMode.Default;
            phoneMaskedTextBox.LeadingIcon = null;
            phoneMaskedTextBox.Location = new Point(109, 5);
            phoneMaskedTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneMaskedTextBox.Mask = "(00) 00000-0000";
            phoneMaskedTextBox.MaxLength = 32767;
            phoneMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            phoneMaskedTextBox.PasswordChar = '\0';
            phoneMaskedTextBox.PrefixSuffixText = null;
            phoneMaskedTextBox.PromptChar = '_';
            phoneMaskedTextBox.ReadOnly = false;
            phoneMaskedTextBox.RejectInputOnFirstFailure = false;
            phoneMaskedTextBox.ResetOnPrompt = true;
            phoneMaskedTextBox.ResetOnSpace = true;
            phoneMaskedTextBox.RightToLeft = RightToLeft.No;
            phoneMaskedTextBox.SelectedText = "";
            phoneMaskedTextBox.SelectionLength = 0;
            phoneMaskedTextBox.SelectionStart = 0;
            phoneMaskedTextBox.ShortcutsEnabled = true;
            phoneMaskedTextBox.Size = new Size(306, 48);
            phoneMaskedTextBox.SkipLiterals = true;
            phoneMaskedTextBox.TabIndex = 3;
            phoneMaskedTextBox.TabStop = false;
            phoneMaskedTextBox.Text = "(  )      -";
            phoneMaskedTextBox.TextAlign = HorizontalAlignment.Left;
            phoneMaskedTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            phoneMaskedTextBox.TrailingIcon = null;
            phoneMaskedTextBox.UseSystemPasswordChar = false;
            phoneMaskedTextBox.ValidatingType = null;
            // 
            // documentTableLayoutPanel
            // 
            documentTableLayoutPanel.AutoSize = true;
            documentTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            documentTableLayoutPanel.ColumnCount = 2;
            documentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            documentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            documentTableLayoutPanel.Controls.Add(documentTextBox, 1, 0);
            documentTableLayoutPanel.Controls.Add(documentLabel, 0, 0);
            documentTableLayoutPanel.Dock = DockStyle.Fill;
            documentTableLayoutPanel.Location = new Point(28, 69);
            documentTableLayoutPanel.Name = "documentTableLayoutPanel";
            documentTableLayoutPanel.RowCount = 1;
            documentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            documentTableLayoutPanel.Size = new Size(419, 58);
            documentTableLayoutPanel.TabIndex = 11;
            // 
            // documentTextBox
            // 
            documentTextBox.AnimateReadOnly = false;
            documentTextBox.BorderStyle = BorderStyle.None;
            documentTextBox.Depth = 0;
            documentTextBox.Dock = DockStyle.Fill;
            documentTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentTextBox.LeadingIcon = null;
            documentTextBox.Location = new Point(109, 4);
            documentTextBox.MaxLength = 50;
            documentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            documentTextBox.Multiline = false;
            documentTextBox.Name = "documentTextBox";
            documentTextBox.Size = new Size(306, 50);
            documentTextBox.TabIndex = 3;
            documentTextBox.Text = "";
            documentTextBox.TrailingIcon = null;
            // 
            // documentLabel
            // 
            documentLabel.AutoSize = true;
            documentLabel.Depth = 0;
            documentLabel.Dock = DockStyle.Fill;
            documentLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentLabel.Location = new Point(4, 1);
            documentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            documentLabel.Name = "documentLabel";
            documentLabel.Size = new Size(98, 56);
            documentLabel.TabIndex = 2;
            documentLabel.Text = "Documento";
            documentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTableLayoutPanel
            // 
            nameTableLayoutPanel.AutoSize = true;
            nameTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            nameTableLayoutPanel.ColumnCount = 2;
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            nameTableLayoutPanel.Controls.Add(nameTextBox, 1, 0);
            nameTableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            nameTableLayoutPanel.Dock = DockStyle.Fill;
            nameTableLayoutPanel.Location = new Point(28, 4);
            nameTableLayoutPanel.Name = "nameTableLayoutPanel";
            nameTableLayoutPanel.RowCount = 1;
            nameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nameTableLayoutPanel.Size = new Size(419, 58);
            nameTableLayoutPanel.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.AnimateReadOnly = false;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Depth = 0;
            nameTextBox.Dock = DockStyle.Fill;
            nameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTextBox.LeadingIcon = null;
            nameTextBox.Location = new Point(109, 4);
            nameTextBox.MaxLength = 50;
            nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nameTextBox.Multiline = false;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(306, 50);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "";
            nameTextBox.TrailingIcon = null;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Depth = 0;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.Location = new Point(4, 1);
            nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(98, 56);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Nome";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 436);
            Controls.Add(mainTableLayoutPanel);
            MaximizeBox = false;
            Name = "RegisterClientForm";
            Padding = new Padding(3, 85, 3, 3);
            ShowIcon = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar cliente";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            emailTableLayoutPanel.ResumeLayout(false);
            emailTableLayoutPanel.PerformLayout();
            phoneTableLayoutPanel.ResumeLayout(false);
            phoneTableLayoutPanel.PerformLayout();
            documentTableLayoutPanel.ResumeLayout(false);
            documentTableLayoutPanel.PerformLayout();
            nameTableLayoutPanel.ResumeLayout(false);
            nameTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton addButton;
        private ToolStripButton cancelButton;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private TableLayoutPanel emailTableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private TableLayoutPanel phoneTableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel phoneLabel;
        private TableLayoutPanel documentTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox documentTextBox;
        private MaterialSkin.Controls.MaterialLabel documentLabel;
        private TableLayoutPanel nameTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialTextBox emailTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox phoneMaskedTextBox;
    }
}