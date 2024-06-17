
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
			this.inputLoadedImages = new System.Windows.Forms.NumericUpDown();
			this.labelOutOfImages = new System.Windows.Forms.Label();
			this.inputCardsY = new System.Windows.Forms.NumericUpDown();
			this.labelByCardGrid = new System.Windows.Forms.Label();
			this.inputCardsX = new System.Windows.Forms.NumericUpDown();
			this.labelCardGrid = new System.Windows.Forms.Label();
			this.labelMaxImages = new System.Windows.Forms.Label();
			this.inputDuplicates = new System.Windows.Forms.NumericUpDown();
			this.labelPairs = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.infoTotalCards = new System.Windows.Forms.Label();
			this.inputUsedImages = new System.Windows.Forms.NumericUpDown();
			this.labelDifficulty = new System.Windows.Forms.Label();
			this.inputDifficulty = new System.Windows.Forms.ComboBox();
			this.pictureCycLogo = new System.Windows.Forms.PictureBox();
			this.outputValid = new System.Windows.Forms.Label();
			this.labelValid = new System.Windows.Forms.Label();
			this.infoImages = new System.Windows.Forms.Label();
			this.infoValid = new System.Windows.Forms.Label();
			this.infoValidRule = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputLoadedImages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputDuplicates)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputUsedImages)).BeginInit();
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
			this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonBack.Location = new System.Drawing.Point(12, 471);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(120, 35);
			this.buttonBack.TabIndex = 6;
			this.buttonBack.Text = "Close";
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
			this.pictureTitle.Size = new System.Drawing.Size(458, 110);
			this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureTitle.TabIndex = 6;
			this.pictureTitle.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(176, 113);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(116, 27);
			this.labelTitle.TabIndex = 8;
			this.labelTitle.Text = "Settings";
			// 
			// inputLoadedImages
			// 
			this.inputLoadedImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputLoadedImages.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputLoadedImages.Location = new System.Drawing.Point(280, 220);
			this.inputLoadedImages.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
			this.inputLoadedImages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputLoadedImages.Name = "inputLoadedImages";
			this.inputLoadedImages.Size = new System.Drawing.Size(59, 27);
			this.inputLoadedImages.TabIndex = 3;
			this.inputLoadedImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputLoadedImages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.inputLoadedImages.ValueChanged += new System.EventHandler(this.inputLoadedImagesChanged);
			// 
			// labelOutOfImages
			// 
			this.labelOutOfImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelOutOfImages.AutoSize = true;
			this.labelOutOfImages.BackColor = System.Drawing.Color.Transparent;
			this.labelOutOfImages.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelOutOfImages.ForeColor = System.Drawing.Color.White;
			this.labelOutOfImages.Location = new System.Drawing.Point(260, 230);
			this.labelOutOfImages.Name = "labelOutOfImages";
			this.labelOutOfImages.Size = new System.Drawing.Size(14, 16);
			this.labelOutOfImages.TabIndex = 10;
			this.labelOutOfImages.Text = "/";
			this.labelOutOfImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputCardsY
			// 
			this.inputCardsY.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardsY.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardsY.Location = new System.Drawing.Point(280, 171);
			this.inputCardsY.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
			this.inputCardsY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputCardsY.Name = "inputCardsY";
			this.inputCardsY.Size = new System.Drawing.Size(59, 27);
			this.inputCardsY.TabIndex = 1;
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
			this.labelByCardGrid.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelByCardGrid.ForeColor = System.Drawing.Color.White;
			this.labelByCardGrid.Location = new System.Drawing.Point(260, 181);
			this.labelByCardGrid.Name = "labelByCardGrid";
			this.labelByCardGrid.Size = new System.Drawing.Size(14, 16);
			this.labelByCardGrid.TabIndex = 12;
			this.labelByCardGrid.Text = "x";
			this.labelByCardGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputCardsX
			// 
			this.inputCardsX.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputCardsX.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputCardsX.Location = new System.Drawing.Point(195, 171);
			this.inputCardsX.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
			this.inputCardsX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputCardsX.Name = "inputCardsX";
			this.inputCardsX.Size = new System.Drawing.Size(59, 27);
			this.inputCardsX.TabIndex = 0;
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
			this.labelCardGrid.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelCardGrid.ForeColor = System.Drawing.Color.White;
			this.labelCardGrid.Location = new System.Drawing.Point(25, 171);
			this.labelCardGrid.Name = "labelCardGrid";
			this.labelCardGrid.Size = new System.Drawing.Size(158, 27);
			this.labelCardGrid.TabIndex = 15;
			this.labelCardGrid.Text = "Card Grid";
			this.labelCardGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaxImages
			// 
			this.labelMaxImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMaxImages.BackColor = System.Drawing.Color.Transparent;
			this.labelMaxImages.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMaxImages.ForeColor = System.Drawing.Color.White;
			this.labelMaxImages.Location = new System.Drawing.Point(25, 220);
			this.labelMaxImages.Name = "labelMaxImages";
			this.labelMaxImages.Size = new System.Drawing.Size(158, 27);
			this.labelMaxImages.TabIndex = 16;
			this.labelMaxImages.Text = "Images";
			this.labelMaxImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// inputDuplicates
			// 
			this.inputDuplicates.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputDuplicates.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDuplicates.Location = new System.Drawing.Point(195, 273);
			this.inputDuplicates.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.inputDuplicates.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputDuplicates.Name = "inputDuplicates";
			this.inputDuplicates.Size = new System.Drawing.Size(59, 27);
			this.inputDuplicates.TabIndex = 4;
			this.inputDuplicates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputDuplicates.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputDuplicates.ValueChanged += new System.EventHandler(this.inputDuplicatesChanged);
			// 
			// labelPairs
			// 
			this.labelPairs.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelPairs.BackColor = System.Drawing.Color.Transparent;
			this.labelPairs.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPairs.ForeColor = System.Drawing.Color.White;
			this.labelPairs.Location = new System.Drawing.Point(25, 273);
			this.labelPairs.Name = "labelPairs";
			this.labelPairs.Size = new System.Drawing.Size(158, 27);
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
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.buttonSave.Location = new System.Drawing.Point(330, 471);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(120, 35);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSaveClick);
			// 
			// infoTotalCards
			// 
			this.infoTotalCards.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.infoTotalCards.AutoSize = true;
			this.infoTotalCards.BackColor = System.Drawing.Color.Transparent;
			this.infoTotalCards.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.infoTotalCards.ForeColor = System.Drawing.Color.Silver;
			this.infoTotalCards.Location = new System.Drawing.Point(345, 181);
			this.infoTotalCards.Name = "infoTotalCards";
			this.infoTotalCards.Size = new System.Drawing.Size(21, 16);
			this.infoTotalCards.TabIndex = 20;
			this.infoTotalCards.Text = "= ";
			this.infoTotalCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputUsedImages
			// 
			this.inputUsedImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputUsedImages.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputUsedImages.Location = new System.Drawing.Point(195, 220);
			this.inputUsedImages.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
			this.inputUsedImages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.inputUsedImages.Name = "inputUsedImages";
			this.inputUsedImages.Size = new System.Drawing.Size(59, 27);
			this.inputUsedImages.TabIndex = 2;
			this.inputUsedImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputUsedImages.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.inputUsedImages.ValueChanged += new System.EventHandler(this.inputUsedImagesChanged);
			// 
			// labelDifficulty
			// 
			this.labelDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelDifficulty.BackColor = System.Drawing.Color.Transparent;
			this.labelDifficulty.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDifficulty.ForeColor = System.Drawing.Color.White;
			this.labelDifficulty.Location = new System.Drawing.Point(25, 422);
			this.labelDifficulty.Name = "labelDifficulty";
			this.labelDifficulty.Size = new System.Drawing.Size(158, 27);
			this.labelDifficulty.TabIndex = 22;
			this.labelDifficulty.Text = "Difficulty Mode";
			this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// inputDifficulty
			// 
			this.inputDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.inputDifficulty.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDifficulty.FormattingEnabled = true;
			this.inputDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Easy"});
			this.inputDifficulty.Location = new System.Drawing.Point(192, 422);
			this.inputDifficulty.Name = "inputDifficulty";
			this.inputDifficulty.Size = new System.Drawing.Size(153, 27);
			this.inputDifficulty.TabIndex = 5;
			this.inputDifficulty.Text = "Easy";
			// 
			// pictureCycLogo
			// 
			this.pictureCycLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureCycLogo.ErrorImage = global::SriapButForms.Properties.Resources.CardError;
			this.pictureCycLogo.Image = global::SriapButForms.Properties.Resources.coleg_y_cymoedd_icon_arch_green_on_black;
			this.pictureCycLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureCycLogo.Name = "pictureCycLogo";
			this.pictureCycLogo.Size = new System.Drawing.Size(52, 52);
			this.pictureCycLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureCycLogo.TabIndex = 24;
			this.pictureCycLogo.TabStop = false;
			// 
			// outputValid
			// 
			this.outputValid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.outputValid.AutoSize = true;
			this.outputValid.BackColor = System.Drawing.Color.Transparent;
			this.outputValid.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.outputValid.ForeColor = System.Drawing.Color.White;
			this.outputValid.Location = new System.Drawing.Point(195, 325);
			this.outputValid.Name = "outputValid";
			this.outputValid.Size = new System.Drawing.Size(70, 16);
			this.outputValid.TabIndex = 25;
			this.outputValid.Text = "<isValid>";
			this.outputValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelValid
			// 
			this.labelValid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelValid.BackColor = System.Drawing.Color.Transparent;
			this.labelValid.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelValid.ForeColor = System.Drawing.Color.White;
			this.labelValid.Location = new System.Drawing.Point(25, 318);
			this.labelValid.Name = "labelValid";
			this.labelValid.Size = new System.Drawing.Size(158, 27);
			this.labelValid.TabIndex = 26;
			this.labelValid.Text = "Duplicate Images";
			this.labelValid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// infoImages
			// 
			this.infoImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.infoImages.AutoSize = true;
			this.infoImages.BackColor = System.Drawing.Color.Transparent;
			this.infoImages.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.infoImages.ForeColor = System.Drawing.Color.Silver;
			this.infoImages.Location = new System.Drawing.Point(345, 230);
			this.infoImages.Name = "infoImages";
			this.infoImages.Size = new System.Drawing.Size(84, 16);
			this.infoImages.TabIndex = 27;
			this.infoImages.Text = "used/loaded";
			this.infoImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// infoValid
			// 
			this.infoValid.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.infoValid.AutoSize = true;
			this.infoValid.BackColor = System.Drawing.Color.Transparent;
			this.infoValid.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.infoValid.ForeColor = System.Drawing.Color.Silver;
			this.infoValid.Location = new System.Drawing.Point(77, 345);
			this.infoValid.Name = "infoValid";
			this.infoValid.Size = new System.Drawing.Size(322, 32);
			this.infoValid.TabIndex = 28;
			this.infoValid.Text = "Total Cards must be divisible by Used Images \r\nmultiplied by Duplicates exactly o" +
    "nce";
			this.infoValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// infoValidRule
			// 
			this.infoValidRule.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.infoValidRule.BackColor = System.Drawing.Color.Transparent;
			this.infoValidRule.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.infoValidRule.ForeColor = System.Drawing.Color.Gray;
			this.infoValidRule.Location = new System.Drawing.Point(67, 386);
			this.infoValidRule.Name = "infoValidRule";
			this.infoValidRule.Size = new System.Drawing.Size(337, 16);
			this.infoValidRule.TabIndex = 29;
			this.infoValidRule.Text = "cards / (images * duplicates) = x remainder y";
			this.infoValidRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(458, 518);
			this.Controls.Add(this.infoValidRule);
			this.Controls.Add(this.infoValid);
			this.Controls.Add(this.infoImages);
			this.Controls.Add(this.labelValid);
			this.Controls.Add(this.outputValid);
			this.Controls.Add(this.pictureCycLogo);
			this.Controls.Add(this.inputDifficulty);
			this.Controls.Add(this.labelDifficulty);
			this.Controls.Add(this.inputUsedImages);
			this.Controls.Add(this.infoTotalCards);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPairs);
			this.Controls.Add(this.inputDuplicates);
			this.Controls.Add(this.labelMaxImages);
			this.Controls.Add(this.labelCardGrid);
			this.Controls.Add(this.inputCardsX);
			this.Controls.Add(this.labelByCardGrid);
			this.Controls.Add(this.inputCardsY);
			this.Controls.Add(this.labelOutOfImages);
			this.Controls.Add(this.inputLoadedImages);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.pictureTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sriap - Settings";
			this.Load += new System.EventHandler(this.SettingsLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputLoadedImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputCardsX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputDuplicates)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputUsedImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureCycLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.PictureBox pictureTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.NumericUpDown inputLoadedImages;
		private System.Windows.Forms.Label labelOutOfImages;
		private System.Windows.Forms.NumericUpDown inputCardsY;
		private System.Windows.Forms.Label labelByCardGrid;
		private System.Windows.Forms.NumericUpDown inputCardsX;
		private System.Windows.Forms.Label labelCardGrid;
		private System.Windows.Forms.Label labelMaxImages;
		private System.Windows.Forms.NumericUpDown inputDuplicates;
		private System.Windows.Forms.Label labelPairs;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label infoTotalCards;
		private System.Windows.Forms.NumericUpDown inputUsedImages;
		private System.Windows.Forms.Label labelDifficulty;
		private System.Windows.Forms.ComboBox inputDifficulty;
		private System.Windows.Forms.PictureBox pictureCycLogo;
		private System.Windows.Forms.Label outputValid;
		private System.Windows.Forms.Label labelValid;
		private System.Windows.Forms.Label infoImages;
		private System.Windows.Forms.Label infoValid;
		private System.Windows.Forms.Label infoValidRule;
	}
}