using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		const int POINTS_FOR_PAIR_MATCH = 5;

		// ---- Settings ---- //

		static readonly int CardRows = PublicItems.formSettings.SettingsData.cardgrid.x;
		static readonly int CardColumns = PublicItems.formSettings.SettingsData.cardgrid.y;

		static readonly int ImageCount = PublicItems.formSettings.SettingsData.images.total;

		static readonly int Pairs = PublicItems.formSettings.SettingsData.duplicates;

		static readonly TimeSpan GameLength = TimeSpan.FromSeconds(60); // TimeSpan.FromSeconds(PublicItems.formSettings.SettingsData.time);


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

		public string Username;

		readonly Timer GameTimer = new() { Interval = 1000, };
		TimeSpan GameTime = GameLength; // TODO: Difficulties; Easy 60s, Hard 30s

		readonly Timer CardTimer = new() { Interval = 1000, };

		// ---- #### ---- METHODS ---- #### ---- //

		public Gameplay()
		{
			InitializeComponent();

			GameTimer.Tick += new EventHandler(GameTimerTick);
		}

		void GameTimerTick(object sender, EventArgs e)
		{
			GameTime -= TimeSpan.FromMilliseconds(GameTimer.Interval);

			string timerString = GameTime.ToString(@"mm\:ss");

			labelTimeRemaining.Text = timerString;

			if (GameTime.Ticks < TimeSpan.TicksPerSecond)
			{
				GameTimer.Stop();
				BroadcastOutcome(PlayerScore == CardCount * POINTS_FOR_PAIR_MATCH);
			}
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

		void BroadcastOutcome(bool win)
		{
			labelStatus.Text = win ? "YOU WIN!" : "YOU LOSE!"; 
			labelScoreResult.Text = labelScore.Text;
			labelTimeResult.Text = $"{GameLength - GameTime:mm':'ss}";
			panelOutcome.Show();
		}

		private void OutcomeClosed(object sender, EventArgs e)
		{
			var outcomeCloser = (sender as Button); 
			switch (outcomeCloser.Text)
			{
				case "Replay": Setup(); break;
			}
		}

		private void ButtonSaveScoreClicked(object sender, EventArgs e)
		{
			Username formUsername = new();
			formUsername.ShowDialog();
			Username = formUsername.GetUsername();
			StreamWriter streamWriter = File.AppendText("Data/scores.txt");
			streamWriter.WriteLine($"{PlayerScore} ({labelTimeResult.Text}) {Username}");
			streamWriter.Close();
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
			panelOutcome.Hide(); 	

			PlayerScore = 0;
			labelScore.Text = $"Score {PlayerScore}";

			Guesses = 0;
			CorrectGuesses = 0;

			UpdateRemainingCards();

			GameTime = GameLength;
			labelTimeRemaining.Text = "--:--";

			Random random = new();

			/* --repetition-- {{ */

			// Generate an index for the first image to be removed from the
			// ones used
			int firstExcludedImageIndex = random.Next(ImageCount) + 1;
			// Create a sequence with all numbers from 1 to the Image Count to
			// represent the indices of the images
			int[] remainingImageIndices = Enumerable.Range(1, ImageCount)
				// Filter out the initial excluded image
				.Where(numberItem => numberItem != firstExcludedImageIndex)
				// Transform the IEnumerable result into an array
				.ToArray();

			// TODO: ˄˄ Could be a loop? ˅˅

			// Generate a second excluded image index, this time up to one less
			// than before, due to the previous removal
			int secondExcludedImageIndex = remainingImageIndices[random.Next(ImageCount - 1)];
			// Once again, remove the excluded index from the final list of
			// image indices
			int[] usableImageIndices = remainingImageIndices
				.Where((numberItem, index) => numberItem != secondExcludedImageIndex)
				.ToArray();

			/* }} --repetition-- */

			List<int> usableImages = usableImageIndices
				.Concat(usableImageIndices)
				.ToList();
			List<int> usedImages = new(CardCount);

			for (int i = 0; i < CardCount; i++)
			{
				int currentImageIndex = random.Next(0, usableImages.Count);

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
				labelTimeRemaining.Text = $"01:00";
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
						BroadcastOutcome(true);
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
