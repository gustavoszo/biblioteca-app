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
            fieldsTableLayoutPanel = new TableLayoutPanel();
            passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            confirmPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            buttonFlowLayoutPanel = new FlowLayoutPanel();
            registerButton = new MaterialSkin.Controls.MaterialButton();
            usernameFlowLayoutPanel = new FlowLayoutPanel();
            usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            confirmPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            fieldsTableLayoutPanel.SuspendLayout();
            buttonFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // fieldsTableLayoutPanel
            // 
            fieldsTableLayoutPanel.AutoSize = true;
            fieldsTableLayoutPanel.BackColor = SystemColors.Control;
            fieldsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            fieldsTableLayoutPanel.ColumnCount = 3;
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.73684F));
            fieldsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            fieldsTableLayoutPanel.Controls.Add(passwordTextBox, 1, 1);
            fieldsTableLayoutPanel.Controls.Add(confirmPasswordLabel, 0, 2);
            fieldsTableLayoutPanel.Controls.Add(usernameLabel, 0, 0);
            fieldsTableLayoutPanel.Controls.Add(passwordLabel, 0, 1);
            fieldsTableLayoutPanel.Controls.Add(buttonFlowLayoutPanel, 1, 3);
            fieldsTableLayoutPanel.Controls.Add(usernameFlowLayoutPanel, 2, 0);
            fieldsTableLayoutPanel.Controls.Add(usernameTextBox, 1, 0);
            fieldsTableLayoutPanel.Controls.Add(confirmPasswordTextBox, 1, 2);
            fieldsTableLayoutPanel.Dock = DockStyle.Fill;
            fieldsTableLayoutPanel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fieldsTableLayoutPanel.Location = new Point(3, 85);
            fieldsTableLayoutPanel.Name = "fieldsTableLayoutPanel";
            fieldsTableLayoutPanel.RowCount = 5;
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle());
            fieldsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            fieldsTableLayoutPanel.Size = new Size(548, 418);
            fieldsTableLayoutPanel.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.AnimateReadOnly = false;
            passwordTextBox.BackgroundImageLayout = ImageLayout.None;
            passwordTextBox.CharacterCasing = CharacterCasing.Normal;
            passwordTextBox.Depth = 0;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordTextBox.HideSelection = true;
            passwordTextBox.LeadingIcon = null;
            passwordTextBox.Location = new Point(130, 64);
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
            passwordTextBox.Size = new Size(390, 48);
            passwordTextBox.TabIndex = 22;
            passwordTextBox.TabStop = false;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            passwordTextBox.TrailingIcon = null;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Depth = 0;
            confirmPasswordLabel.Dock = DockStyle.Fill;
            confirmPasswordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            confirmPasswordLabel.Location = new Point(4, 117);
            confirmPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(119, 56);
            confirmPasswordLabel.TabIndex = 0;
            confirmPasswordLabel.Text = "Confirmar senha";
            confirmPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Depth = 0;
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameLabel.Location = new Point(4, 1);
            usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(119, 58);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Usuário";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Depth = 0;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordLabel.Location = new Point(4, 60);
            passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(119, 56);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Senha";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonFlowLayoutPanel
            // 
            buttonFlowLayoutPanel.Anchor = AnchorStyles.Top;
            buttonFlowLayoutPanel.AutoSize = true;
            buttonFlowLayoutPanel.Controls.Add(registerButton);
            buttonFlowLayoutPanel.Location = new Point(267, 178);
            buttonFlowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            buttonFlowLayoutPanel.Size = new Size(116, 52);
            buttonFlowLayoutPanel.TabIndex = 15;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Top;
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            registerButton.Depth = 0;
            registerButton.Enabled = false;
            registerButton.HighEmphasis = true;
            registerButton.Icon = null;
            registerButton.Location = new Point(5, 8);
            registerButton.Margin = new Padding(5, 8, 5, 8);
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
            // usernameFlowLayoutPanel
            // 
            usernameFlowLayoutPanel.AutoSize = true;
            usernameFlowLayoutPanel.Location = new Point(527, 5);
            usernameFlowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            usernameFlowLayoutPanel.Name = "usernameFlowLayoutPanel";
            usernameFlowLayoutPanel.Size = new Size(0, 0);
            usernameFlowLayoutPanel.TabIndex = 19;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.AnimateReadOnly = false;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Depth = 0;
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameTextBox.LeadingIcon = null;
            usernameTextBox.Location = new Point(130, 5);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            usernameTextBox.Multiline = false;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(390, 50);
            usernameTextBox.TabIndex = 20;
            usernameTextBox.Text = "";
            usernameTextBox.TrailingIcon = null;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Anchor = AnchorStyles.None;
            confirmPasswordTextBox.AnimateReadOnly = false;
            confirmPasswordTextBox.BackgroundImageLayout = ImageLayout.None;
            confirmPasswordTextBox.CharacterCasing = CharacterCasing.Normal;
            confirmPasswordTextBox.Depth = 0;
            confirmPasswordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            confirmPasswordTextBox.HideSelection = true;
            confirmPasswordTextBox.LeadingIcon = null;
            confirmPasswordTextBox.Location = new Point(130, 121);
            confirmPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
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
            confirmPasswordTextBox.Size = new Size(390, 48);
            confirmPasswordTextBox.TabIndex = 21;
            confirmPasswordTextBox.TabStop = false;
            confirmPasswordTextBox.TextAlign = HorizontalAlignment.Left;
            confirmPasswordTextBox.TrailingIcon = null;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 507);
            Controls.Add(fieldsTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CredentialsForm";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registre sua credencial";
            fieldsTableLayoutPanel.ResumeLayout(false);
            fieldsTableLayoutPanel.PerformLayout();
            buttonFlowLayoutPanel.ResumeLayout(false);
            buttonFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel fieldsTableLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialLabel confirmPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private FlowLayoutPanel buttonFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private FlowLayoutPanel usernameFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 confirmPasswordTextBox;
    }
}