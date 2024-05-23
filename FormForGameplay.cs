﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class FormForGameplay : Form
	{
		// ---- Before the concept of this game ---- //

		const int PAIRS = 2;

		// ---- Formstuffs ---- //

		static readonly Form FormOfLatestFocus = Form.ActiveForm;

		// ---- CONSTANTS ---- //

		const int IMAGE_COUNT = 10;
		
		const int CARD_ROWS = 4;
		const int CARD_COLUMNS = 4;
		const int CARD_COUNT = CARD_ROWS * CARD_COLUMNS;
		const int PAIR_COUNT = CARD_COUNT / PAIRS;

		const int CARD_WIDTH = 158;
		const int CARD_HEIGHT = 202;
		
		const int CARD_DISTANCE_HORIZONTAL = 25;
		const int CARD_DISTANCE_VERTICAL = 15;

		const int POINTS_FOR_A_MATCH = 3;

		const int CARD_TURNED_PAUSE = 500;

		// ---- Images ---- //

		readonly Image[] CardImages = new Image[IMAGE_COUNT];
		
		// ---- Cards ---- //

		readonly Color CARD_COLOUR = Color.FromArgb(0x00, 0xED, 0xF2);
		readonly Card[] CardComponents = new Card[CARD_COUNT];
		Point CARD_0_LOCATION;
		Card FirstTurned;

		// ---- Gameplay ---- //

		bool IsFirstGuess = true;
		int PlayerScore = 0;
		int Guesses = 0;
		int CorrectGuesses = 0;

		// ---- #### ---- METHODS ---- #### ---- //

		public FormForGameplay()
		{
			InitializeComponent();
		}

		void UpdatePlayerScore(int value)
		{
			PlayerScore += value;
			labelScore.Text = $"Score {PlayerScore}";
		}

		void BroadcastWin(int score, bool win)
		{
			FormForGameplayFinish formGameplayFinish = new(score, win);
			if (formGameplayFinish.ShowDialog() == DialogResult.Retry) SetupGameplay(new());
		}

		Point GetCardLocation(int index)
		{
			int row = (index / CARD_COLUMNS) + 1;
			int column = (index % CARD_COLUMNS) + 1;

			//appLog.LogFill($"Card {index + 1} gridpos: {row}, {column}");

			return new Point(
				CARD_0_LOCATION.X + ((CARD_WIDTH + CARD_DISTANCE_HORIZONTAL) * row) - CARD_WIDTH,
				CARD_0_LOCATION.Y + ((CARD_HEIGHT + CARD_DISTANCE_VERTICAL) * column) - CARD_HEIGHT
			);
		}

		void SetupGameplay(Random randomGenerator)
		{
			PlayerScore = 0;
			labelScore.Text = $"Score {PlayerScore}";
			Guesses = 0;
			CorrectGuesses = 0;

			int firstExcludedImageIndex = randomGenerator.Next(IMAGE_COUNT) + 1;
			int[] remainingImages = Enumerable.Range(1, IMAGE_COUNT)
				.Where(numberItem => numberItem != firstExcludedImageIndex).ToArray();
			int secondExcludedImageIndex = remainingImages[randomGenerator.Next(IMAGE_COUNT - 1)];
			int[] usableImageIndices = remainingImages
				.Where((numberItem, index) => numberItem != secondExcludedImageIndex).ToArray();

			List<int> usableImages = usableImageIndices.Concat(usableImageIndices).ToList();
			List<int> usedImages = new(CARD_COUNT);

			for (int i = 0; i < CARD_COUNT; i++)
			{
				int currentImageIndex = randomGenerator.Next(0, usableImages.Count);
				usedImages.Add(usableImages[currentImageIndex] + 1);

				Point cardLocation = GetCardLocation(i);

				CardComponents[i] = new()
				{
					Location = cardLocation,
					Size = new(CARD_WIDTH, CARD_HEIGHT),
					BackColor = CARD_COLOUR,
					CardImage = CardImages[usableImages[currentImageIndex] - 1],
					InitialImage = Card.DEFAULT,
					ErrorImage = Card.ERROR,
					BackgroundImageLayout = ImageLayout.Center,
					Anchor = AnchorStyles.None,
					Cursor = Cursors.Hand,
					Tag = $"{usableImages[currentImageIndex] + 1}",
					Name = $"Card {i + 1}",
					Parent = this,
				};
				CardComponents[i].Click += new EventHandler(card_Click);
				CardComponents[i].Show();

				usableImages.RemoveAt(currentImageIndex);
			}
		}

		private void FormForGameplay_Load(object sender, EventArgs e)
		{
			Random randomGenerator = new();

			appLog.output = new();

			appLog.LogFill($"Window: {Size.Width} x {Size.Height}");

			CARD_0_LOCATION = new(
				(Size.Width / 2) - ((CARD_WIDTH + CARD_DISTANCE_HORIZONTAL) * 2),
				pictureTitle.Height
			);

			appLog.LogFill($"Card scale: {CARD_WIDTH} x {CARD_HEIGHT}");

			for (int i = 0; i < IMAGE_COUNT; i++)
			{
				CardImages[i] = Image.FromFile($"Assets/Card{i + 1}.png");
			}

			SetupGameplay(randomGenerator);
		}

		private void card_Click(object sender, EventArgs e)
		{
			Card clickedCard = sender as Card;

			string tags = (string)clickedCard.Tag;

			appLog.LogFill($"Tag: {tags}, Turned?: {clickedCard.IsTurned}");

			if (clickedCard.IsTurned) return;
			else clickedCard.IsTurned = true;

			clickedCard.Image = clickedCard.CardImage;

			Timer timer = new() { Interval = 1000, };
			timer.Start();

			Guesses++;

			if (!IsFirstGuess)
			{
				// #### 2nd guess ####

				PublicItems.Wait(CARD_TURNED_PAUSE);

				if (tags == (string)FirstTurned.Tag)
				{
					// ## Cards match ##

					appLog.LogFill("Cards MATCH!", LogLevel.Info);

					CorrectGuesses++;

					clickedCard.Hide();
					clickedCard.IsTurned = false;
					FirstTurned.Hide();
					FirstTurned.IsTurned = false;

					UpdatePlayerScore(POINTS_FOR_A_MATCH);

					if (CorrectGuesses >= PAIR_COUNT)
					{
						BroadcastWin(PlayerScore, true);
					}
				}
				else
				{
					// ## Cards don't match ##

					appLog.LogFill("Cards DON'T MATCH!", LogLevel.Info);

					clickedCard.Image = null;
					FirstTurned.Image = null;
				}

				clickedCard.IsTurned = false;
				FirstTurned.IsTurned = false;
				IsFirstGuess = true;
			}
			else
			{
				// #### 1st guess ####

				appLog.LogFill("1st guess!", LogLevel.Info);

				FirstTurned = clickedCard;
				IsFirstGuess = false;
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			PublicItems.Quit(sender, e);
		}
	}
}
