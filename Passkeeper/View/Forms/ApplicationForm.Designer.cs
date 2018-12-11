namespace Passkeeper.View.Forms
{
	partial class ApplicationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
			this.AddResourceButton = new System.Windows.Forms.Button();
			this.RemoveResourceButton = new System.Windows.Forms.Button();
			this.ClearHistoryButton = new System.Windows.Forms.Button();
			this.ResourceList = new System.Windows.Forms.ListBox();
			this.ResourceAccountsComboBox = new System.Windows.Forms.ComboBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.EditAccountButton = new System.Windows.Forms.Button();
			this.ShowHistoryButton = new System.Windows.Forms.Button();
			this.AddAccountButton = new System.Windows.Forms.Button();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.RemoveAccountButton = new System.Windows.Forms.Button();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddResourceButton
			// 
			this.AddResourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddResourceButton.BackColor = System.Drawing.Color.Teal;
			this.AddResourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.AddResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddResourceButton.Location = new System.Drawing.Point(16, 14);
			this.AddResourceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddResourceButton.Name = "AddResourceButton";
			this.AddResourceButton.Size = new System.Drawing.Size(225, 35);
			this.AddResourceButton.TabIndex = 1;
			this.AddResourceButton.Text = "Add Resource";
			this.AddResourceButton.UseVisualStyleBackColor = false;
			this.AddResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
			// 
			// RemoveResourceButton
			// 
			this.RemoveResourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveResourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.RemoveResourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.RemoveResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveResourceButton.Location = new System.Drawing.Point(250, 14);
			this.RemoveResourceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RemoveResourceButton.Name = "RemoveResourceButton";
			this.RemoveResourceButton.Size = new System.Drawing.Size(225, 35);
			this.RemoveResourceButton.TabIndex = 2;
			this.RemoveResourceButton.Text = "Remove Resource";
			this.RemoveResourceButton.UseVisualStyleBackColor = false;
			this.RemoveResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
			// 
			// ClearHistoryButton
			// 
			this.ClearHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ClearHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ClearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearHistoryButton.Location = new System.Drawing.Point(752, 263);
			this.ClearHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ClearHistoryButton.Name = "ClearHistoryButton";
			this.ClearHistoryButton.Size = new System.Drawing.Size(259, 35);
			this.ClearHistoryButton.TabIndex = 10;
			this.ClearHistoryButton.Text = "Clear History";
			this.ClearHistoryButton.UseVisualStyleBackColor = false;
			this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
			// 
			// ResourceList
			// 
			this.ResourceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResourceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ResourceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ResourceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ResourceList.FormattingEnabled = true;
			this.ResourceList.ItemHeight = 20;
			this.ResourceList.Location = new System.Drawing.Point(18, 58);
			this.ResourceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResourceList.Name = "ResourceList";
			this.ResourceList.Size = new System.Drawing.Size(456, 500);
			this.ResourceList.Sorted = true;
			this.ResourceList.TabIndex = 0;
			this.ResourceList.SelectedIndexChanged += new System.EventHandler(this.ResourceList_SelectedIndexChanged);
			// 
			// ResourceAccountsComboBox
			// 
			this.ResourceAccountsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ResourceAccountsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResourceAccountsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ResourceAccountsComboBox.FormattingEnabled = true;
			this.ResourceAccountsComboBox.Location = new System.Drawing.Point(484, 17);
			this.ResourceAccountsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResourceAccountsComboBox.Name = "ResourceAccountsComboBox";
			this.ResourceAccountsComboBox.Size = new System.Drawing.Size(336, 28);
			this.ResourceAccountsComboBox.TabIndex = 11;
			this.ResourceAccountsComboBox.SelectedIndexChanged += new System.EventHandler(this.ResourceAccountsComboBox_SelectedIndexChanged);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(480, 69);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(50, 20);
			this.EmailLabel.TabIndex = 5;
			this.EmailLabel.Text = "Email:";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(480, 111);
			this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(52, 20);
			this.LoginLabel.TabIndex = 6;
			this.LoginLabel.Text = "Login:";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(480, 152);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(83, 20);
			this.PasswordLabel.TabIndex = 7;
			this.PasswordLabel.Text = "Password:";
			// 
			// EditAccountButton
			// 
			this.EditAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.EditAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.EditAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditAccountButton.Location = new System.Drawing.Point(482, 218);
			this.EditAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EditAccountButton.Name = "EditAccountButton";
			this.EditAccountButton.Size = new System.Drawing.Size(260, 35);
			this.EditAccountButton.TabIndex = 7;
			this.EditAccountButton.Text = "Edit Account";
			this.EditAccountButton.UseVisualStyleBackColor = false;
			this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
			// 
			// ShowHistoryButton
			// 
			this.ShowHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ShowHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ShowHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowHistoryButton.Location = new System.Drawing.Point(752, 218);
			this.ShowHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ShowHistoryButton.Name = "ShowHistoryButton";
			this.ShowHistoryButton.Size = new System.Drawing.Size(259, 35);
			this.ShowHistoryButton.TabIndex = 9;
			this.ShowHistoryButton.Text = "Show History";
			this.ShowHistoryButton.UseVisualStyleBackColor = false;
			this.ShowHistoryButton.Click += new System.EventHandler(this.ShowHistoryButton_Click);
			// 
			// AddAccountButton
			// 
			this.AddAccountButton.BackColor = System.Drawing.Color.Teal;
			this.AddAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddAccountButton.Location = new System.Drawing.Point(831, 14);
			this.AddAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddAccountButton.Name = "AddAccountButton";
			this.AddAccountButton.Size = new System.Drawing.Size(180, 35);
			this.AddAccountButton.TabIndex = 3;
			this.AddAccountButton.Text = "Add Account";
			this.AddAccountButton.UseVisualStyleBackColor = false;
			this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.EmailTextBox.Location = new System.Drawing.Point(603, 65);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.ReadOnly = true;
			this.EmailTextBox.Size = new System.Drawing.Size(408, 26);
			this.EmailTextBox.TabIndex = 4;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.LoginTextBox.Location = new System.Drawing.Point(603, 106);
			this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.ReadOnly = true;
			this.LoginTextBox.Size = new System.Drawing.Size(408, 26);
			this.LoginTextBox.TabIndex = 5;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.PasswordTextBox.Location = new System.Drawing.Point(603, 148);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.ReadOnly = true;
			this.PasswordTextBox.Size = new System.Drawing.Size(408, 26);
			this.PasswordTextBox.TabIndex = 6;
			// 
			// RemoveAccountButton
			// 
			this.RemoveAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.RemoveAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.RemoveAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveAccountButton.Location = new System.Drawing.Point(482, 263);
			this.RemoveAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RemoveAccountButton.Name = "RemoveAccountButton";
			this.RemoveAccountButton.Size = new System.Drawing.Size(260, 35);
			this.RemoveAccountButton.TabIndex = 8;
			this.RemoveAccountButton.Text = "Remove Account";
			this.RemoveAccountButton.UseVisualStyleBackColor = false;
			this.RemoveAccountButton.Click += new System.EventHandler(this.RemoveAccountButton_Click);
			// 
			// SettingsButton
			// 
			this.SettingsButton.BackColor = System.Drawing.Color.Teal;
			this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SettingsButton.Location = new System.Drawing.Point(484, 522);
			this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(527, 35);
			this.SettingsButton.TabIndex = 12;
			this.SettingsButton.Text = "Settings";
			this.SettingsButton.UseVisualStyleBackColor = false;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// ApplicationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(1023, 571);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.RemoveAccountButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.AddAccountButton);
			this.Controls.Add(this.ShowHistoryButton);
			this.Controls.Add(this.EditAccountButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.ResourceAccountsComboBox);
			this.Controls.Add(this.ResourceList);
			this.Controls.Add(this.ClearHistoryButton);
			this.Controls.Add(this.RemoveResourceButton);
			this.Controls.Add(this.AddResourceButton);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ApplicationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Passkeeper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddResourceButton;
		private System.Windows.Forms.Button RemoveResourceButton;
		private System.Windows.Forms.Button ClearHistoryButton;
		private System.Windows.Forms.ListBox ResourceList;
		private System.Windows.Forms.ComboBox ResourceAccountsComboBox;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Button EditAccountButton;
		private System.Windows.Forms.Button ShowHistoryButton;
		private System.Windows.Forms.Button AddAccountButton;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button RemoveAccountButton;
		private System.Windows.Forms.Button SettingsButton;
	}
}

