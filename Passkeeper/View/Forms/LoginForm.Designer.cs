namespace Passkeeper.View.Forms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.CreateUserButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.AutoSize = true;
			this.UserNameLabel.Location = new System.Drawing.Point(8, 25);
			this.UserNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(87, 20);
			this.UserNameLabel.TabIndex = 2;
			this.UserNameLabel.Text = "Username:";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.UsernameTextBox.Location = new System.Drawing.Point(113, 22);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.PasswordChar = '*';
			this.UsernameTextBox.Size = new System.Drawing.Size(310, 26);
			this.UsernameTextBox.TabIndex = 0;
			// 
			// OKButton
			// 
			this.OKButton.BackColor = System.Drawing.Color.Teal;
			this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OKButton.Location = new System.Drawing.Point(320, 125);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(103, 31);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = false;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PasswordTextBox.Location = new System.Drawing.Point(113, 64);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(310, 26);
			this.PasswordTextBox.TabIndex = 3;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(8, 67);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(83, 20);
			this.PasswordLabel.TabIndex = 4;
			this.PasswordLabel.Text = "Password:";
			// 
			// CreateUserButton
			// 
			this.CreateUserButton.BackColor = System.Drawing.Color.Teal;
			this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateUserButton.Location = new System.Drawing.Point(180, 125);
			this.CreateUserButton.Name = "CreateUserButton";
			this.CreateUserButton.Size = new System.Drawing.Size(134, 31);
			this.CreateUserButton.TabIndex = 5;
			this.CreateUserButton.Text = "Create User";
			this.CreateUserButton.UseVisualStyleBackColor = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(435, 168);
			this.Controls.Add(this.CreateUserButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.UserNameLabel);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UserNameLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Button CreateUserButton;
	}
}