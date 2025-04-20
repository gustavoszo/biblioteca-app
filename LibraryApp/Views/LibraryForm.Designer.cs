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
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            exitButton = new ToolStripButton();
            tabControl = new TabControl();
            leaseTabPage = new TabPage();
            bookTabPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            advancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            searchToolBar = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            miniToolStrip = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            TitleColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            PublisherColumn = new DataGridViewTextBoxColumn();
            isbnColumn = new DataGridViewTextBoxColumn();
            totalColumn = new DataGridViewTextBoxColumn();
            quantity_availableColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            bookTabPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.05269F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.94731F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.36364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.63636351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(955, 508);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { exitButton });
            toolStrip1.Location = new Point(1, 478);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(953, 29);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // exitButton
            // 
            exitButton.Alignment = ToolStripItemAlignment.Right;
            exitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            exitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.ImageTransparentColor = Color.Magenta;
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(42, 26);
            exitButton.Text = "Sair";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(leaseTabPage);
            tabControl.Controls.Add(bookTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(4, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(947, 470);
            tabControl.TabIndex = 1;
            // 
            // leaseTabPage
            // 
            leaseTabPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaseTabPage.Location = new Point(4, 37);
            leaseTabPage.Name = "leaseTabPage";
            leaseTabPage.Padding = new Padding(3);
            leaseTabPage.Size = new Size(780, 469);
            leaseTabPage.TabIndex = 0;
            leaseTabPage.Text = "Locação";
            leaseTabPage.UseVisualStyleBackColor = true;
            // 
            // bookTabPage
            // 
            bookTabPage.Controls.Add(tableLayoutPanel2);
            bookTabPage.Location = new Point(4, 37);
            bookTabPage.Name = "bookTabPage";
            bookTabPage.Padding = new Padding(3);
            bookTabPage.Size = new Size(939, 429);
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
            tableLayoutPanel2.Controls.Add(materialButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 9F);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6883116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.31169F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(933, 423);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(4, 7);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(143, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Adicionar livro";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
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
            tableLayoutPanel3.Location = new Point(3, 52);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.4837904F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 93.51621F));
            tableLayoutPanel3.Size = new Size(927, 368);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // advancedDataGridView
            // 
            advancedDataGridView.AllowUserToAddRows = false;
            advancedDataGridView.AllowUserToDeleteRows = false;
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
            advancedDataGridView.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, AuthorColumn, PublisherColumn, isbnColumn, totalColumn, quantity_availableColumn });
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
            advancedDataGridView.Location = new Point(4, 28);
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
            advancedDataGridView.Size = new Size(919, 336);
            advancedDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.TabIndex = 3;
            // 
            // searchToolBar
            // 
            searchToolBar.AllowMerge = false;
            searchToolBar.Dock = DockStyle.Fill;
            searchToolBar.GripStyle = ToolStripGripStyle.Hidden;
            searchToolBar.ImageScalingSize = new Size(20, 20);
            searchToolBar.Location = new Point(1, 1);
            searchToolBar.MaximumSize = new Size(0, 27);
            searchToolBar.MinimumSize = new Size(0, 27);
            searchToolBar.Name = "searchToolBar";
            searchToolBar.RenderMode = ToolStripRenderMode.Professional;
            searchToolBar.Size = new Size(925, 27);
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
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 575);
            Controls.Add(tableLayoutPanel1);
            Name = "LibraryForm";
            Text = "Biblioteca";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            bookTabPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl;
        private TabPage leaseTabPage;
        private TabPage bookTabPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar miniToolStrip;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TableLayoutPanel tableLayoutPanel3;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar searchToolBar;
        private ToolStrip toolStrip1;
        private ToolStripButton exitButton;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn PublisherColumn;
        private DataGridViewTextBoxColumn isbnColumn;
        private DataGridViewTextBoxColumn totalColumn;
        private DataGridViewTextBoxColumn quantity_availableColumn;
    }
}