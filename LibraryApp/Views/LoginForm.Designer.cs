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
            fieldsTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            passwordLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            usernameLabel = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            mainTableLayoutPanel = new TableLayoutPanel();
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            fieldsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.ColumnCount = 1;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel3, 0, 1);
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 0);
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
            fieldsTableLayoutPanel.Location = new Point(3, 3);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 3;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            fieldsTableLayoutPanel.Size = new Size(430, 242);
            fieldsTableLayoutPanel.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(passwordLabel);
            flowLayoutPanel3.Controls.Add(passwordTextBox);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 93);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(424, 84);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(3, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(65, 28);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Senha";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(usernameLabel);
            flowLayoutPanel2.Controls.Add(usernameTextBox);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(424, 84);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(3, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(79, 28);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Usuário";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.None;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(loginButton);
            flowLayoutPanel.Location = new Point(172, 187);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(85, 48);
            flowLayoutPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(4, 6);
            loginButton.Margin = new Padding(4, 6, 4, 6);
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
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.Anchor = AnchorStyles.None;
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.BackColor = SystemColors.Control;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainTableLayoutPanel.Location = new Point(3, 71);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 78.125F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.875F));
            mainTableLayoutPanel.Size = new Size(436, 256);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usernameTextBox.AnimateReadOnly = false;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Depth = 0;
            usernameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTextBox.LeadingIcon = null;
            usernameTextBox.Location = new Point(3, 31);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usernameTextBox.Multiline = false;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(408, 50);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(3, 31);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordTextBox.Multiline = false;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(408, 50);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "";
            passwordTextBox.TrailingIcon = null;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(439, 338);
            Controls.Add(mainTableLayoutPanel);
            Name = "LoginForm";
            ShowIcon = false;
            Text = "Login";
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel fieldsTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label passwordLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label usernameLabel;
        private TableLayoutPanel mainTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
    }
}