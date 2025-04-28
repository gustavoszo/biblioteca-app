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
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(toolStrip1, 0, 1);
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 64);
            mainTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.5207748F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.479224F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTableLayoutPanel.Size = new Size(424, 261);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, cancelButton });
            toolStrip1.Location = new Point(0, 241);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(424, 20);
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
            addButton.Size = new Size(70, 17);
            addButton.Text = "Adicionar";
            // 
            // cancelButton
            // 
            cancelButton.Alignment = ToolStripItemAlignment.Right;
            cancelButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelButton.ImageTransparentColor = Color.Magenta;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(65, 17);
            cancelButton.Text = "Cancelar";
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.Controls.Add(emailTableLayoutPanel, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(phoneTableLayoutPanel, 1, 2);
            fieldsTableLayoutPanel.Controls.Add(documentTableLayoutPanel, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(nameTableLayoutPanel, 1, 0);
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(3, 4);
            fieldsTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 4;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.Size = new Size(418, 232);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // emailTableLayoutPanel
            // 
            emailTableLayoutPanel.ColumnCount = 2;
            emailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            emailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            emailTableLayoutPanel.Controls.Add(emailTextBox, 0, 0);
            emailTableLayoutPanel.Controls.Add(emailLabel, 0, 0);
            emailTableLayoutPanel.Dock = DockStyle.Fill;
            emailTableLayoutPanel.Location = new Point(23, 176);
            emailTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            emailTableLayoutPanel.Name = "emailTableLayoutPanel";
            emailTableLayoutPanel.RowCount = 1;
            emailTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            emailTableLayoutPanel.Size = new Size(370, 54);
            emailTableLayoutPanel.TabIndex = 17;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left;
            emailTextBox.AnimateReadOnly = false;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Depth = 0;
            emailTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextBox.LeadingIcon = null;
            emailTextBox.Location = new Point(95, 2);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.MaxLength = 50;
            emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            emailTextBox.Multiline = false;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(272, 50);
            emailTextBox.TabIndex = 4;
            emailTextBox.Text = "";
            emailTextBox.TrailingIcon = null;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Depth = 0;
            emailLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLabel.Location = new Point(48, 17);
            emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 19);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // phoneTableLayoutPanel
            // 
            phoneTableLayoutPanel.ColumnCount = 2;
            phoneTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            phoneTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            phoneTableLayoutPanel.Controls.Add(phoneLabel, 0, 0);
            phoneTableLayoutPanel.Controls.Add(phoneMaskedTextBox, 1, 0);
            phoneTableLayoutPanel.Dock = DockStyle.Fill;
            phoneTableLayoutPanel.Location = new Point(23, 118);
            phoneTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            phoneTableLayoutPanel.Name = "phoneTableLayoutPanel";
            phoneTableLayoutPanel.RowCount = 1;
            phoneTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            phoneTableLayoutPanel.Size = new Size(370, 54);
            phoneTableLayoutPanel.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Right;
            phoneLabel.AutoSize = true;
            phoneLabel.Depth = 0;
            phoneLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneLabel.Location = new Point(26, 17);
            phoneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(63, 19);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Telefone";
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
            phoneMaskedTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneMaskedTextBox.HidePromptOnLeave = false;
            phoneMaskedTextBox.HideSelection = true;
            phoneMaskedTextBox.InsertKeyMode = InsertKeyMode.Default;
            phoneMaskedTextBox.LeadingIcon = null;
            phoneMaskedTextBox.Location = new Point(95, 3);
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
            phoneMaskedTextBox.Size = new Size(272, 48);
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
            documentTableLayoutPanel.ColumnCount = 2;
            documentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            documentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            documentTableLayoutPanel.Controls.Add(documentTextBox, 1, 0);
            documentTableLayoutPanel.Controls.Add(documentLabel, 0, 0);
            documentTableLayoutPanel.Dock = DockStyle.Fill;
            documentTableLayoutPanel.Location = new Point(23, 60);
            documentTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            documentTableLayoutPanel.Name = "documentTableLayoutPanel";
            documentTableLayoutPanel.RowCount = 1;
            documentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            documentTableLayoutPanel.Size = new Size(370, 54);
            documentTableLayoutPanel.TabIndex = 11;
            // 
            // documentTextBox
            // 
            documentTextBox.Anchor = AnchorStyles.Left;
            documentTextBox.AnimateReadOnly = false;
            documentTextBox.BorderStyle = BorderStyle.None;
            documentTextBox.Depth = 0;
            documentTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentTextBox.LeadingIcon = null;
            documentTextBox.Location = new Point(95, 2);
            documentTextBox.Margin = new Padding(3, 2, 3, 2);
            documentTextBox.MaxLength = 50;
            documentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            documentTextBox.Multiline = false;
            documentTextBox.Name = "documentTextBox";
            documentTextBox.Size = new Size(272, 50);
            documentTextBox.TabIndex = 3;
            documentTextBox.Text = "";
            documentTextBox.TrailingIcon = null;
            // 
            // documentLabel
            // 
            documentLabel.Anchor = AnchorStyles.Right;
            documentLabel.AutoSize = true;
            documentLabel.Depth = 0;
            documentLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentLabel.Location = new Point(6, 17);
            documentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            documentLabel.Name = "documentLabel";
            documentLabel.Size = new Size(83, 19);
            documentLabel.TabIndex = 2;
            documentLabel.Text = "Documento";
            // 
            // nameTableLayoutPanel
            // 
            nameTableLayoutPanel.AutoSize = true;
            nameTableLayoutPanel.ColumnCount = 2;
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            nameTableLayoutPanel.Controls.Add(nameTextBox, 1, 0);
            nameTableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            nameTableLayoutPanel.Dock = DockStyle.Fill;
            nameTableLayoutPanel.Location = new Point(23, 2);
            nameTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            nameTableLayoutPanel.Name = "nameTableLayoutPanel";
            nameTableLayoutPanel.RowCount = 1;
            nameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nameTableLayoutPanel.Size = new Size(370, 54);
            nameTableLayoutPanel.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left;
            nameTextBox.AnimateReadOnly = false;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Depth = 0;
            nameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameTextBox.LeadingIcon = null;
            nameTextBox.Location = new Point(95, 2);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.MaxLength = 50;
            nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            nameTextBox.Multiline = false;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(272, 50);
            nameTextBox.TabIndex = 3;
            nameTextBox.Text = "";
            nameTextBox.TrailingIcon = null;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Depth = 0;
            nameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.Location = new Point(46, 17);
            nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 19);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Nome";
            // 
            // RegisterClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 327);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegisterClientForm";
            Padding = new Padding(3, 64, 3, 2);
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