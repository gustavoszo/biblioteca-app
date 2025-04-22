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
            toolStripButton2 = new ToolStripButton();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel23 = new TableLayoutPanel();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel20 = new TableLayoutPanel();
            materialTextBox19 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel17 = new TableLayoutPanel();
            materialTextBox16 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel14 = new TableLayoutPanel();
            materialTextBox13 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel11 = new TableLayoutPanel();
            materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel8 = new TableLayoutPanel();
            materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mainTableLayoutPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            tableLayoutPanel23.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 93.96378F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.036217F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(512, 464);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addButton, toolStripButton2 });
            toolStrip1.Location = new Point(0, 435);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(512, 29);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.Alignment = ToolStripItemAlignment.Right;
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 26);
            addButton.Text = "Adicionar";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(80, 26);
            toolStripButton2.Text = "Cancelar";
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel23, 1, 6);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel20, 1, 5);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel17, 1, 4);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel14, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel11, 1, 2);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel8, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(4, 3);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 7;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            fieldsTableLayoutPanel.Size = new Size(504, 429);
            fieldsTableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 2;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel23.Controls.Add(materialTextBox22, 1, 0);
            tableLayoutPanel23.Controls.Add(materialLabel22, 0, 0);
            tableLayoutPanel23.Dock = DockStyle.Fill;
            tableLayoutPanel23.Location = new Point(28, 369);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 1;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel23.Size = new Size(447, 57);
            tableLayoutPanel23.TabIndex = 26;
            // 
            // materialTextBox22
            // 
            materialTextBox22.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BorderStyle = BorderStyle.None;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(92, 3);
            materialTextBox22.MaxLength = 50;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Multiline = false;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.Size = new Size(352, 50);
            materialTextBox22.TabIndex = 3;
            materialTextBox22.Text = "";
            materialTextBox22.TrailingIcon = null;
            // 
            // materialLabel22
            // 
            materialLabel22.Anchor = AnchorStyles.Right;
            materialLabel22.AutoSize = true;
            materialLabel22.Depth = 0;
            materialLabel22.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel22.Location = new Point(3, 19);
            materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel22.Name = "materialLabel22";
            materialLabel22.Size = new Size(83, 19);
            materialLabel22.TabIndex = 2;
            materialLabel22.Text = "Quantidade";
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 2;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel20.Controls.Add(materialTextBox19, 1, 0);
            tableLayoutPanel20.Controls.Add(materialLabel19, 0, 0);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(28, 308);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Size = new Size(447, 55);
            tableLayoutPanel20.TabIndex = 23;
            // 
            // materialTextBox19
            // 
            materialTextBox19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox19.AnimateReadOnly = false;
            materialTextBox19.BorderStyle = BorderStyle.None;
            materialTextBox19.Depth = 0;
            materialTextBox19.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox19.LeadingIcon = null;
            materialTextBox19.Location = new Point(92, 3);
            materialTextBox19.MaxLength = 50;
            materialTextBox19.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox19.Multiline = false;
            materialTextBox19.Name = "materialTextBox19";
            materialTextBox19.Size = new Size(352, 50);
            materialTextBox19.TabIndex = 3;
            materialTextBox19.Text = "";
            materialTextBox19.TrailingIcon = null;
            // 
            // materialLabel19
            // 
            materialLabel19.Anchor = AnchorStyles.Right;
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(35, 18);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(51, 19);
            materialLabel19.TabIndex = 2;
            materialLabel19.Text = "Genêro";
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel17.Controls.Add(materialTextBox16, 1, 0);
            tableLayoutPanel17.Controls.Add(materialLabel16, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(28, 247);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(447, 55);
            tableLayoutPanel17.TabIndex = 20;
            // 
            // materialTextBox16
            // 
            materialTextBox16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox16.AnimateReadOnly = false;
            materialTextBox16.BorderStyle = BorderStyle.None;
            materialTextBox16.Depth = 0;
            materialTextBox16.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox16.LeadingIcon = null;
            materialTextBox16.Location = new Point(92, 3);
            materialTextBox16.MaxLength = 50;
            materialTextBox16.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox16.Multiline = false;
            materialTextBox16.Name = "materialTextBox16";
            materialTextBox16.Size = new Size(352, 50);
            materialTextBox16.TabIndex = 3;
            materialTextBox16.Text = "";
            materialTextBox16.TrailingIcon = null;
            // 
            // materialLabel16
            // 
            materialLabel16.Anchor = AnchorStyles.Right;
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(50, 18);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(36, 19);
            materialLabel16.TabIndex = 2;
            materialLabel16.Text = "ISBN";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel14.Controls.Add(materialTextBox13, 1, 0);
            tableLayoutPanel14.Controls.Add(materialLabel13, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(28, 186);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(447, 55);
            tableLayoutPanel14.TabIndex = 17;
            // 
            // materialTextBox13
            // 
            materialTextBox13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox13.AnimateReadOnly = false;
            materialTextBox13.BorderStyle = BorderStyle.None;
            materialTextBox13.Depth = 0;
            materialTextBox13.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox13.LeadingIcon = null;
            materialTextBox13.Location = new Point(92, 3);
            materialTextBox13.MaxLength = 50;
            materialTextBox13.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox13.Multiline = false;
            materialTextBox13.Name = "materialTextBox13";
            materialTextBox13.Size = new Size(352, 50);
            materialTextBox13.TabIndex = 3;
            materialTextBox13.Text = "";
            materialTextBox13.TrailingIcon = null;
            // 
            // materialLabel13
            // 
            materialLabel13.Anchor = AnchorStyles.Right;
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(57, 18);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(29, 19);
            materialLabel13.TabIndex = 2;
            materialLabel13.Text = "Ano";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel11.Controls.Add(materialTextBox10, 1, 0);
            tableLayoutPanel11.Controls.Add(materialLabel10, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(28, 125);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(447, 55);
            tableLayoutPanel11.TabIndex = 14;
            // 
            // materialTextBox10
            // 
            materialTextBox10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox10.AnimateReadOnly = false;
            materialTextBox10.BorderStyle = BorderStyle.None;
            materialTextBox10.Depth = 0;
            materialTextBox10.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox10.LeadingIcon = null;
            materialTextBox10.Location = new Point(92, 3);
            materialTextBox10.MaxLength = 50;
            materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox10.Multiline = false;
            materialTextBox10.Name = "materialTextBox10";
            materialTextBox10.Size = new Size(352, 50);
            materialTextBox10.TabIndex = 3;
            materialTextBox10.Text = "";
            materialTextBox10.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            materialLabel10.Anchor = AnchorStyles.Right;
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(35, 18);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(51, 19);
            materialLabel10.TabIndex = 2;
            materialLabel10.Text = "Editora";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel8.Controls.Add(materialTextBox7, 1, 0);
            tableLayoutPanel8.Controls.Add(materialLabel7, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(28, 64);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(447, 55);
            tableLayoutPanel8.TabIndex = 11;
            // 
            // materialTextBox7
            // 
            materialTextBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox7.AnimateReadOnly = false;
            materialTextBox7.BorderStyle = BorderStyle.None;
            materialTextBox7.Depth = 0;
            materialTextBox7.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox7.LeadingIcon = null;
            materialTextBox7.Location = new Point(92, 3);
            materialTextBox7.MaxLength = 50;
            materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox7.Multiline = false;
            materialTextBox7.Name = "materialTextBox7";
            materialTextBox7.Size = new Size(352, 50);
            materialTextBox7.TabIndex = 3;
            materialTextBox7.Text = "";
            materialTextBox7.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.Anchor = AnchorStyles.Right;
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(47, 18);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(39, 19);
            materialLabel7.TabIndex = 2;
            materialLabel7.Text = "Autor";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(materialTextBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(materialLabel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(28, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(447, 55);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // materialTextBox1
            // 
            materialTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(92, 3);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(352, 50);
            materialTextBox1.TabIndex = 3;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(44, 18);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(42, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Titulo";
            // 
            // StoreBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 531);
            Controls.Add(mainTableLayoutPanel);
            MaximizeBox = false;
            Name = "StoreBookForm";
            ShowIcon = false;
            Sizable = false;
            Text = "Adicionar Livro";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel23.PerformLayout();
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton addButton;
        private ToolStripButton toolStripButton2;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel23;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox22;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private TableLayoutPanel tableLayoutPanel20;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox19;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private TableLayoutPanel tableLayoutPanel17;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox16;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private TableLayoutPanel tableLayoutPanel14;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox13;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private TableLayoutPanel tableLayoutPanel11;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}