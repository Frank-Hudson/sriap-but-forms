
namespace SriapButForms
{
	partial class FormForSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForSettings));
			this.buttonBack = new System.Windows.Forms.Button();
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.numericMaximumImages = new System.Windows.Forms.NumericUpDown();
			this.labelOutOfImages = new System.Windows.Forms.Label();
			this.numericCardGridY = new System.Windows.Forms.NumericUpDown();
			this.labelByCardGrid = new System.Windows.Forms.Label();
			this.numericCardGridX = new System.Windows.Forms.NumericUpDown();
			this.labelImages = new System.Windows.Forms.Label();
			this.labelCardGrid = new System.Windows.Forms.Label();
			this.labelMaxImages = new System.Windows.Forms.Label();
			this.numericPairs = new System.Windows.Forms.NumericUpDown();
			this.labelPairs = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaximumImages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardGridY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardGridX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPairs)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonBack.BackColor = System.Drawing.Color.Teal;
			this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonBack.FlatAppearance.BorderSize = 3;
			this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonBack.Location = new System.Drawing.Point(12, 486);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(148, 42);
			this.buttonBack.TabIndex = 7;
			this.buttonBack.Text = "<<< Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
			this.pictureTitle.TabIndex = 6;
			this.pictureTitle.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("JetBrains Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(404, 132);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(143, 36);
			this.labelTitle.TabIndex = 8;
			this.labelTitle.Text = "Settings";
			// 
			// numericMaximumImages
			// 
			this.numericMaximumImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericMaximumImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numericMaximumImages.Location = new System.Drawing.Point(498, 292);
			this.numericMaximumImages.Name = "numericMaximumImages";
			this.numericMaximumImages.Size = new System.Drawing.Size(59, 33);
			this.numericMaximumImages.TabIndex = 9;
			this.numericMaximumImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericMaximumImages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// labelOutOfImages
			// 
			this.labelOutOfImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelOutOfImages.AutoSize = true;
			this.labelOutOfImages.BackColor = System.Drawing.Color.Transparent;
			this.labelOutOfImages.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelOutOfImages.ForeColor = System.Drawing.Color.White;
			this.labelOutOfImages.Location = new System.Drawing.Point(472, 297);
			this.labelOutOfImages.Name = "labelOutOfImages";
			this.labelOutOfImages.Size = new System.Drawing.Size(20, 21);
			this.labelOutOfImages.TabIndex = 10;
			this.labelOutOfImages.Text = "/";
			this.labelOutOfImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericCardGridY
			// 
			this.numericCardGridY.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericCardGridY.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numericCardGridY.Location = new System.Drawing.Point(498, 213);
			this.numericCardGridY.Name = "numericCardGridY";
			this.numericCardGridY.Size = new System.Drawing.Size(59, 33);
			this.numericCardGridY.TabIndex = 11;
			this.numericCardGridY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCardGridY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// labelByCardGrid
			// 
			this.labelByCardGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelByCardGrid.AutoSize = true;
			this.labelByCardGrid.BackColor = System.Drawing.Color.Transparent;
			this.labelByCardGrid.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelByCardGrid.ForeColor = System.Drawing.Color.White;
			this.labelByCardGrid.Location = new System.Drawing.Point(472, 218);
			this.labelByCardGrid.Name = "labelByCardGrid";
			this.labelByCardGrid.Size = new System.Drawing.Size(20, 21);
			this.labelByCardGrid.TabIndex = 12;
			this.labelByCardGrid.Text = "x";
			this.labelByCardGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericCardGridX
			// 
			this.numericCardGridX.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericCardGridX.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numericCardGridX.Location = new System.Drawing.Point(407, 213);
			this.numericCardGridX.Name = "numericCardGridX";
			this.numericCardGridX.Size = new System.Drawing.Size(59, 33);
			this.numericCardGridX.TabIndex = 13;
			this.numericCardGridX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCardGridX.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// labelImages
			// 
			this.labelImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelImages.BackColor = System.Drawing.Color.Transparent;
			this.labelImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelImages.ForeColor = System.Drawing.Color.White;
			this.labelImages.Location = new System.Drawing.Point(404, 292);
			this.labelImages.Name = "labelImages";
			this.labelImages.Size = new System.Drawing.Size(59, 33);
			this.labelImages.TabIndex = 14;
			this.labelImages.Text = "8";
			this.labelImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCardGrid
			// 
			this.labelCardGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelCardGrid.BackColor = System.Drawing.Color.Transparent;
			this.labelCardGrid.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelCardGrid.ForeColor = System.Drawing.Color.White;
			this.labelCardGrid.Location = new System.Drawing.Point(563, 213);
			this.labelCardGrid.Name = "labelCardGrid";
			this.labelCardGrid.Size = new System.Drawing.Size(204, 33);
			this.labelCardGrid.TabIndex = 15;
			this.labelCardGrid.Text = "Card Grid";
			this.labelCardGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMaxImages
			// 
			this.labelMaxImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMaxImages.BackColor = System.Drawing.Color.Transparent;
			this.labelMaxImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMaxImages.ForeColor = System.Drawing.Color.White;
			this.labelMaxImages.Location = new System.Drawing.Point(563, 292);
			this.labelMaxImages.Name = "labelMaxImages";
			this.labelMaxImages.Size = new System.Drawing.Size(204, 33);
			this.labelMaxImages.TabIndex = 16;
			this.labelMaxImages.Text = "Images";
			this.labelMaxImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericPairs
			// 
			this.numericPairs.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericPairs.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numericPairs.Location = new System.Drawing.Point(407, 369);
			this.numericPairs.Name = "numericPairs";
			this.numericPairs.Size = new System.Drawing.Size(59, 33);
			this.numericPairs.TabIndex = 17;
			this.numericPairs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericPairs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// labelPairs
			// 
			this.labelPairs.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelPairs.BackColor = System.Drawing.Color.Transparent;
			this.labelPairs.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPairs.ForeColor = System.Drawing.Color.White;
			this.labelPairs.Location = new System.Drawing.Point(472, 369);
			this.labelPairs.Name = "labelPairs";
			this.labelPairs.Size = new System.Drawing.Size(295, 33);
			this.labelPairs.TabIndex = 18;
			this.labelPairs.Text = "Duplicate Images";
			this.labelPairs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.BackColor = System.Drawing.Color.Teal;
			this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSave.FlatAppearance.BorderSize = 3;
			this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonSave.Location = new System.Drawing.Point(800, 486);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(148, 42);
			this.buttonSave.TabIndex = 19;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			// 
			// FormForSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPairs);
			this.Controls.Add(this.numericPairs);
			this.Controls.Add(this.labelMaxImages);
			this.Controls.Add(this.labelCardGrid);
			this.Controls.Add(this.labelImages);
			this.Controls.Add(this.numericCardGridX);
			this.Controls.Add(this.labelByCardGrid);
			this.Controls.Add(this.numericCardGridY);
			this.Controls.Add(this.labelOutOfImages);
			this.Controls.Add(this.numericMaximumImages);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormForSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap - Settings";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaximumImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardGridY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCardGridX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPairs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.NumericUpDown numericMaximumImages;
		private System.Windows.Forms.Label labelOutOfImages;
		private System.Windows.Forms.NumericUpDown numericCardGridY;
		private System.Windows.Forms.Label labelByCardGrid;
		private System.Windows.Forms.NumericUpDown numericCardGridX;
		private System.Windows.Forms.Label labelImages;
		private System.Windows.Forms.Label labelCardGrid;
		private System.Windows.Forms.Label labelMaxImages;
		private System.Windows.Forms.NumericUpDown numericPairs;
		private System.Windows.Forms.Label labelPairs;
		private System.Windows.Forms.Button buttonSave;
	}
}