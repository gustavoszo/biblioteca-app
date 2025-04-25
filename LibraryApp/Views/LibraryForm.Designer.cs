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
            toolStrip1 = new ToolStrip();
            exitButton = new ToolStripButton();
            tabControl = new TabControl();
            leaseTabPage = new TabPage();
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
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
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
            mainTableLayoutPanel.Controls.Add(toolStrip1, 0, 1);
            mainTableLayoutPanel.Controls.Add(tabControl, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 64);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 94.6850357F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.31496048F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(955, 508);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { exitButton });
            toolStrip1.Location = new Point(0, 481);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(955, 27);
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
            exitButton.Size = new Size(42, 24);
            exitButton.Text = "Sair";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(leaseTabPage);
            tabControl.Controls.Add(bookTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(3, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(949, 475);
            tabControl.TabIndex = 1;
            // 
            // leaseTabPage
            // 
            leaseTabPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaseTabPage.Location = new Point(4, 37);
            leaseTabPage.Name = "leaseTabPage";
            leaseTabPage.Padding = new Padding(3);
            leaseTabPage.Size = new Size(941, 434);
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
            bookTabPage.Size = new Size(941, 434);
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
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6883116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.31169F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(935, 428);
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
            addBookButton.Location = new Point(4, 8);
            addBookButton.Margin = new Padding(4, 6, 4, 6);
            addBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            addBookButton.Name = "addBookButton";
            addBookButton.NoAccentTextColor = Color.Empty;
            addBookButton.Size = new Size(143, 36);
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
            tableLayoutPanel3.Location = new Point(3, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.4837904F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 93.51621F));
            tableLayoutPanel3.Size = new Size(929, 372);
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
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            advancedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView.Size = new Size(921, 340);
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
            searchToolBar.MaximumSize = new Size(0, 27);
            searchToolBar.MinimumSize = new Size(0, 27);
            searchToolBar.Name = "searchToolBar";
            searchToolBar.RenderMode = ToolStripRenderMode.Professional;
            searchToolBar.Size = new Size(927, 27);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 575);
            Controls.Add(mainTableLayoutPanel);
            Name = "LibraryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
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

        private TableLayoutPanel mainTableLayoutPanel;
        private TabControl tabControl;
        private TabPage leaseTabPage;
        private TabPage bookTabPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar miniToolStrip;
        private MaterialSkin.Controls.MaterialButton addBookButton;
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
        private DataGridViewButtonColumn editColumn;
    }
}