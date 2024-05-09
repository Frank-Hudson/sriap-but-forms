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
		const int CARD_WIDTH = 158;
		const int CARD_HEIGHT = 202;
		const int CARD_DISTANCE = 10;

		// ---- Images ---- //

		readonly Image[] CardImages = new Image[IMAGE_COUNT];
		readonly Image[] IncludedImages = new Image[CARD_COUNT / PAIRS];
		int[] SelectedImages = new int[CARD_COUNT];

		// ---- Cards ---- //

		readonly Color CARD_COLOUR = Color.FromArgb(0x00, 0xED, 0xF2);
		readonly Card[] CardComponents = new Card[CARD_COUNT];
		Point CARD_0_LOCATION;

		// ---- Gameplay ---- //

		bool IsFirstGuess = true;

		// ---- buttonQuit ---- //

		readonly FontFamily QuitFontFamily = new("JetBrains Mono");
		readonly FontStyle QuitFontStyle = FontStyle.Italic;
		int QuitCount = 0;

		// ---- #### ---- METHODS ---- #### ---- //

		public FormForGameplay()
		{
			InitializeComponent();
		}

		Point GetCardLocation(int index)
		{
			int row = (index / CARD_COLUMNS) + 1;
			int column = (index % CARD_COLUMNS) + 1;

			//appLog.LogFill($"Card {index + 1} gridpos: {row}, {column}");

			return new Point(
				CARD_0_LOCATION.X + ((CARD_WIDTH + CARD_DISTANCE) * row),
				CARD_0_LOCATION.Y + ((CARD_HEIGHT + CARD_DISTANCE) * column)
			);
		}

		private void FormForGameplay_Load(object sender, EventArgs e)
		{
			Random randomGenerator = new();

			appLog.output = listBoxLog;

			CARD_0_LOCATION = new((Size.Width / 2) - ((CARD_WIDTH + CARD_DISTANCE) * 2), 5);

			appLog.LogFill($"Card scale: {CARD_WIDTH} x {CARD_HEIGHT}");

			for (int i = 0; i < IMAGE_COUNT; i++)
			{
				CardImages[i] = Image.FromFile($"Assets/Card{i + 1}.png");
			}

			for (int i = 0; i < CARD_COUNT; i++)
			{
				int[] unselectedImages = Enumerable.Range(0, IMAGE_COUNT)
					// Find each from SelectedImages occurring twice and check if `i` is one
					.Where(i => !(SelectedImages
						.GroupBy(i2 => i2)
						.Where(i2 => i2.Count() >= PAIRS)
						.Select(i2 => i2.First()).Contains(i)))
					.ToArray();
				int unselectedImageIndex = randomGenerator.Next(0, unselectedImages.Count());
				int cardImageIndex = unselectedImages.ElementAt(unselectedImageIndex);
				SelectedImages[i] = unselectedImageIndex + 1;

				appLog.LogFill($"Unselected: {string.Join(',', unselectedImages)}");
				appLog.LogFill($"Selected: {string.Join(',', SelectedImages)}");

				Point cardLocation = GetCardLocation(i);

				//appLog.LogFill($"Card {i + 1} pos: ({cardLocation.X}, {cardLocation.Y})");

				CardComponents[i] = new()
				{
					Location = cardLocation,
					Size = new(CARD_WIDTH, CARD_HEIGHT),
					//BackColor = CARD_COLOUR,
					Image = CardImages[cardImageIndex],
					InitialImage = Card.DEFAULT,
					ErrorImage = Card.ERROR,
					Anchor = AnchorStyles.None,
					Tag = Card.UNTURNED,
					Name = $"Card {i + 1}",
					Parent = this,
				};
				CardComponents[i].Click += new EventHandler(this.card_Click);
				CardComponents[i].Show();
			}
		}

		private void card_Click(object sender, EventArgs e) {
			if ((string)(sender as Card).Tag == Card.TURNED) return;

			(sender as Card).InitialImage = (sender as Card).BackgroundImage;

			if (!IsFirstGuess)
			{
				Timer timer = new Timer { Interval = 1000, };
			}

			IsFirstGuess = false;
			appLog.LogFill($"Card {(sender as Card).Name} clicked");
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			switch (QuitCount)
			{
				case 0:
					buttonQuit.Font = new(QuitFontFamily, 9, QuitFontStyle);
					buttonQuit.Text = "Let me leave";
					QuitCount++;
					break;
				case 2:
					buttonQuit.Font = new(QuitFontFamily, 8, QuitFontStyle);
					buttonQuit.Text = "Let Me Push The Frickin' Button!";
					QuitCount++;
					break;
				default:
					AutoClosingMessageBox.Show("Good bye.", timeout: 900);
					Application.Exit();
					break;
			}
		}
	}
}
