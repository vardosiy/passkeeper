namespace Passkeeper.View.Forms
{
	partial class SignInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
			this.OKButton = new System.Windows.Forms.Button();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.CreateUserButton = new System.Windows.Forms.Button();
			this.ConfirmTextBox = new System.Windows.Forms.TextBox();
			this.ConfirmLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OKButton
			// 
			this.OKButton.BackColor = System.Drawing.Color.Teal;
			this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OKButton.Location = new System.Drawing.Point(306, 156);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(117, 31);
			this.OKButton.TabIndex = 3;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = false;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.UsernameTextBox.Location = new System.Drawing.Point(105, 23);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(318, 26);
			this.UsernameTextBox.TabIndex = 0;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Location = new System.Drawing.Point(12, 25);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
			this.UsernameLabel.TabIndex = 4;
			this.UsernameLabel.Text = "Username:";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.PasswordTextBox.Location = new System.Drawing.Point(105, 59);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(318, 26);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(12, 61);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(83, 20);
			this.PasswordLabel.TabIndex = 5;
			this.PasswordLabel.Text = "Password:";
			// 
			// CreateUserButton
			// 
			this.CreateUserButton.BackColor = System.Drawing.Color.Teal;
			this.CreateUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateUserButton.Location = new System.Drawing.Point(183, 156);
			this.CreateUserButton.Name = "CreateUserButton";
			this.CreateUserButton.Size = new System.Drawing.Size(117, 31);
			this.CreateUserButton.TabIndex = 4;
			this.CreateUserButton.Text = "Create User";
			this.CreateUserButton.UseVisualStyleBackColor = false;
			this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
			// 
			// ConfirmTextBox
			// 
			this.ConfirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ConfirmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ConfirmTextBox.Location = new System.Drawing.Point(105, 95);
			this.ConfirmTextBox.Name = "ConfirmTextBox";
			this.ConfirmTextBox.PasswordChar = '*';
			this.ConfirmTextBox.Size = new System.Drawing.Size(318, 26);
			this.ConfirmTextBox.TabIndex = 2;
			this.ConfirmTextBox.Visible = false;
			// 
			// ConfirmLabel
			// 
			this.ConfirmLabel.AutoSize = true;
			this.ConfirmLabel.Location = new System.Drawing.Point(12, 97);
			this.ConfirmLabel.Name = "ConfirmLabel";
			this.ConfirmLabel.Size = new System.Drawing.Size(70, 20);
			this.ConfirmLabel.TabIndex = 7;
			this.ConfirmLabel.Text = "Confirm:";
			this.ConfirmLabel.Visible = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(435, 199);
			this.Controls.Add(this.ConfirmLabel);
			this.Controls.Add(this.ConfirmTextBox);
			this.Controls.Add(this.CreateUserButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.OKButton);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sign In";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label PasswordLabel;
		public System.Windows.Forms.Button CreateUserButton;
		public System.Windows.Forms.TextBox ConfirmTextBox;
		public System.Windows.Forms.Label ConfirmLabel;
	}
}