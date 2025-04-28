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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            devolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            devolutionDateTimePicker = new DateTimePicker();
            confirmLoanButton = new MaterialSkin.Controls.MaterialButton();
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
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
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
            mainTableLayoutPanel.Size = new Size(693, 333);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { exitButton });
            toolStrip.Location = new Point(0, 315);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(693, 18);
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
            exitButton.Size = new Size(35, 15);
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
            tabControl.Size = new Size(687, 311);
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
            loanTabPage.Size = new Size(679, 277);
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
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 0);
            fieldsTableLayoutPanel.Controls.Add(fieldsTwoTableLayoutPanel, 1, 0);
            fieldsTableLayoutPanel.Dock = DockStyle.Fill;
            fieldsTableLayoutPanel.Location = new Point(3, 2);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 1;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            fieldsTableLayoutPanel.Size = new Size(673, 273);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 265);
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
            fieldsTwoTableLayoutPanel.Location = new Point(239, 4);
            fieldsTwoTableLayoutPanel.Name = "fieldsTwoTableLayoutPanel";
            fieldsTwoTableLayoutPanel.RowCount = 2;
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTwoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            fieldsTwoTableLayoutPanel.Size = new Size(430, 265);
            fieldsTwoTableLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(5, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(420, 123);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel7, 0, 0);
            tableLayoutPanel1.Controls.Add(confirmLoanButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(420, 124);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.BackColor = SystemColors.Control;
            flowLayoutPanel7.Controls.Add(devolutionLabel);
            flowLayoutPanel7.Controls.Add(devolutionDateTimePicker);
            flowLayoutPanel7.Location = new Point(3, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(334, 54);
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
            // devolutionDateTimePicker
            // 
            devolutionDateTimePicker.Location = new Point(3, 22);
            devolutionDateTimePicker.MaxDate = new DateTime(2040, 12, 25, 23, 59, 59, 0);
            devolutionDateTimePicker.MinDate = new DateTime(2025, 4, 25, 0, 0, 0, 0);
            devolutionDateTimePicker.Name = "devolutionDateTimePicker";
            devolutionDateTimePicker.Size = new Size(328, 29);
            devolutionDateTimePicker.TabIndex = 3;
            devolutionDateTimePicker.Value = new DateTime(2025, 4, 25, 0, 0, 0, 0);
            // 
            // confirmLoanButton
            // 
            confirmLoanButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            confirmLoanButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmLoanButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            confirmLoanButton.Depth = 0;
            confirmLoanButton.HighEmphasis = true;
            confirmLoanButton.Icon = null;
            confirmLoanButton.Location = new Point(4, 82);
            confirmLoanButton.Margin = new Padding(4, 6, 4, 6);
            confirmLoanButton.MouseState = MaterialSkin.MouseState.HOVER;
            confirmLoanButton.Name = "confirmLoanButton";
            confirmLoanButton.NoAccentTextColor = Color.Empty;
            confirmLoanButton.Size = new Size(159, 36);
            confirmLoanButton.TabIndex = 7;
            confirmLoanButton.Text = "Realizar locação";
            confirmLoanButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            confirmLoanButton.UseAccentColor = false;
            confirmLoanButton.UseVisualStyleBackColor = true;
            // 
            // bookTabPage
            // 
            bookTabPage.Controls.Add(tableLayoutPanel2);
            bookTabPage.Location = new Point(4, 30);
            bookTabPage.Margin = new Padding(3, 2, 3, 2);
            bookTabPage.Name = "bookTabPage";
            bookTabPage.Padding = new Padding(3, 2, 3, 2);
            bookTabPage.Size = new Size(679, 277);
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
            tableLayoutPanel2.Size = new Size(673, 273);
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
            addBookButton.Size = new Size(143, 23);
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
            tableLayoutPanel3.Location = new Point(3, 33);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.4837904F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 93.51621F));
            tableLayoutPanel3.Size = new Size(667, 238);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // advancedDataGridView
            // 
            advancedDataGridView.AllowUserToAddRows = false;
            advancedDataGridView.AllowUserToDeleteRows = false;
            advancedDataGridView.AllowUserToResizeRows = false;
            advancedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            advancedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            advancedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, AuthorColumn, PublisherColumn, isbnColumn, totalColumn, quantity_availableColumn, editColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            advancedDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            advancedDataGridView.Dock = DockStyle.Fill;
            advancedDataGridView.FilterAndSortEnabled = true;
            advancedDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.Location = new Point(4, 19);
            advancedDataGridView.Margin = new Padding(3, 2, 3, 2);
            advancedDataGridView.MaxFilterButtonImageHeight = 23;
            advancedDataGridView.Name = "advancedDataGridView";
            advancedDataGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            advancedDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            advancedDataGridView.RowHeadersVisible = false;
            advancedDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            advancedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView.Size = new Size(659, 216);
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
            ClientSize = new Size(699, 383);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            fieldsTwoTableLayoutPanel.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
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
        private DateTimePicker devolutionDateTimePicker;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton confirmLoanButton;
    }
}