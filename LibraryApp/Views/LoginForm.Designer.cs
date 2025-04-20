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
            flowLayoutPanel1 = new FlowLayoutPanel();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            passwordLabel = new Label();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            usernameLabel = new Label();
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(loginButton);
            flowLayoutPanel1.Location = new Point(174, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(85, 48);
            flowLayoutPanel1.TabIndex = 1;
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
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoScroll = true;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.ColumnCount = 1;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel3, 0, 1);
            fieldsTableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 0);
            fieldsTableLayoutPanel.Location = new Point(3, 6);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 2;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fieldsTableLayoutPanel.Size = new Size(427, 180);
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
            flowLayoutPanel3.Size = new Size(421, 84);
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
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(3, 31);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordTextBox.Multiline = false;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Password = true;
            passwordTextBox.Size = new Size(418, 50);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "";
            passwordTextBox.TrailingIcon = null;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(usernameLabel);
            flowLayoutPanel2.Controls.Add(usernameTextBox);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(421, 84);
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
            usernameTextBox.Size = new Size(418, 50);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.BackColor = SystemColors.Control;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainTableLayoutPanel.Location = new Point(3, 64);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            mainTableLayoutPanel.Size = new Size(433, 256);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(439, 323);
            Controls.Add(mainTableLayoutPanel);
            Name = "LoginForm";
            ShowIcon = false;
            Text = "Login";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label passwordLabel;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private TableLayoutPanel mainTableLayoutPanel;
    }
}