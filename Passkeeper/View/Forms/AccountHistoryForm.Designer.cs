namespace Passkeeper.View.Forms
{
	partial class AccountHistoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountHistoryForm));
			this.ContentTextBox = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ContentTextBox
			// 
			this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
			this.ContentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ContentTextBox.Location = new System.Drawing.Point(13, 13);
			this.ContentTextBox.Multiline = true;
			this.ContentTextBox.Name = "ContentTextBox";
			this.ContentTextBox.ReadOnly = true;
			this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ContentTextBox.Size = new System.Drawing.Size(576, 332);
			this.ContentTextBox.TabIndex = 0;
			this.ContentTextBox.WordWrap = false;
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.BackColor = System.Drawing.Color.Teal;
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OKButton.Location = new System.Drawing.Point(486, 367);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(103, 31);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = false;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// AccountHistoryForm
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
			this.CancelButton = this.OKButton;
			this.ClientSize = new System.Drawing.Size(601, 410);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.ContentTextBox);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(359, 219);
			this.Name = "AccountHistoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Account\'s History";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ContentTextBox;
		private System.Windows.Forms.Button OKButton;
	}
}