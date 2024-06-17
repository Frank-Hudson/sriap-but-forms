
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.labelScore = new System.Windows.Forms.Label();
			this.labelRemaining = new System.Windows.Forms.Label();
			this.labelTimeRemaining = new System.Windows.Forms.Label();
			this.labelCardsRemaining = new System.Windows.Forms.Label();
			this.pictureCycLogo = new System.Windows.Forms.PictureBox();
			this.panelOutcome = new System.Windows.Forms.Panel();
			this.labelTimeResult = new System.Windows.Forms.Label();
			this.buttonReplay = new System.Windows.Forms.Button();
			this.buttonSaveScore = new System.Windows.Forms.Button();
			this.labelScoreResult = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).BeginInit();
			this.panelOutcome.SuspendLayout();
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
			this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelScore.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelScore.ForeColor = System.Drawing.Color.White;
			this.labelScore.Location = new System.Drawing.Point(12, 389);
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
			this.labelRemaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelRemaining.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRemaining.ForeColor = System.Drawing.Color.White;
			this.labelRemaining.Location = new System.Drawing.Point(12, 171);
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
			this.labelTimeRemaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelTimeRemaining.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTimeRemaining.ForeColor = System.Drawing.Color.White;
			this.labelTimeRemaining.Location = new System.Drawing.Point(38, 229);
			this.labelTimeRemaining.Name = "labelTimeRemaining";
			this.labelTimeRemaining.Size = new System.Drawing.Size(116, 29);
			this.labelTimeRemaining.TabIndex = 7;
			this.labelTimeRemaining.Text = "--:--";
			this.labelTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCardsRemaining
			// 
			this.labelCardsRemaining.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelCardsRemaining.BackColor = System.Drawing.Color.Transparent;
			this.labelCardsRemaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelCardsRemaining.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelCardsRemaining.ForeColor = System.Drawing.Color.White;
			this.labelCardsRemaining.Location = new System.Drawing.Point(38, 282);
			this.labelCardsRemaining.Name = "labelCardsRemaining";
			this.labelCardsRemaining.Size = new System.Drawing.Size(116, 29);
			this.labelCardsRemaining.TabIndex = 8;
			this.labelCardsRemaining.Text = "Cards: 16";
			this.labelCardsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureCycLogo
			// 
			this.pictureCycLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureCycLogo.ErrorImage = global::SriapButForms.Properties.Resources.CardError;
			this.pictureCycLogo.Image = global::SriapButForms.Properties.Resources.coleg_y_cymoedd_icon_arch_green_on_black;
			this.pictureCycLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureCycLogo.Name = "pictureCycLogo";
			this.pictureCycLogo.Size = new System.Drawing.Size(100, 100);
			this.pictureCycLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureCycLogo.TabIndex = 9;
			this.pictureCycLogo.TabStop = false;
			// 
			// panelOutcome
			// 
			this.panelOutcome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
			this.panelOutcome.Controls.Add(this.labelTimeResult);
			this.panelOutcome.Controls.Add(this.buttonReplay);
			this.panelOutcome.Controls.Add(this.buttonSaveScore);
			this.panelOutcome.Controls.Add(this.labelScoreResult);
			this.panelOutcome.Controls.Add(this.labelStatus);
			this.panelOutcome.Location = new System.Drawing.Point(337, 122);
			this.panelOutcome.Name = "panelOutcome";
			this.panelOutcome.Size = new System.Drawing.Size(284, 360);
			this.panelOutcome.TabIndex = 10;
			this.panelOutcome.Visible = false;
			// 
			// labelTimeResult
			// 
			this.labelTimeResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTimeResult.BackColor = System.Drawing.Color.Transparent;
			this.labelTimeResult.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTimeResult.ForeColor = System.Drawing.Color.White;
			this.labelTimeResult.Location = new System.Drawing.Point(20, 181);
			this.labelTimeResult.Name = "labelTimeResult";
			this.labelTimeResult.Size = new System.Drawing.Size(244, 36);
			this.labelTimeResult.TabIndex = 38;
			this.labelTimeResult.Text = "--:--";
			this.labelTimeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonReplay
			// 
			this.buttonReplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonReplay.BackColor = System.Drawing.Color.Teal;
			this.buttonReplay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReplay.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonReplay.ForeColor = System.Drawing.Color.White;
			this.buttonReplay.Location = new System.Drawing.Point(68, 247);
			this.buttonReplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonReplay.Name = "buttonReplay";
			this.buttonReplay.Size = new System.Drawing.Size(150, 35);
			this.buttonReplay.TabIndex = 36;
			this.buttonReplay.Text = "Replay";
			this.buttonReplay.UseVisualStyleBackColor = false;
			this.buttonReplay.Click += new System.EventHandler(this.OutcomeClosed);
			// 
			// buttonSaveScore
			// 
			this.buttonSaveScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonSaveScore.BackColor = System.Drawing.Color.Teal;
			this.buttonSaveScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonSaveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveScore.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSaveScore.ForeColor = System.Drawing.Color.White;
			this.buttonSaveScore.Location = new System.Drawing.Point(68, 293);
			this.buttonSaveScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSaveScore.Name = "buttonSaveScore";
			this.buttonSaveScore.Size = new System.Drawing.Size(150, 35);
			this.buttonSaveScore.TabIndex = 35;
			this.buttonSaveScore.Text = "Save Score...";
			this.buttonSaveScore.UseVisualStyleBackColor = false;
			this.buttonSaveScore.Click += new System.EventHandler(this.ButtonSaveScoreClicked);
			// 
			// labelScoreResult
			// 
			this.labelScoreResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelScoreResult.BackColor = System.Drawing.Color.Transparent;
			this.labelScoreResult.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelScoreResult.ForeColor = System.Drawing.Color.White;
			this.labelScoreResult.Location = new System.Drawing.Point(20, 131);
			this.labelScoreResult.Name = "labelScoreResult";
			this.labelScoreResult.Size = new System.Drawing.Size(244, 36);
			this.labelScoreResult.TabIndex = 34;
			this.labelScoreResult.Text = "Score 0";
			this.labelScoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.BackColor = System.Drawing.Color.Transparent;
			this.labelStatus.Font = new System.Drawing.Font("JetBrains Mono Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelStatus.ForeColor = System.Drawing.Color.White;
			this.labelStatus.Location = new System.Drawing.Point(20, 45);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(244, 58);
			this.labelStatus.TabIndex = 33;
			this.labelStatus.Text = "<WIN|LOSE>";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Gameplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.panelOutcome);
			this.Controls.Add(this.pictureCycLogo);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).EndInit();
			this.panelOutcome.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label labelRemaining;
		private System.Windows.Forms.Label labelTimeRemaining;
		private System.Windows.Forms.Label labelCardsRemaining;
		private System.Windows.Forms.PictureBox pictureCycLogo;
		private System.Windows.Forms.Panel panelOutcome;
		private System.Windows.Forms.Label labelTimeResult;
		private System.Windows.Forms.Button buttonReplay;
		private System.Windows.Forms.Button buttonSaveScore;
		private System.Windows.Forms.Label labelScoreResult;
		private System.Windows.Forms.Label labelStatus;
	}
}

