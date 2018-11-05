namespace Passkeeper.View.Forms
{
	partial class AddAccountForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.EmailTextBox.Location = new System.Drawing.Point(112, 12);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(290, 26);
			this.EmailTextBox.TabIndex = 2;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.LoginTextBox.Location = new System.Drawing.Point(112, 56);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(290, 26);
			this.LoginTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.PasswordTextBox.Location = new System.Drawing.Point(112, 100);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(290, 26);
			this.PasswordTextBox.TabIndex = 5;
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.Teal;
			this.OkButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OkButton.Location = new System.Drawing.Point(170, 148);
			this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(112, 35);
			this.OkButton.TabIndex = 8;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Location = new System.Drawing.Point(290, 148);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(112, 35);
			this.CancelButton.TabIndex = 9;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(13, 103);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(83, 20);
			this.PasswordLabel.TabIndex = 12;
			this.PasswordLabel.Text = "Password:";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(13, 59);
			this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(52, 20);
			this.LoginLabel.TabIndex = 11;
			this.LoginLabel.Text = "Login:";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(13, 15);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(50, 20);
			this.EmailLabel.TabIndex = 10;
			this.EmailLabel.Text = "Email:";
			// 
			// AddAccountForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
			this.ClientSize = new System.Drawing.Size(414, 197);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddAccountForm";
			this.Text = "Add Account";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Label EmailLabel;
	}
}