
namespace SriapButForms
{
	partial class FormForGameplay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForGameplay));
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.listBoxLog = new System.Windows.Forms.ListBox();
			this.appLog = new SriapButForms.AppLog(this.components);
			this.labelSelectedLog = new System.Windows.Forms.Label();
			this.buttonBack = new System.Windows.Forms.Button();
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
			// listBoxLog
			// 
			this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxLog.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listBoxLog.FormattingEnabled = true;
			this.listBoxLog.ItemHeight = 10;
			this.listBoxLog.Location = new System.Drawing.Point(634, 146);
			this.listBoxLog.Name = "listBoxLog";
			this.listBoxLog.Size = new System.Drawing.Size(296, 324);
			this.listBoxLog.TabIndex = 2;
			this.listBoxLog.SelectedIndexChanged += new System.EventHandler(this.listBoxLog_SelectedIndexChanged);
			// 
			// labelSelectedLog
			// 
			this.labelSelectedLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSelectedLog.BackColor = System.Drawing.Color.Transparent;
			this.labelSelectedLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelSelectedLog.ForeColor = System.Drawing.Color.White;
			this.labelSelectedLog.Location = new System.Drawing.Point(634, 94);
			this.labelSelectedLog.Name = "labelSelectedLog";
			this.labelSelectedLog.Size = new System.Drawing.Size(296, 46);
			this.labelSelectedLog.TabIndex = 3;
			this.labelSelectedLog.Text = "<selected log>";
			this.labelSelectedLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// FormForGameplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.labelSelectedLog);
			this.Controls.Add(this.listBoxLog);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormForGameplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormForGameplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.ListBox listBoxLog;
		private AppLog appLog;
		private System.Windows.Forms.Label labelSelectedLog;
		private System.Windows.Forms.Button buttonBack;
	}
}

