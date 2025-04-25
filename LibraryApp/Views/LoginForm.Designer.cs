namespace LibraryApp.Forms
{
    partial class LoginForm
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
            tableLayoutPanel = new TableLayoutPanel();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            flowLayoutPanel = new FlowLayoutPanel();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel.Location = new Point(3, 85);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(444, 281);
            tableLayoutPanel.TabIndex = 0;
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.ColumnCount = 1;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel3, 0, 1);
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 0);
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(12, 25);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 3;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            fieldsTableLayoutPanel.Size = new Size(420, 231);
            fieldsTableLayoutPanel.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(passwordLabel);
            flowLayoutPanel3.Controls.Add(passwordTextBox);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 88);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(414, 79);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BackgroundImageLayout = ImageLayout.None;
            passwordTextBox.CharacterCasing = CharacterCasing.Normal;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.HideSelection = true;
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(3, 23);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.MaxLength = 32767;
            passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.PrefixSuffixText = null;
            passwordTextBox.ReadOnly = false;
            passwordTextBox.RightToLeft = RightToLeft.No;
            passwordTextBox.SelectedText = "";
            passwordTextBox.SelectionLength = 0;
            passwordTextBox.SelectionStart = 0;
            passwordTextBox.ShortcutsEnabled = true;
            passwordTextBox.Size = new Size(408, 48);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TabStop = false;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.None;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(loginButton);
            flowLayoutPanel.Location = new Point(166, 177);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(87, 46);
            flowLayoutPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(5, 5);
            loginButton.Margin = new Padding(5);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(77, 36);
            loginButton.TabIndex = 0;
            loginButton.Text = "Entrar";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(usernameLabel);
            flowLayoutPanel1.Controls.Add(usernameTextBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(414, 77);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.AnimateReadOnly = false;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Depth = 0;
            usernameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTextBox.LeadingIcon = null;
            usernameTextBox.Location = new Point(3, 23);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usernameTextBox.Multiline = false;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(408, 50);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Depth = 0;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(3, 0);
            usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(55, 19);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Usuário";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Depth = 0;
            passwordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordLabel.Location = new Point(3, 0);
            passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(46, 19);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Senha";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(450, 369);
            Controls.Add(tableLayoutPanel);
            Name = "LoginForm";
            Padding = new Padding(3, 85, 3, 3);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private FlowLayoutPanel flowLayoutPanel;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
    }
}