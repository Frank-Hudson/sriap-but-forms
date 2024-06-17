
namespace SriapButForms
{
	partial class Scores
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scores));
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.groupHighScoreMode = new System.Windows.Forms.GroupBox();
			this.labelLayoutTitle = new System.Windows.Forms.Label();
			this.radioHighScoresModeTable = new System.Windows.Forms.RadioButton();
			this.radioHighScoresModeCards = new System.Windows.Forms.RadioButton();
			this.buttonBack = new System.Windows.Forms.Button();
			this.tableHighScores = new System.Windows.Forms.DataGridView();
			this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureCycLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			this.groupHighScoreMode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableHighScores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).BeginInit();
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
			this.pictureTitle.TabIndex = 1;
			this.pictureTitle.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("JetBrains Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(382, 113);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(191, 36);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "High Scores";
			// 
			// groupHighScoreMode
			// 
			this.groupHighScoreMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.groupHighScoreMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupHighScoreMode.Controls.Add(this.labelLayoutTitle);
			this.groupHighScoreMode.Controls.Add(this.radioHighScoresModeTable);
			this.groupHighScoreMode.Controls.Add(this.radioHighScoresModeCards);
			this.groupHighScoreMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupHighScoreMode.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.groupHighScoreMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupHighScoreMode.Location = new System.Drawing.Point(53, 240);
			this.groupHighScoreMode.Name = "groupHighScoreMode";
			this.groupHighScoreMode.Size = new System.Drawing.Size(113, 125);
			this.groupHighScoreMode.TabIndex = 3;
			this.groupHighScoreMode.TabStop = false;
			// 
			// labelLayoutTitle
			// 
			this.labelLayoutTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelLayoutTitle.AutoSize = true;
			this.labelLayoutTitle.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelLayoutTitle.ForeColor = System.Drawing.Color.White;
			this.labelLayoutTitle.Location = new System.Drawing.Point(37, 28);
			this.labelLayoutTitle.Name = "labelLayoutTitle";
			this.labelLayoutTitle.Size = new System.Drawing.Size(70, 21);
			this.labelLayoutTitle.TabIndex = 8;
			this.labelLayoutTitle.Text = "Layout";
			// 
			// radioHighScoresModeTable
			// 
			this.radioHighScoresModeTable.AutoSize = true;
			this.radioHighScoresModeTable.Checked = true;
			this.radioHighScoresModeTable.ForeColor = System.Drawing.Color.White;
			this.radioHighScoresModeTable.Location = new System.Drawing.Point(17, 84);
			this.radioHighScoresModeTable.Name = "radioHighScoresModeTable";
			this.radioHighScoresModeTable.Size = new System.Drawing.Size(66, 21);
			this.radioHighScoresModeTable.TabIndex = 1;
			this.radioHighScoresModeTable.TabStop = true;
			this.radioHighScoresModeTable.Text = "Table";
			this.radioHighScoresModeTable.UseVisualStyleBackColor = true;
			// 
			// radioHighScoresModeCards
			// 
			this.radioHighScoresModeCards.AutoSize = true;
			this.radioHighScoresModeCards.Enabled = false;
			this.radioHighScoresModeCards.ForeColor = System.Drawing.Color.White;
			this.radioHighScoresModeCards.Location = new System.Drawing.Point(17, 57);
			this.radioHighScoresModeCards.Name = "radioHighScoresModeCards";
			this.radioHighScoresModeCards.Size = new System.Drawing.Size(66, 21);
			this.radioHighScoresModeCards.TabIndex = 0;
			this.radioHighScoresModeCards.Text = "Cards";
			this.radioHighScoresModeCards.UseVisualStyleBackColor = true;
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
			this.buttonBack.TabIndex = 5;
			this.buttonBack.Text = "<<< Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// tableHighScores
			// 
			this.tableHighScores.AllowUserToAddRows = false;
			this.tableHighScores.AllowUserToDeleteRows = false;
			this.tableHighScores.AllowUserToResizeColumns = false;
			this.tableHighScores.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.tableHighScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.tableHighScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tableHighScores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
			this.tableHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tableHighScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.tableHighScores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.tableHighScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.tableHighScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.tableHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.tableHighScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnScore,
            this.ColumnTime,
            this.ColumnUser});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.tableHighScores.DefaultCellStyle = dataGridViewCellStyle6;
			this.tableHighScores.EnableHeadersVisualStyles = false;
			this.tableHighScores.Location = new System.Drawing.Point(314, 168);
			this.tableHighScores.Name = "tableHighScores";
			this.tableHighScores.ReadOnly = true;
			this.tableHighScores.RowHeadersVisible = false;
			this.tableHighScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.tableHighScores.RowTemplate.Height = 25;
			this.tableHighScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tableHighScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tableHighScores.ShowEditingIcon = false;
			this.tableHighScores.Size = new System.Drawing.Size(320, 322);
			this.tableHighScores.TabIndex = 7;
			// 
			// ColumnScore
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnScore.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnScore.HeaderText = "Score";
			this.ColumnScore.MaxInputLength = 4;
			this.ColumnScore.Name = "ColumnScore";
			this.ColumnScore.ReadOnly = true;
			this.ColumnScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnScore.Width = 80;
			// 
			// ColumnTime
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ColumnTime.DefaultCellStyle = dataGridViewCellStyle4;
			this.ColumnTime.HeaderText = "Time";
			this.ColumnTime.MaxInputLength = 5;
			this.ColumnTime.Name = "ColumnTime";
			this.ColumnTime.ReadOnly = true;
			this.ColumnTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnTime.Width = 60;
			// 
			// ColumnUser
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnUser.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnUser.HeaderText = "Username";
			this.ColumnUser.Name = "ColumnUser";
			this.ColumnUser.ReadOnly = true;
			this.ColumnUser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnUser.Width = 180;
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
			this.pictureCycLogo.TabIndex = 10;
			this.pictureCycLogo.TabStop = false;
			// 
			// Scores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.pictureCycLogo);
			this.Controls.Add(this.tableHighScores);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.groupHighScoreMode);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Scores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap - High Scores";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormForHighScores_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			this.groupHighScoreMode.ResumeLayout(false);
			this.groupHighScoreMode.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tableHighScores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.GroupBox groupHighScoreMode;
		private System.Windows.Forms.RadioButton radioHighScoresModeCards;
		private System.Windows.Forms.RadioButton radioHighScoresModeTable;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.DataGridView tableHighScores;
		private System.Windows.Forms.Label labelLayoutTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
		private System.Windows.Forms.PictureBox pictureCycLogo;
	}
}