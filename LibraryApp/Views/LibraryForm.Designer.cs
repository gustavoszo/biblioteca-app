namespace LibraryApp
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            mainTableLayoutPanel = new TableLayoutPanel();
            toolStrip = new ToolStrip();
            exitButton = new ToolStripButton();
            tabControl = new TabControl();
            loanTabPage = new TabPage();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            documentLabel = new MaterialSkin.Controls.MaterialLabel();
            documentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            fieldsTwoTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            bookLabel = new MaterialSkin.Controls.MaterialLabel();
            bookComboBox = new MaterialSkin.Controls.MaterialComboBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            quantityLabel = new MaterialSkin.Controls.MaterialLabel();
            quantityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            loanBookButton = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            devolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            returnDateTimePicker = new DateTimePicker();
            flowLayoutPanel9 = new FlowLayoutPanel();
            confirmLoanButton = new MaterialSkin.Controls.MaterialButton();
            loanDetailsButton = new MaterialSkin.Controls.MaterialButton();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            viewLoansButton = new MaterialSkin.Controls.MaterialButton();
            bookTabPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            addBookButton = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            advancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            TitleColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            PublisherColumn = new DataGridViewTextBoxColumn();
            isbnColumn = new DataGridViewTextBoxColumn();
            totalColumn = new DataGridViewTextBoxColumn();
            quantity_availableColumn = new DataGridViewTextBoxColumn();
            editColumn = new DataGridViewButtonColumn();
            searchToolBar = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            miniToolStrip = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            mainTableLayoutPanel.SuspendLayout();
            toolStrip.SuspendLayout();
            tabControl.SuspendLayout();
            loanTabPage.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            fieldsTwoTableLayoutPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            bookTabPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.05269F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.94731F));
            mainTableLayoutPanel.Controls.Add(toolStrip, 0, 1);
            mainTableLayoutPanel.Controls.Add(tabControl, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 48);
            mainTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6850357F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31496048F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTableLayoutPanel.Size = new Size(693, 368);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { exitButton });
            toolStrip.Location = new Point(0, 348);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(693, 20);
            toolStrip.TabIndex = 5;
            toolStrip.Text = "toolStrip1";
            // 
            // exitButton
            // 
            exitButton.Alignment = ToolStripItemAlignment.Right;
            exitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            exitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.ImageTransparentColor = Color.Magenta;
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 17);
            exitButton.Text = "Sair";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(loanTabPage);
            tabControl.Controls.Add(bookTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(3, 2);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(687, 344);
            tabControl.TabIndex = 1;
            // 
            // loanTabPage
            // 
            loanTabPage.Controls.Add(fieldsTableLayoutPanel);
            loanTabPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanTabPage.ForeColor = SystemColors.ControlText;
            loanTabPage.Location = new Point(4, 30);
            loanTabPage.Margin = new Padding(3, 2, 3, 2);
            loanTabPage.Name = "loanTabPage";
            loanTabPage.Padding = new Padding(3, 2, 3, 2);
            loanTabPage.Size = new Size(679, 310);
            loanTabPage.TabIndex = 0;
            loanTabPage.Text = "Locação";
            loanTabPage.UseVisualStyleBackColor = true;
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            fieldsTableLayoutPanel.ColumnCount = 2;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 1);
            fieldsTableLayoutPanel.Controls.Add(fieldsTwoTableLayoutPanel, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(viewLoansButton, 0, 0);
            fieldsTableLayoutPanel.Dock = DockStyle.Fill;
            fieldsTableLayoutPanel.Location = new Point(3, 2);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 2;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            fieldsTableLayoutPanel.Size = new Size(673, 306);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 254);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BackColor = SystemColors.Control;
            flowLayoutPanel3.Controls.Add(documentLabel);
            flowLayoutPanel3.Controls.Add(documentTextBox);
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(216, 75);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // documentLabel
            // 
            documentLabel.AutoSize = true;
            documentLabel.Depth = 0;
            documentLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentLabel.Location = new Point(3, 0);
            documentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            documentLabel.Name = "documentLabel";
            documentLabel.Size = new Size(162, 19);
            documentLabel.TabIndex = 0;
            documentLabel.Text = "Documento do usuário";
            // 
            // documentTextBox
            // 
            documentTextBox.AnimateReadOnly = false;
            documentTextBox.BorderStyle = BorderStyle.None;
            documentTextBox.Depth = 0;
            documentTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            documentTextBox.LeadingIcon = null;
            documentTextBox.Location = new Point(3, 22);
            documentTextBox.MaxLength = 50;
            documentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            documentTextBox.Multiline = false;
            documentTextBox.Name = "documentTextBox";
            documentTextBox.Size = new Size(210, 50);
            documentTextBox.TabIndex = 1;
            documentTextBox.Text = "";
            documentTextBox.TrailingIcon = null;
            // 
            // fieldsTwoTableLayoutPanel
            // 
            fieldsTwoTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            fieldsTwoTableLayoutPanel.ColumnCount = 1;
            fieldsTwoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 0);
            fieldsTwoTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            fieldsTwoTableLayoutPanel.Dock = DockStyle.Fill;
            fieldsTwoTableLayoutPanel.Location = new Point(239, 48);
            fieldsTwoTableLayoutPanel.Name = "fieldsTwoTableLayoutPanel";
            fieldsTwoTableLayoutPanel.RowCount = 2;
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fieldsTwoTableLayoutPanel.Size = new Size(430, 254);
            fieldsTwoTableLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(5, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(420, 118);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.BackColor = SystemColors.Control;
            flowLayoutPanel4.Controls.Add(bookLabel);
            flowLayoutPanel4.Controls.Add(bookComboBox);
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(243, 55);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // bookLabel
            // 
            bookLabel.Anchor = AnchorStyles.None;
            bookLabel.AutoSize = true;
            bookLabel.Depth = 0;
            bookLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            bookLabel.Location = new Point(3, 18);
            bookLabel.MouseState = MaterialSkin.MouseState.HOVER;
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(36, 19);
            bookLabel.TabIndex = 0;
            bookLabel.Text = "Livro";
            // 
            // bookComboBox
            // 
            bookComboBox.AutoResize = false;
            bookComboBox.BackColor = Color.FromArgb(255, 255, 255);
            bookComboBox.Depth = 0;
            bookComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            bookComboBox.DropDownHeight = 174;
            bookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookComboBox.DropDownWidth = 121;
            bookComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            bookComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            bookComboBox.FormattingEnabled = true;
            bookComboBox.IntegralHeight = false;
            bookComboBox.ItemHeight = 43;
            bookComboBox.Location = new Point(45, 3);
            bookComboBox.MaxDropDownItems = 4;
            bookComboBox.MouseState = MaterialSkin.MouseState.OUT;
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(195, 49);
            bookComboBox.StartIndex = 0;
            bookComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.BackColor = SystemColors.Control;
            flowLayoutPanel5.Controls.Add(quantityLabel);
            flowLayoutPanel5.Controls.Add(quantityComboBox);
            flowLayoutPanel5.Location = new Point(252, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(162, 55);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.None;
            quantityLabel.AutoSize = true;
            quantityLabel.Depth = 0;
            quantityLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            quantityLabel.Location = new Point(3, 18);
            quantityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(83, 19);
            quantityLabel.TabIndex = 0;
            quantityLabel.Text = "Quantidade";
            // 
            // quantityComboBox
            // 
            quantityComboBox.AutoResize = false;
            quantityComboBox.BackColor = Color.FromArgb(255, 255, 255);
            quantityComboBox.Depth = 0;
            quantityComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            quantityComboBox.DropDownHeight = 174;
            quantityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            quantityComboBox.DropDownWidth = 121;
            quantityComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            quantityComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            quantityComboBox.FormattingEnabled = true;
            quantityComboBox.IntegralHeight = false;
            quantityComboBox.ItemHeight = 43;
            quantityComboBox.Location = new Point(92, 3);
            quantityComboBox.MaxDropDownItems = 4;
            quantityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            quantityComboBox.Name = "quantityComboBox";
            quantityComboBox.Size = new Size(67, 49);
            quantityComboBox.StartIndex = 0;
            quantityComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Location = new Point(3, 64);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(0, 0);
            flowLayoutPanel6.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(loanBookButton);
            flowLayoutPanel8.Location = new Point(9, 64);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(106, 48);
            flowLayoutPanel8.TabIndex = 4;
            // 
            // loanBookButton
            // 
            loanBookButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loanBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loanBookButton.Depth = 0;
            loanBookButton.Enabled = false;
            loanBookButton.HighEmphasis = true;
            loanBookButton.Icon = null;
            loanBookButton.Location = new Point(4, 6);
            loanBookButton.Margin = new Padding(4, 6, 4, 6);
            loanBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            loanBookButton.Name = "loanBookButton";
            loanBookButton.NoAccentTextColor = Color.Empty;
            loanBookButton.Size = new Size(98, 36);
            loanBookButton.TabIndex = 0;
            loanBookButton.Text = "Adicionar";
            loanBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loanBookButton.UseAccentColor = false;
            loanBookButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel7, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel9, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 131);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(420, 118);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.BackColor = SystemColors.Control;
            flowLayoutPanel7.Controls.Add(devolutionLabel);
            flowLayoutPanel7.Controls.Add(returnDateTimePicker);
            flowLayoutPanel7.Location = new Point(3, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(334, 53);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // devolutionLabel
            // 
            devolutionLabel.Anchor = AnchorStyles.None;
            devolutionLabel.AutoSize = true;
            devolutionLabel.Depth = 0;
            devolutionLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            devolutionLabel.Location = new Point(3, 0);
            devolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            devolutionLabel.Name = "devolutionLabel";
            devolutionLabel.Size = new Size(76, 19);
            devolutionLabel.TabIndex = 0;
            devolutionLabel.Text = "Devolução";
            // 
            // returnDateTimePicker
            // 
            returnDateTimePicker.Location = new Point(3, 22);
            returnDateTimePicker.MaxDate = new DateTime(2040, 12, 25, 23, 59, 59, 0);
            returnDateTimePicker.MinDate = new DateTime(2025, 4, 25, 0, 0, 0, 0);
            returnDateTimePicker.Name = "returnDateTimePicker";
            returnDateTimePicker.Size = new Size(328, 29);
            returnDateTimePicker.TabIndex = 3;
            returnDateTimePicker.Value = new DateTime(2025, 4, 25, 0, 0, 0, 0);
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.Controls.Add(confirmLoanButton);
            flowLayoutPanel9.Controls.Add(loanDetailsButton);
            flowLayoutPanel9.Controls.Add(cancelButton);
            flowLayoutPanel9.Font = new Font("Segoe UI", 10F);
            flowLayoutPanel9.Location = new Point(3, 67);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(382, 48);
            flowLayoutPanel9.TabIndex = 7;
            // 
            // confirmLoanButton
            // 
            confirmLoanButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmLoanButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            confirmLoanButton.Depth = 0;
            confirmLoanButton.Enabled = false;
            confirmLoanButton.Font = new Font("Segoe UI", 12F);
            confirmLoanButton.HighEmphasis = true;
            confirmLoanButton.Icon = null;
            confirmLoanButton.Location = new Point(4, 6);
            confirmLoanButton.Margin = new Padding(4, 6, 4, 6);
            confirmLoanButton.MouseState = MaterialSkin.MouseState.HOVER;
            confirmLoanButton.Name = "confirmLoanButton";
            confirmLoanButton.NoAccentTextColor = Color.Empty;
            confirmLoanButton.Size = new Size(159, 36);
            confirmLoanButton.TabIndex = 8;
            confirmLoanButton.Text = "Realizar locação";
            confirmLoanButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            confirmLoanButton.UseAccentColor = false;
            confirmLoanButton.UseVisualStyleBackColor = true;
            // 
            // loanDetailsButton
            // 
            loanDetailsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loanDetailsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loanDetailsButton.Depth = 0;
            loanDetailsButton.Font = new Font("Segoe UI", 12F);
            loanDetailsButton.HighEmphasis = true;
            loanDetailsButton.Icon = null;
            loanDetailsButton.Location = new Point(171, 6);
            loanDetailsButton.Margin = new Padding(4, 6, 4, 6);
            loanDetailsButton.MouseState = MaterialSkin.MouseState.HOVER;
            loanDetailsButton.Name = "loanDetailsButton";
            loanDetailsButton.NoAccentTextColor = Color.Empty;
            loanDetailsButton.Size = new Size(103, 36);
            loanDetailsButton.TabIndex = 10;
            loanDetailsButton.Text = "Visualizar";
            loanDetailsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loanDetailsButton.UseAccentColor = false;
            loanDetailsButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.Enabled = false;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(282, 6);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(96, 36);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancelar";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // viewLoansButton
            // 
            viewLoansButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewLoansButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            viewLoansButton.Depth = 0;
            viewLoansButton.HighEmphasis = true;
            viewLoansButton.Icon = null;
            viewLoansButton.Location = new Point(5, 7);
            viewLoansButton.Margin = new Padding(4, 6, 4, 6);
            viewLoansButton.MouseState = MaterialSkin.MouseState.HOVER;
            viewLoansButton.Name = "viewLoansButton";
            viewLoansButton.NoAccentTextColor = Color.Empty;
            viewLoansButton.Size = new Size(96, 31);
            viewLoansButton.TabIndex = 2;
            viewLoansButton.Text = "Locações";
            viewLoansButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            viewLoansButton.UseAccentColor = false;
            viewLoansButton.UseVisualStyleBackColor = true;
            // 
            // bookTabPage
            // 
            bookTabPage.Controls.Add(tableLayoutPanel2);
            bookTabPage.Location = new Point(4, 30);
            bookTabPage.Margin = new Padding(3, 2, 3, 2);
            bookTabPage.Name = "bookTabPage";
            bookTabPage.Padding = new Padding(3, 2, 3, 2);
            bookTabPage.Size = new Size(679, 310);
            bookTabPage.TabIndex = 1;
            bookTabPage.Text = "Livros";
            bookTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(addBookButton, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 9F);
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6883116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.31169F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.Size = new Size(673, 306);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // addBookButton
            // 
            addBookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addBookButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBookButton.Depth = 0;
            addBookButton.HighEmphasis = true;
            addBookButton.Icon = null;
            addBookButton.Location = new Point(4, 4);
            addBookButton.Margin = new Padding(4);
            addBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            addBookButton.Name = "addBookButton";
            addBookButton.NoAccentTextColor = Color.Empty;
            addBookButton.Size = new Size(143, 27);
            addBookButton.TabIndex = 0;
            addBookButton.Text = "Adicionar livro";
            addBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBookButton.UseAccentColor = false;
            addBookButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(advancedDataGridView, 0, 1);
            tableLayoutPanel3.Controls.Add(searchToolBar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 37);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.4837904F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 93.51621F));
            tableLayoutPanel3.Size = new Size(667, 267);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // advancedDataGridView
            // 
            advancedDataGridView.AllowUserToAddRows = false;
            advancedDataGridView.AllowUserToDeleteRows = false;
            advancedDataGridView.AllowUserToResizeRows = false;
            advancedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            advancedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            advancedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, AuthorColumn, PublisherColumn, isbnColumn, totalColumn, quantity_availableColumn, editColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            advancedDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            advancedDataGridView.Dock = DockStyle.Fill;
            advancedDataGridView.FilterAndSortEnabled = true;
            advancedDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.Location = new Point(4, 21);
            advancedDataGridView.Margin = new Padding(3, 2, 3, 2);
            advancedDataGridView.MaxFilterButtonImageHeight = 23;
            advancedDataGridView.Name = "advancedDataGridView";
            advancedDataGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            advancedDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            advancedDataGridView.RowHeadersVisible = false;
            advancedDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            advancedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView.Size = new Size(659, 243);
            advancedDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.TabIndex = 3;
            // 
            // TitleColumn
            // 
            TitleColumn.HeaderText = "Titulo";
            TitleColumn.MinimumWidth = 24;
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            TitleColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // AuthorColumn
            // 
            AuthorColumn.HeaderText = "Autor";
            AuthorColumn.MinimumWidth = 24;
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.ReadOnly = true;
            AuthorColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // PublisherColumn
            // 
            PublisherColumn.HeaderText = "Editora";
            PublisherColumn.MinimumWidth = 24;
            PublisherColumn.Name = "PublisherColumn";
            PublisherColumn.ReadOnly = true;
            PublisherColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isbnColumn
            // 
            isbnColumn.HeaderText = "ISBN";
            isbnColumn.MinimumWidth = 24;
            isbnColumn.Name = "isbnColumn";
            isbnColumn.ReadOnly = true;
            isbnColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // totalColumn
            // 
            totalColumn.HeaderText = "Total";
            totalColumn.MinimumWidth = 24;
            totalColumn.Name = "totalColumn";
            totalColumn.ReadOnly = true;
            totalColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // quantity_availableColumn
            // 
            quantity_availableColumn.HeaderText = "Qtd Disponível";
            quantity_availableColumn.MinimumWidth = 24;
            quantity_availableColumn.Name = "quantity_availableColumn";
            quantity_availableColumn.ReadOnly = true;
            quantity_availableColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // editColumn
            // 
            editColumn.HeaderText = "Editar";
            editColumn.MinimumWidth = 24;
            editColumn.Name = "editColumn";
            editColumn.Resizable = DataGridViewTriState.True;
            editColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            editColumn.Text = "Editar";
            editColumn.UseColumnTextForButtonValue = true;
            // 
            // searchToolBar
            // 
            searchToolBar.AllowMerge = false;
            searchToolBar.Dock = DockStyle.Fill;
            searchToolBar.GripStyle = ToolStripGripStyle.Hidden;
            searchToolBar.ImageScalingSize = new Size(20, 20);
            searchToolBar.Location = new Point(1, 1);
            searchToolBar.MaximumSize = new Size(0, 20);
            searchToolBar.MinimumSize = new Size(0, 20);
            searchToolBar.Name = "searchToolBar";
            searchToolBar.RenderMode = ToolStripRenderMode.Professional;
            searchToolBar.Size = new Size(665, 20);
            searchToolBar.TabIndex = 0;
            searchToolBar.Text = "advancedDataGridViewSearchToolBar1";
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Nova seleção de item";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AllowMerge = false;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(885, 1);
            miniToolStrip.MaximumSize = new Size(0, 27);
            miniToolStrip.MinimumSize = new Size(0, 27);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.RenderMode = ToolStripRenderMode.Professional;
            miniToolStrip.Size = new Size(927, 27);
            miniToolStrip.TabIndex = 1;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 418);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LibraryForm";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            loanTabPage.ResumeLayout(false);
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            fieldsTwoTableLayoutPanel.ResumeLayout(false);
            fieldsTwoTableLayoutPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            bookTabPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TabControl tabControl;
        private TabPage loanTabPage;
        private TabPage bookTabPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar miniToolStrip;
        private MaterialSkin.Controls.MaterialButton addBookButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar searchToolBar;
        private ToolStrip toolStrip;
        private ToolStripButton exitButton;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn PublisherColumn;
        private DataGridViewTextBoxColumn isbnColumn;
        private DataGridViewTextBoxColumn totalColumn;
        private DataGridViewTextBoxColumn quantity_availableColumn;
        private DataGridViewButtonColumn editColumn;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel documentLabel;
        private MaterialSkin.Controls.MaterialTextBox documentTextBox;
        private TableLayoutPanel fieldsTwoTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel bookLabel;
        private MaterialSkin.Controls.MaterialComboBox bookComboBox;
        private FlowLayoutPanel flowLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel quantityLabel;
        private MaterialSkin.Controls.MaterialComboBox quantityComboBox;
        private FlowLayoutPanel flowLayoutPanel7;
        private MaterialSkin.Controls.MaterialLabel devolutionLabel;
        private DateTimePicker returnDateTimePicker;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel8;
        private MaterialSkin.Controls.MaterialButton loanBookButton;
        private FlowLayoutPanel flowLayoutPanel9;
        private MaterialSkin.Controls.MaterialButton confirmLoanButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton loanDetailsButton;
        private MaterialSkin.Controls.MaterialButton viewLoansButton;
    }
}