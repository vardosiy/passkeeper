namespace Passkeeper
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
			this.ChangeButton = new System.Windows.Forms.Button();
			this.ShowHistoryButton = new System.Windows.Forms.Button();
			this.AddAccountButton = new System.Windows.Forms.Button();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.RemoveAccountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddResourceButton
			// 
			this.AddResourceButton.BackColor = System.Drawing.Color.LimeGreen;
			this.AddResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddResourceButton.Location = new System.Drawing.Point(16, 14);
			this.AddResourceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddResourceButton.Name = "AddResourceButton";
			this.AddResourceButton.Size = new System.Drawing.Size(225, 35);
			this.AddResourceButton.TabIndex = 0;
			this.AddResourceButton.Text = "Add Resource";
			this.AddResourceButton.UseVisualStyleBackColor = false;
			this.AddResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
			// 
			// RemoveResourceButton
			// 
			this.RemoveResourceButton.BackColor = System.Drawing.Color.IndianRed;
			this.RemoveResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveResourceButton.Location = new System.Drawing.Point(250, 14);
			this.RemoveResourceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RemoveResourceButton.Name = "RemoveResourceButton";
			this.RemoveResourceButton.Size = new System.Drawing.Size(225, 35);
			this.RemoveResourceButton.TabIndex = 1;
			this.RemoveResourceButton.Text = "Remove Resource";
			this.RemoveResourceButton.UseVisualStyleBackColor = false;
			this.RemoveResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
			// 
			// ClearHistoryButton
			// 
			this.ClearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearHistoryButton.Location = new System.Drawing.Point(484, 277);
			this.ClearHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ClearHistoryButton.Name = "ClearHistoryButton";
			this.ClearHistoryButton.Size = new System.Drawing.Size(526, 35);
			this.ClearHistoryButton.TabIndex = 2;
			this.ClearHistoryButton.Text = "Clear History";
			this.ClearHistoryButton.UseVisualStyleBackColor = true;
			this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
			// 
			// ResourceList
			// 
			this.ResourceList.BackColor = System.Drawing.SystemColors.GrayText;
			this.ResourceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ResourceList.FormattingEnabled = true;
			this.ResourceList.ItemHeight = 20;
			this.ResourceList.Location = new System.Drawing.Point(18, 58);
			this.ResourceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResourceList.Name = "ResourceList";
			this.ResourceList.Size = new System.Drawing.Size(456, 502);
			this.ResourceList.Sorted = true;
			this.ResourceList.TabIndex = 3;
			// 
			// ResourceAccountsComboBox
			// 
			this.ResourceAccountsComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ResourceAccountsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResourceAccountsComboBox.FormattingEnabled = true;
			this.ResourceAccountsComboBox.Location = new System.Drawing.Point(484, 17);
			this.ResourceAccountsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResourceAccountsComboBox.Name = "ResourceAccountsComboBox";
			this.ResourceAccountsComboBox.Size = new System.Drawing.Size(336, 28);
			this.ResourceAccountsComboBox.TabIndex = 4;
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
			// ChangeButton
			// 
			this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeButton.Location = new System.Drawing.Point(484, 188);
			this.ChangeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ChangeButton.Name = "ChangeButton";
			this.ChangeButton.Size = new System.Drawing.Size(526, 35);
			this.ChangeButton.TabIndex = 8;
			this.ChangeButton.Text = "Change...";
			this.ChangeButton.UseVisualStyleBackColor = true;
			// 
			// ShowHistoryButton
			// 
			this.ShowHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowHistoryButton.Location = new System.Drawing.Point(484, 232);
			this.ShowHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ShowHistoryButton.Name = "ShowHistoryButton";
			this.ShowHistoryButton.Size = new System.Drawing.Size(526, 35);
			this.ShowHistoryButton.TabIndex = 9;
			this.ShowHistoryButton.Text = "Show History...";
			this.ShowHistoryButton.UseVisualStyleBackColor = true;
			// 
			// AddAccountButton
			// 
			this.AddAccountButton.BackColor = System.Drawing.Color.LimeGreen;
			this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddAccountButton.Location = new System.Drawing.Point(831, 14);
			this.AddAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddAccountButton.Name = "AddAccountButton";
			this.AddAccountButton.Size = new System.Drawing.Size(180, 35);
			this.AddAccountButton.TabIndex = 10;
			this.AddAccountButton.Text = "Add Account";
			this.AddAccountButton.UseVisualStyleBackColor = false;
			this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.EmailTextBox.Location = new System.Drawing.Point(603, 65);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.ReadOnly = true;
			this.EmailTextBox.Size = new System.Drawing.Size(406, 26);
			this.EmailTextBox.TabIndex = 11;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LoginTextBox.Location = new System.Drawing.Point(603, 106);
			this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.ReadOnly = true;
			this.LoginTextBox.Size = new System.Drawing.Size(406, 26);
			this.LoginTextBox.TabIndex = 12;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PasswordTextBox.Location = new System.Drawing.Point(603, 148);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(406, 26);
			this.PasswordTextBox.TabIndex = 13;
			this.PasswordTextBox.Text = "Copy";
			// 
			// RemoveAccountButton
			// 
			this.RemoveAccountButton.BackColor = System.Drawing.Color.IndianRed;
			this.RemoveAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveAccountButton.Location = new System.Drawing.Point(484, 322);
			this.RemoveAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.RemoveAccountButton.Name = "RemoveAccountButton";
			this.RemoveAccountButton.Size = new System.Drawing.Size(526, 35);
			this.RemoveAccountButton.TabIndex = 14;
			this.RemoveAccountButton.Text = "Remove Account";
			this.RemoveAccountButton.UseVisualStyleBackColor = false;
			// 
			// ApplicationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(1029, 576);
			this.Controls.Add(this.RemoveAccountButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.AddAccountButton);
			this.Controls.Add(this.ShowHistoryButton);
			this.Controls.Add(this.ChangeButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.ResourceAccountsComboBox);
			this.Controls.Add(this.ResourceList);
			this.Controls.Add(this.ClearHistoryButton);
			this.Controls.Add(this.RemoveResourceButton);
			this.Controls.Add(this.AddResourceButton);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ApplicationForm";
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
		private System.Windows.Forms.Button ChangeButton;
		private System.Windows.Forms.Button ShowHistoryButton;
		private System.Windows.Forms.Button AddAccountButton;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button RemoveAccountButton;
	}
}

