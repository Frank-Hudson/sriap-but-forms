using System;
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
	public partial class Gameplay : Form
	{
		// ---- CONSTANTS ---- //

		const int CARD_WIDTH = 158;
		const int CARD_HEIGHT = 202;

		const int CARD_DISTANCE_HORIZONTAL = 25;
		const int CARD_DISTANCE_VERTICAL = 15;

		const int CARD_TURNED_PAUSE = 500;

		const int POINTS_FOR_PAIR_MATCH = 3;

		// ---- Settings ---- //

		static readonly int CardRows = PublicItems.formSettings.SettingsData.cardgrid.x;
		static readonly int CardColumns = PublicItems.formSettings.SettingsData.cardgrid.y;

		static readonly int ImageCount = PublicItems.formSettings.SettingsData.images.total;

		static readonly int Pairs = PublicItems.formSettings.SettingsData.duplicates;


		static readonly int CardCount = CardRows * CardColumns;
		static readonly int PairCount = CardCount / Pairs;

		// ---- VARIABLES ---- //

		readonly Image[] CardImages = new Image[ImageCount];

		readonly Color CARD_COLOUR = Color.FromArgb(0x00, 0xED, 0xF2);

		readonly Card[] CardComponents = new Card[CardCount];

		Point CARD_0_LOCATION;

		Card FirstTurned;

		bool IsFirstGuess = true;
		int Guesses = 0;
		int CorrectGuesses = 0;

		int PlayerScore = 0;

		readonly Timer GameTimer = new() { Interval = 1000, };
		TimeSpan GameLength = TimeSpan.FromMinutes(1); // TODO: Difficulties; Easy 2m, Hard 1m

		readonly Timer CardTimer = new() { Interval = 1000, };

		// ---- #### ---- METHODS ---- #### ---- //

		public Gameplay()
		{
			InitializeComponent();

			GameTimer.Tick += delegate
			{
				GameLength -= TimeSpan.FromMilliseconds(GameTimer.Interval);

				string timerString = GameLength.ToString(@"mm\:ss");

				labelTimeRemaining.Text = timerString;

				if (GameLength.Ticks < TimeSpan.TicksPerSecond)
				{
					GameTimer.Stop();
					BroadcastOutcome(PlayerScore, PlayerScore == CardCount * POINTS_FOR_PAIR_MATCH);
				}
			};
		}

		void IncreasePlayerScore(int value)
		{
			PlayerScore += value;
			labelScore.Text = $"Score {PlayerScore}";
		}

		void UpdateRemainingCards()
		{
			labelCardsRemaining.Text = $"Cards: {CardCount - CorrectGuesses * 2}";
		}

		void BroadcastOutcome(int score, bool win)
		{
			GameOutcome formGameplayFinish = new(score, win);
			switch (formGameplayFinish.ShowDialog())
			{
				case DialogResult.Retry: Setup(); break;
				case DialogResult.Abort: buttonBack.PerformClick(); break;
			}
		}

		Point GetCardLocation(int index)
		{
			int row = (index / CardColumns) + 1;
			int column = (index % CardColumns) + 1;

			return new Point(
				CARD_0_LOCATION.X + ((CARD_WIDTH + CARD_DISTANCE_HORIZONTAL) * row) - CARD_WIDTH,
				CARD_0_LOCATION.Y + ((CARD_HEIGHT + CARD_DISTANCE_VERTICAL) * column) - CARD_HEIGHT
			);
		}

		// ---- SETUP ---- //

		void Setup()
		{
			Random randomGenerator = new();

			PlayerScore = 0;
			labelScore.Text = $"Score {PlayerScore}";

			Guesses = 0;
			CorrectGuesses = 0;

			UpdateRemainingCards();

			GameLength = TimeSpan.FromMinutes(1);
			labelTimeRemaining.Text = "--:--";

			int firstExcludedImageIndex = randomGenerator.Next(ImageCount) + 1;
			int[] remainingImages = Enumerable.Range(1, ImageCount)
				.Where(numberItem => numberItem != firstExcludedImageIndex).ToArray();
			int secondExcludedImageIndex = remainingImages[randomGenerator.Next(ImageCount - 1)];
			int[] usableImageIndices = remainingImages
				.Where((numberItem, index) => numberItem != secondExcludedImageIndex).ToArray();

			List<int> usableImages = usableImageIndices.Concat(usableImageIndices).ToList();
			List<int> usedImages = new(CardCount);

			for (int i = 0; i < CardCount; i++)
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
				CardComponents[i].Click += new EventHandler(CardClick);
				CardComponents[i].Show();

				usableImages.RemoveAt(currentImageIndex);
			}
		}

		private void FormGameplayLoad(object sender, EventArgs e)
		{
			CARD_0_LOCATION = new(
				(Size.Width / 2) - ((CARD_WIDTH + CARD_DISTANCE_HORIZONTAL) * 2),
				pictureTitle.Height
			);

			for (int i = 0; i < ImageCount; i++)
			{
				CardImages[i] = Image.FromFile($"Assets/Card{i + 1}.png");
			}

			Setup();
		}

		// ---- GAME ---- //

		private void CardClick(object sender, EventArgs e)
		{
			if (!GameTimer.Enabled)
			{
				GameTimer.Start();
			}
			CardTimer.Start();

			Card clickedCard = sender as Card;
			string tags = (string)clickedCard.Tag;

			if (clickedCard.IsTurned) return;
			else clickedCard.IsTurned = true;

			clickedCard.Image = clickedCard.CardImage;

			Guesses++;

			if (IsFirstGuess)
			{
				// # 1st guess #

				FirstTurned = clickedCard;
				IsFirstGuess = false;
			}
			else
			{
				// # 2nd guess #

				CardTimer.Stop();

				if (tags == (string)FirstTurned.Tag)
				{
					// ## Cards match ##

					CorrectGuesses++;
					UpdateRemainingCards();
					IncreasePlayerScore(POINTS_FOR_PAIR_MATCH);

					PublicItems.Wait(CARD_TURNED_PAUSE);

					clickedCard.Hide();
					FirstTurned.Hide();

					if (CorrectGuesses == PairCount)
					{
						GameTimer.Stop();
						BroadcastOutcome(PlayerScore, true);
					}
				}
				else
				{
					// ## Cards don't match ##

					PublicItems.Wait(CARD_TURNED_PAUSE);

					clickedCard.Image = null;
					FirstTurned.Image = null;
				}

				clickedCard.IsTurned = false;
				FirstTurned.IsTurned = false;
				IsFirstGuess = true;
			}
		}

		// ---- UI Navigation ---- //

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
