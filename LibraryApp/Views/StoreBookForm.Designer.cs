namespace LibraryApp.Views
{
    partial class StoreBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreBookForm));
            mainTableLayoutPanel = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            addButton = new ToolStripButton();
            removeButton = new ToolStripButton();
            cancelButton = new ToolStripButton();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            totalTableLayoutPanel = new TableLayoutPanel();
            totalTextBox = new MaterialSkin.Controls.MaterialTextBox();
            totalLabel = new MaterialSkin.Controls.MaterialLabel();
            genreTableLayoutPanel = new TableLayoutPanel();
            genreLabel = new MaterialSkin.Controls.MaterialLabel();
            genreComboBox = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel = new TableLayoutPanel();
            isbnLabel = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            isbnMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            isbn10RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            isbn13RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            yearTableLayoutPanel = new TableLayoutPanel();
            yearLabel = new MaterialSkin.Controls.MaterialLabel();
            yearComboBox = new MaterialSkin.Controls.MaterialComboBox();
            publisherTableLayoutPanel = new TableLayoutPanel();
            publisherTextBox = new MaterialSkin.Controls.MaterialTextBox();
            publisherLabel = new MaterialSkin.Controls.MaterialLabel();
            authorTableLayoutPanel = new TableLayoutPanel();
            authorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            authorLabel = new MaterialSkin.Controls.MaterialLabel();
            titleTableLayoutPanel = new TableLayoutPanel();
            titleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            titleLabel = new MaterialSkin.Controls.MaterialLabel();
            mainTableLayoutPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            totalTableLayoutPanel.SuspendLayout();
            genreTableLayoutPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            yearTableLayoutPanel.SuspendLayout();
            publisherTableLayoutPanel.SuspendLayout();
            authorTableLayoutPanel.SuspendLayout();
            titleTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(toolStrip1, 0, 1);
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 85);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.5207748F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.479224F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(512, 512);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, removeButton, cancelButton });
            toolStrip1.Location = new Point(0, 482);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(512, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.Alignment = ToolStripItemAlignment.Right;
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addButton.Enabled = false;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 27);
            addButton.Text = "Adicionar";
            // 
            // removeButton
            // 
            removeButton.Alignment = ToolStripItemAlignment.Right;
            removeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.ImageTransparentColor = Color.Magenta;
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(81, 27);
            removeButton.Text = "Remover";
            removeButton.Visible = false;
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
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.Controls.Add(totalTableLayoutPanel, 1, 6);
            fieldsTableLayoutPanel.Controls.Add(genreTableLayoutPanel, 1, 5);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel, 1, 4);
            fieldsTableLayoutPanel.Controls.Add(yearTableLayoutPanel, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(publisherTableLayoutPanel, 1, 2);
            fieldsTableLayoutPanel.Controls.Add(authorTableLayoutPanel, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(titleTableLayoutPanel, 1, 0);
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(3, 3);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 7;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.Size = new Size(506, 467);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // totalTableLayoutPanel
            // 
            totalTableLayoutPanel.ColumnCount = 2;
            totalTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            totalTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            totalTableLayoutPanel.Controls.Add(totalTextBox, 1, 0);
            totalTableLayoutPanel.Controls.Add(totalLabel, 0, 0);
            totalTableLayoutPanel.Dock = DockStyle.Fill;
            totalTableLayoutPanel.Location = new Point(28, 399);
            totalTableLayoutPanel.Name = "totalTableLayoutPanel";
            totalTableLayoutPanel.RowCount = 1;
            totalTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalTableLayoutPanel.Size = new Size(449, 65);
            totalTableLayoutPanel.TabIndex = 26;
            // 
            // totalTextBox
            // 
            totalTextBox.Anchor = AnchorStyles.Left;
            totalTextBox.AnimateReadOnly = false;
            totalTextBox.BorderStyle = BorderStyle.None;
            totalTextBox.Depth = 0;
            totalTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalTextBox.LeadingIcon = null;
            totalTextBox.Location = new Point(92, 7);
            totalTextBox.MaxLength = 3;
            totalTextBox.MouseState = MaterialSkin.MouseState.OUT;
            totalTextBox.Multiline = false;
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(89, 50);
            totalTextBox.TabIndex = 3;
            totalTextBox.Text = "";
            totalTextBox.TrailingIcon = null;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Depth = 0;
            totalLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalLabel.Location = new Point(3, 23);
            totalLabel.MouseState = MaterialSkin.MouseState.HOVER;
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(83, 19);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "Quantidade";
            // 
            // genreTableLayoutPanel
            // 
            genreTableLayoutPanel.ColumnCount = 2;
            genreTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            genreTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            genreTableLayoutPanel.Controls.Add(genreLabel, 0, 0);
            genreTableLayoutPanel.Controls.Add(genreComboBox, 1, 0);
            genreTableLayoutPanel.Dock = DockStyle.Fill;
            genreTableLayoutPanel.Location = new Point(28, 333);
            genreTableLayoutPanel.Name = "genreTableLayoutPanel";
            genreTableLayoutPanel.RowCount = 1;
            genreTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            genreTableLayoutPanel.Size = new Size(449, 60);
            genreTableLayoutPanel.TabIndex = 23;
            // 
            // genreLabel
            // 
            genreLabel.Anchor = AnchorStyles.Right;
            genreLabel.AutoSize = true;
            genreLabel.Depth = 0;
            genreLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            genreLabel.Location = new Point(35, 20);
            genreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(51, 19);
            genreLabel.TabIndex = 2;
            genreLabel.Text = "Genêro";
            // 
            // genreComboBox
            // 
            genreComboBox.AutoResize = false;
            genreComboBox.BackColor = Color.FromArgb(255, 255, 255);
            genreComboBox.Depth = 0;
            genreComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            genreComboBox.DropDownHeight = 174;
            genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreComboBox.DropDownWidth = 121;
            genreComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            genreComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            genreComboBox.FormattingEnabled = true;
            genreComboBox.IntegralHeight = false;
            genreComboBox.ItemHeight = 43;
            genreComboBox.Items.AddRange(new object[] { "Administração", "Aventura", "Autoajuda", "Autobiografia", "Biografia", "Ciências exatas", "Ciências sociais", "Comédia", "Conto", "Contos de fadas", "Crônicas", "Desenvolvimento pessoal", "Direito", "Distopia", "Drama", "Economia", "Educação", "Ensaio", "Engenharia", "Espiritualidade / Religião", "Esportes", "Fantasia", "Fábulas", "Ficção contemporânea", "Ficção científica", "Ficção infantil", "Ficção jovem adulta (YA)", "Ficção sobrenatural", "Filosofia", "Graphic novel", "História", "Horror / Terror", "HQs (Quadrinhos)", "Literatura juvenil", "Linguística", "Mangá", "Medicina", "Memórias", "Mistério", "Negócios / Empreendedorismo", "Poesia", "Policial / Crime", "Política", "Psicologia", "Quadrinhos (HQs)", "Romance", "Saúde / Bem-estar", "Suspense", "Teatro", "Tecnologia", "TI", "Thriller psicológico", "Viagens" });
            genreComboBox.Location = new Point(92, 4);
            genreComboBox.Margin = new Padding(3, 4, 3, 4);
            genreComboBox.MaxDropDownItems = 4;
            genreComboBox.MouseState = MaterialSkin.MouseState.OUT;
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(221, 49);
            genreComboBox.StartIndex = 0;
            genreComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel.Controls.Add(isbnLabel, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(28, 267);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(449, 60);
            tableLayoutPanel.TabIndex = 20;
            // 
            // isbnLabel
            // 
            isbnLabel.Anchor = AnchorStyles.Right;
            isbnLabel.AutoSize = true;
            isbnLabel.Depth = 0;
            isbnLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            isbnLabel.Location = new Point(50, 20);
            isbnLabel.MouseState = MaterialSkin.MouseState.HOVER;
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(36, 19);
            isbnLabel.TabIndex = 2;
            isbnLabel.Text = "ISBN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(isbnMaskedTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(92, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(354, 52);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // isbnMaskedTextBox
            // 
            isbnMaskedTextBox.AllowPromptAsInput = true;
            isbnMaskedTextBox.AnimateReadOnly = false;
            isbnMaskedTextBox.AsciiOnly = false;
            isbnMaskedTextBox.BackgroundImageLayout = ImageLayout.None;
            isbnMaskedTextBox.BeepOnError = false;
            isbnMaskedTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            isbnMaskedTextBox.Depth = 0;
            isbnMaskedTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            isbnMaskedTextBox.HelperText = "Texto";
            isbnMaskedTextBox.HidePromptOnLeave = false;
            isbnMaskedTextBox.HideSelection = true;
            isbnMaskedTextBox.InsertKeyMode = InsertKeyMode.Default;
            isbnMaskedTextBox.LeadingIcon = null;
            isbnMaskedTextBox.Location = new Point(3, 4);
            isbnMaskedTextBox.Margin = new Padding(3, 4, 3, 4);
            isbnMaskedTextBox.Mask = "000-0-00-000000-0";
            isbnMaskedTextBox.MaxLength = 32767;
            isbnMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            isbnMaskedTextBox.Name = "isbnMaskedTextBox";
            isbnMaskedTextBox.PasswordChar = '\0';
            isbnMaskedTextBox.PrefixSuffixText = null;
            isbnMaskedTextBox.PromptChar = '_';
            isbnMaskedTextBox.ReadOnly = false;
            isbnMaskedTextBox.RejectInputOnFirstFailure = false;
            isbnMaskedTextBox.ResetOnPrompt = true;
            isbnMaskedTextBox.ResetOnSpace = true;
            isbnMaskedTextBox.RightToLeft = RightToLeft.No;
            isbnMaskedTextBox.SelectedText = "";
            isbnMaskedTextBox.SelectionLength = 0;
            isbnMaskedTextBox.SelectionStart = 0;
            isbnMaskedTextBox.ShortcutsEnabled = true;
            isbnMaskedTextBox.Size = new Size(165, 48);
            isbnMaskedTextBox.SkipLiterals = true;
            isbnMaskedTextBox.TabIndex = 5;
            isbnMaskedTextBox.TabStop = false;
            isbnMaskedTextBox.TextAlign = HorizontalAlignment.Left;
            isbnMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            isbnMaskedTextBox.TrailingIcon = null;
            isbnMaskedTextBox.UseSystemPasswordChar = false;
            isbnMaskedTextBox.ValidatingType = null;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(isbn10RadioButton, 0, 0);
            tableLayoutPanel2.Controls.Add(isbn13RadioButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(180, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(171, 44);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // isbn10RadioButton
            // 
            isbn10RadioButton.AutoSize = true;
            isbn10RadioButton.Depth = 0;
            isbn10RadioButton.Location = new Point(0, 0);
            isbn10RadioButton.Margin = new Padding(0);
            isbn10RadioButton.MouseLocation = new Point(-1, -1);
            isbn10RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            isbn10RadioButton.Name = "isbn10RadioButton";
            isbn10RadioButton.Ripple = true;
            isbn10RadioButton.Size = new Size(85, 22);
            isbn10RadioButton.TabIndex = 0;
            isbn10RadioButton.TabStop = true;
            isbn10RadioButton.Text = "ISBN 10";
            isbn10RadioButton.UseVisualStyleBackColor = true;
            // 
            // isbn13RadioButton
            // 
            isbn13RadioButton.AutoSize = true;
            isbn13RadioButton.Checked = true;
            isbn13RadioButton.Depth = 0;
            isbn13RadioButton.Location = new Point(0, 22);
            isbn13RadioButton.Margin = new Padding(0);
            isbn13RadioButton.MouseLocation = new Point(-1, -1);
            isbn13RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            isbn13RadioButton.Name = "isbn13RadioButton";
            isbn13RadioButton.Ripple = true;
            isbn13RadioButton.Size = new Size(85, 22);
            isbn13RadioButton.TabIndex = 1;
            isbn13RadioButton.TabStop = true;
            isbn13RadioButton.Text = "ISBN 13";
            isbn13RadioButton.UseVisualStyleBackColor = true;
            // 
            // yearTableLayoutPanel
            // 
            yearTableLayoutPanel.ColumnCount = 2;
            yearTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            yearTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            yearTableLayoutPanel.Controls.Add(yearLabel, 0, 0);
            yearTableLayoutPanel.Controls.Add(yearComboBox, 1, 0);
            yearTableLayoutPanel.Dock = DockStyle.Fill;
            yearTableLayoutPanel.Location = new Point(28, 201);
            yearTableLayoutPanel.Name = "yearTableLayoutPanel";
            yearTableLayoutPanel.RowCount = 1;
            yearTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            yearTableLayoutPanel.Size = new Size(449, 60);
            yearTableLayoutPanel.TabIndex = 17;
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Right;
            yearLabel.AutoSize = true;
            yearLabel.Depth = 0;
            yearLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            yearLabel.Location = new Point(57, 20);
            yearLabel.MouseState = MaterialSkin.MouseState.HOVER;
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(29, 19);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "Ano";
            // 
            // yearComboBox
            // 
            yearComboBox.AutoResize = false;
            yearComboBox.BackColor = Color.FromArgb(255, 255, 255);
            yearComboBox.Depth = 0;
            yearComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            yearComboBox.DropDownHeight = 174;
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.DropDownWidth = 121;
            yearComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            yearComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            yearComboBox.FormattingEnabled = true;
            yearComboBox.IntegralHeight = false;
            yearComboBox.ItemHeight = 43;
            yearComboBox.Location = new Point(92, 4);
            yearComboBox.Margin = new Padding(3, 4, 3, 4);
            yearComboBox.MaxDropDownItems = 4;
            yearComboBox.MouseState = MaterialSkin.MouseState.OUT;
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(134, 49);
            yearComboBox.StartIndex = 0;
            yearComboBox.TabIndex = 3;
            // 
            // publisherTableLayoutPanel
            // 
            publisherTableLayoutPanel.ColumnCount = 2;
            publisherTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            publisherTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            publisherTableLayoutPanel.Controls.Add(publisherTextBox, 1, 0);
            publisherTableLayoutPanel.Controls.Add(publisherLabel, 0, 0);
            publisherTableLayoutPanel.Dock = DockStyle.Fill;
            publisherTableLayoutPanel.Location = new Point(28, 135);
            publisherTableLayoutPanel.Name = "publisherTableLayoutPanel";
            publisherTableLayoutPanel.RowCount = 1;
            publisherTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            publisherTableLayoutPanel.Size = new Size(449, 60);
            publisherTableLayoutPanel.TabIndex = 14;
            // 
            // publisherTextBox
            // 
            publisherTextBox.Anchor = AnchorStyles.Left;
            publisherTextBox.AnimateReadOnly = false;
            publisherTextBox.BorderStyle = BorderStyle.None;
            publisherTextBox.Depth = 0;
            publisherTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            publisherTextBox.LeadingIcon = null;
            publisherTextBox.Location = new Point(92, 5);
            publisherTextBox.MaxLength = 50;
            publisherTextBox.MouseState = MaterialSkin.MouseState.OUT;
            publisherTextBox.Multiline = false;
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new Size(334, 50);
            publisherTextBox.TabIndex = 3;
            publisherTextBox.Text = "";
            publisherTextBox.TrailingIcon = null;
            // 
            // publisherLabel
            // 
            publisherLabel.Anchor = AnchorStyles.Right;
            publisherLabel.AutoSize = true;
            publisherLabel.Depth = 0;
            publisherLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            publisherLabel.Location = new Point(35, 20);
            publisherLabel.MouseState = MaterialSkin.MouseState.HOVER;
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(51, 19);
            publisherLabel.TabIndex = 2;
            publisherLabel.Text = "Editora";
            // 
            // authorTableLayoutPanel
            // 
            authorTableLayoutPanel.ColumnCount = 2;
            authorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            authorTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            authorTableLayoutPanel.Controls.Add(authorTextBox, 1, 0);
            authorTableLayoutPanel.Controls.Add(authorLabel, 0, 0);
            authorTableLayoutPanel.Dock = DockStyle.Fill;
            authorTableLayoutPanel.Location = new Point(28, 69);
            authorTableLayoutPanel.Name = "authorTableLayoutPanel";
            authorTableLayoutPanel.RowCount = 1;
            authorTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            authorTableLayoutPanel.Size = new Size(449, 60);
            authorTableLayoutPanel.TabIndex = 11;
            // 
            // authorTextBox
            // 
            authorTextBox.Anchor = AnchorStyles.Left;
            authorTextBox.AnimateReadOnly = false;
            authorTextBox.BorderStyle = BorderStyle.None;
            authorTextBox.Depth = 0;
            authorTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            authorTextBox.LeadingIcon = null;
            authorTextBox.Location = new Point(92, 5);
            authorTextBox.MaxLength = 50;
            authorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            authorTextBox.Multiline = false;
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(334, 50);
            authorTextBox.TabIndex = 3;
            authorTextBox.Text = "";
            authorTextBox.TrailingIcon = null;
            // 
            // authorLabel
            // 
            authorLabel.Anchor = AnchorStyles.Right;
            authorLabel.AutoSize = true;
            authorLabel.Depth = 0;
            authorLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            authorLabel.Location = new Point(47, 20);
            authorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(39, 19);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Autor";
            // 
            // titleTableLayoutPanel
            // 
            titleTableLayoutPanel.AutoSize = true;
            titleTableLayoutPanel.ColumnCount = 2;
            titleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            titleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            titleTableLayoutPanel.Controls.Add(titleTextBox, 1, 0);
            titleTableLayoutPanel.Controls.Add(titleLabel, 0, 0);
            titleTableLayoutPanel.Dock = DockStyle.Fill;
            titleTableLayoutPanel.Location = new Point(28, 3);
            titleTableLayoutPanel.Name = "titleTableLayoutPanel";
            titleTableLayoutPanel.RowCount = 1;
            titleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            titleTableLayoutPanel.Size = new Size(449, 60);
            titleTableLayoutPanel.TabIndex = 7;
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.Left;
            titleTextBox.AnimateReadOnly = false;
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Depth = 0;
            titleTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleTextBox.LeadingIcon = null;
            titleTextBox.Location = new Point(92, 5);
            titleTextBox.MaxLength = 50;
            titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            titleTextBox.Multiline = false;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(334, 50);
            titleTextBox.TabIndex = 3;
            titleTextBox.Text = "";
            titleTextBox.TrailingIcon = null;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Depth = 0;
            titleLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleLabel.Location = new Point(44, 20);
            titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 19);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Titulo";
            // 
            // StoreBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 600);
            Controls.Add(mainTableLayoutPanel);
            MaximizeBox = false;
            Name = "StoreBookForm";
            Padding = new Padding(3, 85, 3, 3);
            ShowIcon = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Livro";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            totalTableLayoutPanel.ResumeLayout(false);
            totalTableLayoutPanel.PerformLayout();
            genreTableLayoutPanel.ResumeLayout(false);
            genreTableLayoutPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            yearTableLayoutPanel.ResumeLayout(false);
            yearTableLayoutPanel.PerformLayout();
            publisherTableLayoutPanel.ResumeLayout(false);
            publisherTableLayoutPanel.PerformLayout();
            authorTableLayoutPanel.ResumeLayout(false);
            authorTableLayoutPanel.PerformLayout();
            titleTableLayoutPanel.ResumeLayout(false);
            titleTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton addButton;
        private ToolStripButton cancelButton;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private TableLayoutPanel totalTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox totalTextBox;
        private MaterialSkin.Controls.MaterialLabel totalLabel;
        private TableLayoutPanel genreTableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel genreLabel;
        private TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel isbnLabel;
        private TableLayoutPanel yearTableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel yearLabel;
        private TableLayoutPanel publisherTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox publisherTextBox;
        private MaterialSkin.Controls.MaterialLabel publisherLabel;
        private TableLayoutPanel authorTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox authorTextBox;
        private MaterialSkin.Controls.MaterialLabel authorLabel;
        private TableLayoutPanel titleTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox titleTextBox;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialComboBox genreComboBox;
        private MaterialSkin.Controls.MaterialComboBox yearComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox isbnMaskedTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialRadioButton isbn10RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton isbn13RadioButton;
        private ToolStripButton removeButton;
    }
}