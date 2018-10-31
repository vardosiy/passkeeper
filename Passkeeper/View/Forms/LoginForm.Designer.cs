namespace Passkeeper.Gui.Forms
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
			this.label1 = new System.Windows.Forms.Label();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter your password";
			// 
			// InputTextBox
			// 
			this.InputTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.InputTextBox.Location = new System.Drawing.Point(12, 67);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(358, 26);
			this.InputTextBox.TabIndex = 1;
			// 
			// OKButton
			// 
			this.OKButton.BackColor = System.Drawing.Color.Teal;
			this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OKButton.Location = new System.Drawing.Point(267, 120);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(103, 31);
			this.OKButton.TabIndex = 2;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = false;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(382, 163);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Button OKButton;
	}
}