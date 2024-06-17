
namespace SriapButForms
{
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.buttonBack = new System.Windows.Forms.Button();
			this.pictureTitle = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.inputMaxCardImages = new System.Windows.Forms.NumericUpDown();
			this.labelOutOfImages = new System.Windows.Forms.Label();
			this.inputCardsY = new System.Windows.Forms.NumericUpDown();
			this.labelByCardGrid = new System.Windows.Forms.Label();
			this.inputCardsX = new System.Windows.Forms.NumericUpDown();
			this.labelCardGrid = new System.Windows.Forms.Label();
			this.labelMaxImages = new System.Windows.Forms.Label();
			this.inputCardPairs = new System.Windows.Forms.NumericUpDown();
			this.labelPairs = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelTotalCards = new System.Windows.Forms.Label();
			this.inputCardImages = new System.Windows.Forms.NumericUpDown();
			this.labelDifficulty = new System.Windows.Forms.Label();
			this.inputDifficulty = new System.Windows.Forms.ComboBox();
			this.pictureCycLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputMaxCardImages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardPairs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardImages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).BeginInit();
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
			this.buttonBack.Click += new System.EventHandler(this.buttonBackClick);
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
			// inputMaxCardImages
			// 
			this.inputMaxCardImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputMaxCardImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputMaxCardImages.Location = new System.Drawing.Point(498, 292);
			this.inputMaxCardImages.Name = "inputMaxCardImages";
			this.inputMaxCardImages.Size = new System.Drawing.Size(59, 33);
			this.inputMaxCardImages.TabIndex = 9;
			this.inputMaxCardImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputMaxCardImages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.inputMaxCardImages.ValueChanged += new System.EventHandler(this.inputMaxCardImagesChanged);
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
			// inputCardsY
			// 
			this.inputCardsY.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardsY.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardsY.Location = new System.Drawing.Point(498, 213);
			this.inputCardsY.Name = "inputCardsY";
			this.inputCardsY.Size = new System.Drawing.Size(59, 33);
			this.inputCardsY.TabIndex = 11;
			this.inputCardsY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputCardsY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.inputCardsY.ValueChanged += new System.EventHandler(this.inputCardsYChanged);
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
			// inputCardsX
			// 
			this.inputCardsX.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardsX.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardsX.Location = new System.Drawing.Point(407, 213);
			this.inputCardsX.Name = "inputCardsX";
			this.inputCardsX.Size = new System.Drawing.Size(59, 33);
			this.inputCardsX.TabIndex = 13;
			this.inputCardsX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputCardsX.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.inputCardsX.ValueChanged += new System.EventHandler(this.inputCardsXChanged);
			// 
			// labelCardGrid
			// 
			this.labelCardGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelCardGrid.BackColor = System.Drawing.Color.Transparent;
			this.labelCardGrid.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelCardGrid.ForeColor = System.Drawing.Color.White;
			this.labelCardGrid.Location = new System.Drawing.Point(178, 213);
			this.labelCardGrid.Name = "labelCardGrid";
			this.labelCardGrid.Size = new System.Drawing.Size(204, 33);
			this.labelCardGrid.TabIndex = 15;
			this.labelCardGrid.Text = "Card Grid";
			this.labelCardGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxImages
			// 
			this.labelMaxImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMaxImages.BackColor = System.Drawing.Color.Transparent;
			this.labelMaxImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMaxImages.ForeColor = System.Drawing.Color.White;
			this.labelMaxImages.Location = new System.Drawing.Point(178, 292);
			this.labelMaxImages.Name = "labelMaxImages";
			this.labelMaxImages.Size = new System.Drawing.Size(204, 33);
			this.labelMaxImages.TabIndex = 16;
			this.labelMaxImages.Text = "Images";
			this.labelMaxImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// inputCardPairs
			// 
			this.inputCardPairs.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardPairs.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardPairs.Location = new System.Drawing.Point(407, 369);
			this.inputCardPairs.Name = "inputCardPairs";
			this.inputCardPairs.Size = new System.Drawing.Size(59, 33);
			this.inputCardPairs.TabIndex = 17;
			this.inputCardPairs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputCardPairs.Value = new decimal(new int[] {
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
			this.labelPairs.Location = new System.Drawing.Point(178, 369);
			this.labelPairs.Name = "labelPairs";
			this.labelPairs.Size = new System.Drawing.Size(204, 33);
			this.labelPairs.TabIndex = 18;
			this.labelPairs.Text = "Duplicate Images";
			this.labelPairs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.buttonSave.Click += new System.EventHandler(this.buttonSaveClick);
			// 
			// labelTotalCards
			// 
			this.labelTotalCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTotalCards.AutoSize = true;
			this.labelTotalCards.BackColor = System.Drawing.Color.Transparent;
			this.labelTotalCards.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTotalCards.ForeColor = System.Drawing.Color.White;
			this.labelTotalCards.Location = new System.Drawing.Point(575, 218);
			this.labelTotalCards.Name = "labelTotalCards";
			this.labelTotalCards.Size = new System.Drawing.Size(30, 21);
			this.labelTotalCards.TabIndex = 20;
			this.labelTotalCards.Text = "= ";
			this.labelTotalCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputCardImages
			// 
			this.inputCardImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardImages.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardImages.Location = new System.Drawing.Point(407, 292);
			this.inputCardImages.Name = "inputCardImages";
			this.inputCardImages.Size = new System.Drawing.Size(59, 33);
			this.inputCardImages.TabIndex = 21;
			this.inputCardImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputCardImages.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// labelDifficulty
			// 
			this.labelDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelDifficulty.BackColor = System.Drawing.Color.Transparent;
			this.labelDifficulty.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDifficulty.ForeColor = System.Drawing.Color.White;
			this.labelDifficulty.Location = new System.Drawing.Point(178, 448);
			this.labelDifficulty.Name = "labelDifficulty";
			this.labelDifficulty.Size = new System.Drawing.Size(204, 33);
			this.labelDifficulty.TabIndex = 22;
			this.labelDifficulty.Text = "Difficulty Mode";
			this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// inputDifficulty
			// 
			this.inputDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputDifficulty.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDifficulty.FormattingEnabled = true;
			this.inputDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Easy"});
			this.inputDifficulty.Location = new System.Drawing.Point(404, 448);
			this.inputDifficulty.Name = "inputDifficulty";
			this.inputDifficulty.Size = new System.Drawing.Size(153, 33);
			this.inputDifficulty.TabIndex = 23;
			this.inputDifficulty.Text = "Easy";
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
			this.pictureCycLogo.TabIndex = 24;
			this.pictureCycLogo.TabStop = false;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.pictureCycLogo);
			this.Controls.Add(this.inputDifficulty);
			this.Controls.Add(this.labelDifficulty);
			this.Controls.Add(this.inputCardImages);
			this.Controls.Add(this.labelTotalCards);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPairs);
			this.Controls.Add(this.inputCardPairs);
			this.Controls.Add(this.labelMaxImages);
			this.Controls.Add(this.labelCardGrid);
			this.Controls.Add(this.inputCardsX);
			this.Controls.Add(this.labelByCardGrid);
			this.Controls.Add(this.inputCardsY);
			this.Controls.Add(this.labelOutOfImages);
			this.Controls.Add(this.inputMaxCardImages);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap - Settings";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SettingsLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputMaxCardImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardPairs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.NumericUpDown inputMaxCardImages;
		private System.Windows.Forms.Label labelOutOfImages;
		private System.Windows.Forms.NumericUpDown inputCardsY;
		private System.Windows.Forms.Label labelByCardGrid;
		private System.Windows.Forms.NumericUpDown inputCardsX;
		private System.Windows.Forms.Label labelCardGrid;
		private System.Windows.Forms.Label labelMaxImages;
		private System.Windows.Forms.NumericUpDown inputCardPairs;
		private System.Windows.Forms.Label labelPairs;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelTotalCards;
		private System.Windows.Forms.NumericUpDown inputCardImages;
		private System.Windows.Forms.Label labelDifficulty;
		private System.Windows.Forms.ComboBox inputDifficulty;
		private System.Windows.Forms.PictureBox pictureCycLogo;
	}
}