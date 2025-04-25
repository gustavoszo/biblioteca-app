namespace LibraryApp.Views
{
    partial class CredentialsForm
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
            mainTableLayoutPanel = new TableLayoutPanel();
            fieldsTableLayoutPanel = new TableLayoutPanel();
            buttonFlowLayoutPanel = new FlowLayoutPanel();
            registerButton = new MaterialSkin.Controls.MaterialButton();
            passwordFlowLayoutPanel = new FlowLayoutPanel();
            passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            confirmPasswordflowLayoutPanel = new FlowLayoutPanel();
            confirmPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            confirmPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            usernameFlowLayoutPanel = new FlowLayoutPanel();
            usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            mainTableLayoutPanel.SuspendLayout();
            fieldsTableLayoutPanel.SuspendLayout();
            buttonFlowLayoutPanel.SuspendLayout();
            passwordFlowLayoutPanel.SuspendLayout();
            confirmPasswordflowLayoutPanel.SuspendLayout();
            usernameFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Controls.Add(fieldsTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(3, 64);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Size = new Size(361, 313);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.Anchor = AnchorStyles.None;
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.BackColor = SystemColors.Control;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            fieldsTableLayoutPanel.Controls.Add(buttonFlowLayoutPanel, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(passwordFlowLayoutPanel, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(confirmPasswordflowLayoutPanel, 1, 2);
            fieldsTableLayoutPanel.Controls.Add(usernameFlowLayoutPanel, 1, 0);
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(28, 6);
            fieldsTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 4;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            fieldsTableLayoutPanel.Size = new Size(304, 300);
            fieldsTableLayoutPanel.TabIndex = 7;
            // 
            // buttonFlowLayoutPanel
            // 
            buttonFlowLayoutPanel.Anchor = AnchorStyles.None;
            buttonFlowLayoutPanel.AutoSize = true;
            buttonFlowLayoutPanel.Controls.Add(registerButton);
            buttonFlowLayoutPanel.Location = new Point(94, 247);
            buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            buttonFlowLayoutPanel.Size = new Size(114, 48);
            buttonFlowLayoutPanel.TabIndex = 15;
            // 
            // registerButton
            // 
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            registerButton.Depth = 0;
            registerButton.Enabled = false;
            registerButton.HighEmphasis = true;
            registerButton.Icon = null;
            registerButton.Location = new Point(4, 6);
            registerButton.Margin = new Padding(4, 6, 4, 6);
            registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            registerButton.Name = "registerButton";
            registerButton.NoAccentTextColor = Color.Empty;
            registerButton.Size = new Size(106, 36);
            registerButton.TabIndex = 0;
            registerButton.Text = "Cadastrar";
            registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            registerButton.UseAccentColor = false;
            registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordFlowLayoutPanel
            // 
            passwordFlowLayoutPanel.AutoSize = true;
            passwordFlowLayoutPanel.Controls.Add(passwordLabel);
            passwordFlowLayoutPanel.Controls.Add(passwordTextBox);
            passwordFlowLayoutPanel.Dock = DockStyle.Fill;
            passwordFlowLayoutPanel.Location = new Point(18, 84);
            passwordFlowLayoutPanel.Name = "passwordFlowLayoutPanel";
            passwordFlowLayoutPanel.Size = new Size(267, 75);
            passwordFlowLayoutPanel.TabIndex = 17;
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
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Senha";
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
            passwordTextBox.Location = new Point(3, 22);
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
            passwordTextBox.Size = new Size(259, 48);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TabStop = false;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordflowLayoutPanel
            // 
            confirmPasswordflowLayoutPanel.AutoSize = true;
            confirmPasswordflowLayoutPanel.Controls.Add(confirmPasswordLabel);
            confirmPasswordflowLayoutPanel.Controls.Add(confirmPasswordTextBox);
            confirmPasswordflowLayoutPanel.Dock = DockStyle.Fill;
            confirmPasswordflowLayoutPanel.Location = new Point(18, 165);
            confirmPasswordflowLayoutPanel.Name = "confirmPasswordflowLayoutPanel";
            confirmPasswordflowLayoutPanel.Size = new Size(267, 75);
            confirmPasswordflowLayoutPanel.TabIndex = 18;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Depth = 0;
            confirmPasswordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            confirmPasswordLabel.Location = new Point(3, 0);
            confirmPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(119, 19);
            confirmPasswordLabel.TabIndex = 0;
            confirmPasswordLabel.Text = "Confirmar senha";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.AnimateReadOnly = false;
            confirmPasswordTextBox.BackgroundImageLayout = ImageLayout.None;
            confirmPasswordTextBox.CharacterCasing = CharacterCasing.Normal;
            confirmPasswordTextBox.Depth = 0;
            confirmPasswordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            confirmPasswordTextBox.HideSelection = true;
            confirmPasswordTextBox.LeadingIcon = null;
            confirmPasswordTextBox.Location = new Point(3, 22);
            confirmPasswordTextBox.MaxLength = 32767;
            confirmPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '●';
            confirmPasswordTextBox.PrefixSuffixText = null;
            confirmPasswordTextBox.ReadOnly = false;
            confirmPasswordTextBox.RightToLeft = RightToLeft.No;
            confirmPasswordTextBox.SelectedText = "";
            confirmPasswordTextBox.SelectionLength = 0;
            confirmPasswordTextBox.SelectionStart = 0;
            confirmPasswordTextBox.ShortcutsEnabled = true;
            confirmPasswordTextBox.Size = new Size(262, 48);
            confirmPasswordTextBox.TabIndex = 1;
            confirmPasswordTextBox.TabStop = false;
            confirmPasswordTextBox.TextAlign = HorizontalAlignment.Left;
            confirmPasswordTextBox.TrailingIcon = null;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameFlowLayoutPanel
            // 
            usernameFlowLayoutPanel.AutoSize = true;
            usernameFlowLayoutPanel.Controls.Add(usernameLabel);
            usernameFlowLayoutPanel.Controls.Add(usernameTextBox);
            usernameFlowLayoutPanel.Location = new Point(18, 3);
            usernameFlowLayoutPanel.Name = "usernameFlowLayoutPanel";
            usernameFlowLayoutPanel.Size = new Size(265, 75);
            usernameFlowLayoutPanel.TabIndex = 19;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Depth = 0;
            usernameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameLabel.Location = new Point(3, 0);
            usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(55, 19);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Usuário";
            // 
            // usernameTextBox
            // 
            usernameTextBox.AnimateReadOnly = false;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Depth = 0;
            usernameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTextBox.LeadingIcon = null;
            usernameTextBox.Location = new Point(3, 22);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usernameTextBox.Multiline = false;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(259, 50);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 380);
            Controls.Add(mainTableLayoutPanel);
            Name = "CredentialsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registre sua credencial";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            buttonFlowLayoutPanel.ResumeLayout(false);
            buttonFlowLayoutPanel.PerformLayout();
            passwordFlowLayoutPanel.ResumeLayout(false);
            passwordFlowLayoutPanel.PerformLayout();
            confirmPasswordflowLayoutPanel.ResumeLayout(false);
            confirmPasswordflowLayoutPanel.PerformLayout();
            usernameFlowLayoutPanel.ResumeLayout(false);
            usernameFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel fieldsTableLayoutPanel;
        private FlowLayoutPanel buttonFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private FlowLayoutPanel confirmPasswordflowLayoutPanel;
        private FlowLayoutPanel passwordFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialLabel confirmPasswordLabel;
        private MaterialSkin.Controls.MaterialTextBox2 confirmPasswordTextBox;
        private FlowLayoutPanel usernameFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
    }
}