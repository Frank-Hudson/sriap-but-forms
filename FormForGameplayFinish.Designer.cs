
namespace SriapButForms
{
	partial class FormForGameplayFinish
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForGameplayFinish));
			this.buttonClose = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.labelScore = new System.Windows.Forms.Label();
			this.buttonSaveScore = new System.Windows.Forms.Button();
			this.buttonReplay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonClose.BackColor = System.Drawing.Color.Teal;
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonClose.ForeColor = System.Drawing.Color.White;
			this.buttonClose.Location = new System.Drawing.Point(91, 271);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(88, 27);
			this.buttonClose.TabIndex = 25;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.BackColor = System.Drawing.Color.Transparent;
			this.labelStatus.Font = new System.Drawing.Font("JetBrains Mono Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelStatus.ForeColor = System.Drawing.Color.White;
			this.labelStatus.Location = new System.Drawing.Point(12, 37);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(244, 58);
			this.labelStatus.TabIndex = 26;
			this.labelStatus.Text = "<WIN|LOSE>";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelScore
			// 
			this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelScore.BackColor = System.Drawing.Color.Transparent;
			this.labelScore.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelScore.ForeColor = System.Drawing.Color.White;
			this.labelScore.Location = new System.Drawing.Point(12, 109);
			this.labelScore.Name = "labelScore";
			this.labelScore.Size = new System.Drawing.Size(244, 36);
			this.labelScore.TabIndex = 27;
			this.labelScore.Text = "Score 0";
			this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSaveScore
			// 
			this.buttonSaveScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonSaveScore.BackColor = System.Drawing.Color.Teal;
			this.buttonSaveScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonSaveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveScore.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSaveScore.ForeColor = System.Drawing.Color.White;
			this.buttonSaveScore.Location = new System.Drawing.Point(60, 182);
			this.buttonSaveScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSaveScore.Name = "buttonSaveScore";
			this.buttonSaveScore.Size = new System.Drawing.Size(150, 32);
			this.buttonSaveScore.TabIndex = 28;
			this.buttonSaveScore.Text = "Save Score...";
			this.buttonSaveScore.UseVisualStyleBackColor = false;
			this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
			// 
			// buttonReplay
			// 
			this.buttonReplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonReplay.BackColor = System.Drawing.Color.Teal;
			this.buttonReplay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReplay.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonReplay.ForeColor = System.Drawing.Color.White;
			this.buttonReplay.Location = new System.Drawing.Point(80, 227);
			this.buttonReplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonReplay.Name = "buttonReplay";
			this.buttonReplay.Size = new System.Drawing.Size(110, 30);
			this.buttonReplay.TabIndex = 29;
			this.buttonReplay.Text = "Replay";
			this.buttonReplay.UseVisualStyleBackColor = false;
			this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
			// 
			// FormForGameplayFinish
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(268, 321);
			this.Controls.Add(this.buttonReplay);
			this.Controls.Add(this.buttonSaveScore);
			this.Controls.Add(this.labelScore);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormForGameplayFinish";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Button buttonSaveScore;
		private System.Windows.Forms.Button buttonReplay;
	}
}