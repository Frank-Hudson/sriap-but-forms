
namespace SriapButForms
{
	partial class Gameplay
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.appLog = new SriapButForms.AppLog(this.components);
			this.buttonBack = new System.Windows.Forms.Button();
			this.labelScore = new System.Windows.Forms.Label();
			this.labelRemaining = new System.Windows.Forms.Label();
			this.labelTimeRemaining = new System.Windows.Forms.Label();
			this.labelCardsRemaining = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureTitle
			// 
			this.pictureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureTitle.BackColor = System.Drawing.Color.Transparent;
			this.pictureTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureTitle.Image = global::SriapButForms.Properties.Resources.icon_2;
			this.pictureTitle.Location = new System.Drawing.Point(0, 0);
			this.pictureTitle.Name = "pictureTitle";
			this.pictureTitle.Size = new System.Drawing.Size(960, 110);
			this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureTitle.TabIndex = 0;
			this.pictureTitle.TabStop = false;
			// 
			// buttonQuit
			// 
			this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonQuit.BackColor = System.Drawing.Color.Teal;
			this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonQuit.FlatAppearance.BorderSize = 3;
			this.buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonQuit.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonQuit.Location = new System.Drawing.Point(800, 486);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(148, 42);
			this.buttonQuit.TabIndex = 1;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = false;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonBack.BackColor = System.Drawing.Color.Teal;
			this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonBack.FlatAppearance.BorderSize = 3;
			this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonBack.Location = new System.Drawing.Point(12, 486);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(148, 42);
			this.buttonBack.TabIndex = 4;
			this.buttonBack.Text = "<<< Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// labelScore
			// 
			this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelScore.BackColor = System.Drawing.Color.Transparent;
			this.labelScore.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelScore.ForeColor = System.Drawing.Color.White;
			this.labelScore.Location = new System.Drawing.Point(224, 393);
			this.labelScore.Name = "labelScore";
			this.labelScore.Size = new System.Drawing.Size(166, 38);
			this.labelScore.TabIndex = 5;
			this.labelScore.Text = "Score 0";
			this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRemaining
			// 
			this.labelRemaining.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelRemaining.BackColor = System.Drawing.Color.Transparent;
			this.labelRemaining.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRemaining.ForeColor = System.Drawing.Color.White;
			this.labelRemaining.Location = new System.Drawing.Point(224, 175);
			this.labelRemaining.Name = "labelRemaining";
			this.labelRemaining.Size = new System.Drawing.Size(166, 38);
			this.labelRemaining.TabIndex = 6;
			this.labelRemaining.Text = "Remaining";
			this.labelRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTimeRemaining
			// 
			this.labelTimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelTimeRemaining.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeRemaining.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTimeRemaining.ForeColor = System.Drawing.Color.White;
			this.labelTimeRemaining.Location = new System.Drawing.Point(250, 233);
			this.labelTimeRemaining.Name = "labelTimeRemaining";
			this.labelTimeRemaining.Size = new System.Drawing.Size(116, 29);
			this.labelTimeRemaining.TabIndex = 7;
			this.labelTimeRemaining.Text = "--:--:---";
			this.labelTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCardsRemaining
			// 
			this.labelCardsRemaining.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelCardsRemaining.BackColor = System.Drawing.Color.Transparent;
			this.labelCardsRemaining.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelCardsRemaining.ForeColor = System.Drawing.Color.White;
			this.labelCardsRemaining.Location = new System.Drawing.Point(250, 286);
			this.labelCardsRemaining.Name = "labelCardsRemaining";
			this.labelCardsRemaining.Size = new System.Drawing.Size(116, 29);
			this.labelCardsRemaining.TabIndex = 8;
			this.labelCardsRemaining.Text = "Cards: 16";
			this.labelCardsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Gameplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.labelCardsRemaining);
			this.Controls.Add(this.labelTimeRemaining);
			this.Controls.Add(this.labelRemaining);
			this.Controls.Add(this.labelScore);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Gameplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormGameplayLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Button buttonQuit;
		private AppLog appLog;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label labelRemaining;
		private System.Windows.Forms.Label labelTimeRemaining;
		private System.Windows.Forms.Label labelCardsRemaining;
	}
}

