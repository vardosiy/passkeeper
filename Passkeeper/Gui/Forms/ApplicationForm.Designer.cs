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
			this.AddResourceButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.ClearHistoryButton = new System.Windows.Forms.Button();
			this.PasswordList = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.ChangeButton = new System.Windows.Forms.Button();
			this.ShowHistoryButton = new System.Windows.Forms.Button();
			this.AddAccountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddResourceButton
			// 
			this.AddResourceButton.Location = new System.Drawing.Point(13, 13);
			this.AddResourceButton.Name = "AddResourceButton";
			this.AddResourceButton.Size = new System.Drawing.Size(90, 23);
			this.AddResourceButton.TabIndex = 0;
			this.AddResourceButton.Text = "Add Resource";
			this.AddResourceButton.UseVisualStyleBackColor = true;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(119, 11);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(90, 23);
			this.RemoveButton.TabIndex = 1;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			// 
			// ClearHistoryButton
			// 
			this.ClearHistoryButton.Location = new System.Drawing.Point(227, 11);
			this.ClearHistoryButton.Name = "ClearHistoryButton";
			this.ClearHistoryButton.Size = new System.Drawing.Size(90, 23);
			this.ClearHistoryButton.TabIndex = 2;
			this.ClearHistoryButton.Text = "Clear History";
			this.ClearHistoryButton.UseVisualStyleBackColor = true;
			// 
			// PasswordList
			// 
			this.PasswordList.FormattingEnabled = true;
			this.PasswordList.Location = new System.Drawing.Point(12, 42);
			this.PasswordList.Name = "PasswordList";
			this.PasswordList.Size = new System.Drawing.Size(305, 394);
			this.PasswordList.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(326, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(225, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.BackColor = System.Drawing.SystemColors.Control;
			this.EmailLabel.Location = new System.Drawing.Point(323, 42);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(35, 13);
			this.EmailLabel.TabIndex = 5;
			this.EmailLabel.Text = "Email:";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(322, 66);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(36, 13);
			this.LoginLabel.TabIndex = 6;
			this.LoginLabel.Text = "Login:";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(323, 93);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
			this.PasswordLabel.TabIndex = 7;
			this.PasswordLabel.Text = "Password:";
			// 
			// ChangeButton
			// 
			this.ChangeButton.Location = new System.Drawing.Point(324, 121);
			this.ChangeButton.Name = "ChangeButton";
			this.ChangeButton.Size = new System.Drawing.Size(350, 23);
			this.ChangeButton.TabIndex = 8;
			this.ChangeButton.Text = "Change...";
			this.ChangeButton.UseVisualStyleBackColor = true;
			// 
			// ShowHistoryButton
			// 
			this.ShowHistoryButton.Location = new System.Drawing.Point(324, 151);
			this.ShowHistoryButton.Name = "ShowHistoryButton";
			this.ShowHistoryButton.Size = new System.Drawing.Size(350, 23);
			this.ShowHistoryButton.TabIndex = 9;
			this.ShowHistoryButton.Text = "Show History...";
			this.ShowHistoryButton.UseVisualStyleBackColor = true;
			// 
			// AddAccountButton
			// 
			this.AddAccountButton.Location = new System.Drawing.Point(558, 13);
			this.AddAccountButton.Name = "AddAccountButton";
			this.AddAccountButton.Size = new System.Drawing.Size(116, 23);
			this.AddAccountButton.TabIndex = 10;
			this.AddAccountButton.Text = "Add Account";
			this.AddAccountButton.UseVisualStyleBackColor = true;
			// 
			// ApplicationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 450);
			this.Controls.Add(this.AddAccountButton);
			this.Controls.Add(this.ShowHistoryButton);
			this.Controls.Add(this.ChangeButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.PasswordList);
			this.Controls.Add(this.ClearHistoryButton);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.AddResourceButton);
			this.Name = "ApplicationForm";
			this.Text = "Passkeeper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddResourceButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button ClearHistoryButton;
		private System.Windows.Forms.ListBox PasswordList;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Button ChangeButton;
		private System.Windows.Forms.Button ShowHistoryButton;
		private System.Windows.Forms.Button AddAccountButton;
	}
}

