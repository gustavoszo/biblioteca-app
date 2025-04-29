namespace LibraryApp.Views
{
    partial class LoansForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansForm));
            miniToolStrip = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            advancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            DocumentColumn = new DataGridViewTextBoxColumn();
            idLoanColumn = new DataGridViewTextBoxColumn();
            loanDateColumn = new DataGridViewTextBoxColumn();
            returnDateColumn = new DataGridViewTextBoxColumn();
            bookColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            returnColumn = new DataGridViewButtonColumn();
            searchToolBar = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            toolStrip1 = new ToolStrip();
            closeButton = new ToolStripButton();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            miniToolStrip.Location = new Point(573, 0);
            miniToolStrip.MaximumSize = new Size(0, 20);
            miniToolStrip.MinimumSize = new Size(0, 20);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.RenderMode = ToolStripRenderMode.Professional;
            miniToolStrip.Size = new Size(607, 20);
            miniToolStrip.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 9F);
            tableLayoutPanel2.Location = new Point(3, 64);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 92.59259F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.40740728F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.Size = new Size(833, 378);
            tableLayoutPanel2.TabIndex = 1;
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
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.4837904F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 93.51621F));
            tableLayoutPanel3.Size = new Size(827, 346);
            tableLayoutPanel3.TabIndex = 4;
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
            advancedDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, DocumentColumn, idLoanColumn, loanDateColumn, returnDateColumn, bookColumn, quantityColumn, returnColumn });
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
            advancedDataGridView.Location = new Point(4, 26);
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
            advancedDataGridView.Size = new Size(819, 317);
            advancedDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.TabIndex = 4;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Nome";
            NameColumn.MinimumWidth = 24;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DocumentColumn
            // 
            DocumentColumn.HeaderText = "Documento";
            DocumentColumn.MinimumWidth = 24;
            DocumentColumn.Name = "DocumentColumn";
            DocumentColumn.ReadOnly = true;
            DocumentColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // idLoanColumn
            // 
            idLoanColumn.HeaderText = "ID Empréstimo";
            idLoanColumn.MinimumWidth = 24;
            idLoanColumn.Name = "idLoanColumn";
            idLoanColumn.ReadOnly = true;
            idLoanColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // loanDateColumn
            // 
            loanDateColumn.HeaderText = "Emprestado em";
            loanDateColumn.MinimumWidth = 24;
            loanDateColumn.Name = "loanDateColumn";
            loanDateColumn.ReadOnly = true;
            loanDateColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // returnDateColumn
            // 
            returnDateColumn.HeaderText = "Data de devolução";
            returnDateColumn.MinimumWidth = 24;
            returnDateColumn.Name = "returnDateColumn";
            returnDateColumn.ReadOnly = true;
            returnDateColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // bookColumn
            // 
            bookColumn.HeaderText = "Livro";
            bookColumn.MinimumWidth = 24;
            bookColumn.Name = "bookColumn";
            bookColumn.ReadOnly = true;
            bookColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Quantidade";
            quantityColumn.MinimumWidth = 24;
            quantityColumn.Name = "quantityColumn";
            quantityColumn.ReadOnly = true;
            quantityColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // returnColumn
            // 
            returnColumn.HeaderText = "Devolver";
            returnColumn.MinimumWidth = 24;
            returnColumn.Name = "returnColumn";
            returnColumn.Resizable = DataGridViewTriState.True;
            returnColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            returnColumn.Text = "Devolver";
            returnColumn.UseColumnTextForButtonValue = true;
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
            searchToolBar.Size = new Size(825, 20);
            searchToolBar.TabIndex = 0;
            searchToolBar.Text = "advancedDataGridViewSearchToolBar1";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { closeButton });
            toolStrip1.Location = new Point(0, 353);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(833, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // closeButton
            // 
            closeButton.Alignment = ToolStripItemAlignment.Right;
            closeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.ImageTransparentColor = Color.Magenta;
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(46, 22);
            closeButton.Text = "Fechar";
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 445);
            Controls.Add(tableLayoutPanel2);
            Name = "LoansForm";
            Text = "Empréstimos em andamento";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar miniToolStrip;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar searchToolBar;
        private ToolStrip toolStrip1;
        private ToolStripButton closeButton;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn DocumentColumn;
        private DataGridViewTextBoxColumn idLoanColumn;
        private DataGridViewTextBoxColumn loanDateColumn;
        private DataGridViewTextBoxColumn returnDateColumn;
        private DataGridViewTextBoxColumn bookColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewButtonColumn returnColumn;
    }
}