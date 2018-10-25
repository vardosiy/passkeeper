namespace Passkeeper.Gui.Forms
{
	partial class AddResourceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResourceForm));
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ResourceNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.LimeGreen;
			this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OkButton.Location = new System.Drawing.Point(262, 106);
			this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(112, 35);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.Teal;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Location = new System.Drawing.Point(382, 106);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(112, 35);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			// 
			// ResourceNameTextBox
			// 
			this.ResourceNameTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ResourceNameTextBox.Location = new System.Drawing.Point(13, 52);
			this.ResourceNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResourceNameTextBox.Name = "ResourceNameTextBox";
			this.ResourceNameTextBox.Size = new System.Drawing.Size(481, 26);
			this.ResourceNameTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter new resource name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AddResourceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(507, 155);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ResourceNameTextBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddResourceForm";
			this.Text = "Add New Resource";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.TextBox ResourceNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}