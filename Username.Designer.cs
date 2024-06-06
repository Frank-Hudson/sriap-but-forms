
namespace SriapButForms
{
	partial class Username
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Username));
			this.inputUsername = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputUsername
			// 
			this.inputUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputUsername.BackColor = System.Drawing.Color.Gainsboro;
			this.inputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputUsername.Font = new System.Drawing.Font("JetBrains Mono Thin", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.inputUsername.Location = new System.Drawing.Point(12, 42);
			this.inputUsername.MaxLength = 27;
			this.inputUsername.Name = "inputUsername";
			this.inputUsername.PlaceholderText = "Enter username...";
			this.inputUsername.Size = new System.Drawing.Size(252, 25);
			this.inputUsername.TabIndex = 0;
			this.inputUsername.WordWrap = false;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonSave.BackColor = System.Drawing.Color.Teal;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSave.ForeColor = System.Drawing.Color.White;
			this.buttonSave.Location = new System.Drawing.Point(89, 101);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 27);
			this.buttonSave.TabIndex = 26;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormForUsername
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(276, 142);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.inputUsername);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormForUsername";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter Username - Save Score";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputUsername;
		private System.Windows.Forms.Button buttonSave;
	}
}