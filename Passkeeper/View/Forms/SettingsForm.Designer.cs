namespace Passkeeper.View.Forms
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
			this.ConfirmTextBox = new System.Windows.Forms.TextBox();
			this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
			this.MainLabel = new System.Windows.Forms.Label();
			this.MainTextBox = new System.Windows.Forms.TextBox();
			this.NewPasswordLabel = new System.Windows.Forms.Label();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.ChangeModeButton = new System.Windows.Forms.Button();
			this.BackupPathTextBox = new System.Windows.Forms.TextBox();
			this.BackupPathLabel = new System.Windows.Forms.Label();
			this.BrowseFoldersButton = new System.Windows.Forms.Button();
			this.BackupPeriodLabel = new System.Windows.Forms.Label();
			this.BackupPeriodNumUD = new System.Windows.Forms.NumericUpDown();
			this.DaysLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BackupPeriodNumUD)).BeginInit();
			this.SuspendLayout();
			// 
			// ConfirmPasswordLabel
			// 
			this.ConfirmPasswordLabel.AutoSize = true;
			this.ConfirmPasswordLabel.Location = new System.Drawing.Point(11, 280);
			this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
			this.ConfirmPasswordLabel.Size = new System.Drawing.Size(70, 20);
			this.ConfirmPasswordLabel.TabIndex = 20;
			this.ConfirmPasswordLabel.Text = "Confirm:";
			this.ConfirmPasswordLabel.Visible = false;
			// 
			// ConfirmTextBox
			// 
			this.ConfirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ConfirmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ConfirmTextBox.Location = new System.Drawing.Point(104, 278);
			this.ConfirmTextBox.Name = "ConfirmTextBox";
			this.ConfirmTextBox.PasswordChar = '*';
			this.ConfirmTextBox.Size = new System.Drawing.Size(340, 26);
			this.ConfirmTextBox.TabIndex = 17;
			this.ConfirmTextBox.Visible = false;
			// 
			// NewPasswordTextBox
			// 
			this.NewPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.NewPasswordTextBox.Location = new System.Drawing.Point(104, 242);
			this.NewPasswordTextBox.Name = "NewPasswordTextBox";
			this.NewPasswordTextBox.PasswordChar = '*';
			this.NewPasswordTextBox.Size = new System.Drawing.Size(340, 26);
			this.NewPasswordTextBox.TabIndex = 16;
			this.NewPasswordTextBox.Visible = false;
			// 
			// MainLabel
			// 
			this.MainLabel.AutoSize = true;
			this.MainLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.MainLabel.Location = new System.Drawing.Point(11, 209);
			this.MainLabel.Name = "MainLabel";
			this.MainLabel.Size = new System.Drawing.Size(87, 20);
			this.MainLabel.TabIndex = 18;
			this.MainLabel.Text = "Username:";
			// 
			// MainTextBox
			// 
			this.MainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.MainTextBox.Location = new System.Drawing.Point(104, 207);
			this.MainTextBox.Name = "MainTextBox";
			this.MainTextBox.Size = new System.Drawing.Size(340, 26);
			this.MainTextBox.TabIndex = 22;
			// 
			// NewPasswordLabel
			// 
			this.NewPasswordLabel.AutoSize = true;
			this.NewPasswordLabel.Location = new System.Drawing.Point(11, 244);
			this.NewPasswordLabel.Name = "NewPasswordLabel";
			this.NewPasswordLabel.Size = new System.Drawing.Size(48, 20);
			this.NewPasswordLabel.TabIndex = 24;
			this.NewPasswordLabel.Text = "New:";
			this.NewPasswordLabel.Visible = false;
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Location = new System.Drawing.Point(332, 328);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(112, 35);
			this.CancelButton.TabIndex = 26;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ApplyButton
			// 
			this.ApplyButton.BackColor = System.Drawing.Color.Teal;
			this.ApplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ApplyButton.Location = new System.Drawing.Point(212, 328);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(112, 35);
			this.ApplyButton.TabIndex = 25;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = false;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// ChangeModeButton
			// 
			this.ChangeModeButton.BackColor = System.Drawing.Color.Teal;
			this.ChangeModeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ChangeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeModeButton.Location = new System.Drawing.Point(15, 161);
			this.ChangeModeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ChangeModeButton.Name = "ChangeModeButton";
			this.ChangeModeButton.Size = new System.Drawing.Size(167, 30);
			this.ChangeModeButton.TabIndex = 27;
			this.ChangeModeButton.Text = "Change Password";
			this.ChangeModeButton.UseVisualStyleBackColor = false;
			this.ChangeModeButton.Click += new System.EventHandler(this.ChangeModeButton_Click);
			// 
			// BackupPathTextBox
			// 
			this.BackupPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.BackupPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BackupPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.BackupPathTextBox.Location = new System.Drawing.Point(15, 51);
			this.BackupPathTextBox.Name = "BackupPathTextBox";
			this.BackupPathTextBox.Size = new System.Drawing.Size(429, 26);
			this.BackupPathTextBox.TabIndex = 28;
			// 
			// BackupPathLabel
			// 
			this.BackupPathLabel.AutoSize = true;
			this.BackupPathLabel.Location = new System.Drawing.Point(11, 18);
			this.BackupPathLabel.Name = "BackupPathLabel";
			this.BackupPathLabel.Size = new System.Drawing.Size(137, 20);
			this.BackupPathLabel.TabIndex = 29;
			this.BackupPathLabel.Text = "Path for backups:";
			// 
			// BrowseFoldersButton
			// 
			this.BrowseFoldersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.BrowseFoldersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.BrowseFoldersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BrowseFoldersButton.Location = new System.Drawing.Point(410, 13);
			this.BrowseFoldersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BrowseFoldersButton.Name = "BrowseFoldersButton";
			this.BrowseFoldersButton.Size = new System.Drawing.Size(34, 30);
			this.BrowseFoldersButton.TabIndex = 30;
			this.BrowseFoldersButton.Text = "...";
			this.BrowseFoldersButton.UseVisualStyleBackColor = false;
			this.BrowseFoldersButton.Click += new System.EventHandler(this.BrowseFoldersButton_Click);
			// 
			// BackupPeriodLabel
			// 
			this.BackupPeriodLabel.AutoSize = true;
			this.BackupPeriodLabel.Location = new System.Drawing.Point(12, 90);
			this.BackupPeriodLabel.Name = "BackupPeriodLabel";
			this.BackupPeriodLabel.Size = new System.Drawing.Size(165, 20);
			this.BackupPeriodLabel.TabIndex = 31;
			this.BackupPeriodLabel.Text = "Create backup each";
			// 
			// BackupPeriodNumUD
			// 
			this.BackupPeriodNumUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.BackupPeriodNumUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.BackupPeriodNumUD.Location = new System.Drawing.Point(183, 88);
			this.BackupPeriodNumUD.Name = "BackupPeriodNumUD";
			this.BackupPeriodNumUD.Size = new System.Drawing.Size(52, 26);
			this.BackupPeriodNumUD.TabIndex = 32;
			// 
			// DaysLabel
			// 
			this.DaysLabel.AutoSize = true;
			this.DaysLabel.Location = new System.Drawing.Point(242, 90);
			this.DaysLabel.Name = "DaysLabel";
			this.DaysLabel.Size = new System.Drawing.Size(47, 20);
			this.DaysLabel.TabIndex = 33;
			this.DaysLabel.Text = "days.";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(456, 377);
			this.Controls.Add(this.DaysLabel);
			this.Controls.Add(this.BackupPeriodNumUD);
			this.Controls.Add(this.BackupPeriodLabel);
			this.Controls.Add(this.BrowseFoldersButton);
			this.Controls.Add(this.BackupPathLabel);
			this.Controls.Add(this.BackupPathTextBox);
			this.Controls.Add(this.ChangeModeButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.NewPasswordLabel);
			this.Controls.Add(this.MainTextBox);
			this.Controls.Add(this.ConfirmPasswordLabel);
			this.Controls.Add(this.ConfirmTextBox);
			this.Controls.Add(this.NewPasswordTextBox);
			this.Controls.Add(this.MainLabel);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SettingsForm";
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.BackupPeriodNumUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label ConfirmPasswordLabel;
		private System.Windows.Forms.TextBox ConfirmTextBox;
		private System.Windows.Forms.TextBox NewPasswordTextBox;
		private System.Windows.Forms.Label NewPasswordLabel;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Button ChangeModeButton;
		private System.Windows.Forms.Label MainLabel;
		private System.Windows.Forms.TextBox MainTextBox;
		private System.Windows.Forms.TextBox BackupPathTextBox;
		private System.Windows.Forms.Label BackupPathLabel;
		private System.Windows.Forms.Button BrowseFoldersButton;
		private System.Windows.Forms.Label BackupPeriodLabel;
		private System.Windows.Forms.NumericUpDown BackupPeriodNumUD;
		private System.Windows.Forms.Label DaysLabel;
	}
}