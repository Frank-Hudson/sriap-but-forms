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
	public partial class formforGameplay : Form
	{
		readonly Form FormOflatestFocus = Form.ActiveForm;

		const int IMAGE_COUNT = 10;
		const int CARD_ROWS = 4;
		const int CARD_COLUMNS = 4;
		const int CARD_COUNT = CARD_ROWS * CARD_COLUMNS;
		const int CARD_WIDTH = 158;
		const int CARD_HEIGHT = 202;
		const int CARD_DISTANCE = 10;

		readonly Color CARD_COLOUR = Color.FromArgb(0x00, 0xED, 0xF2);
		readonly Image[] CardImages = new Image[IMAGE_COUNT];
		int[] SelectedImages = new int[IMAGE_COUNT];
		readonly Card[] CardComponents = new Card[CARD_COUNT];
		readonly Point CARD_0_LOCATION = new(5, 5);
		

		public formforGameplay()
		{
			InitializeComponent();
		}

		private int GetRandomCardImageIndex()
		{
			Random rnd = new();
			int i = rnd.Next(0, IMAGE_COUNT - 1);
			if (SelectedImages.Contains(i)) return GetRandomCardImageIndex();
			SelectedImages = SelectedImages.Append(i).ToArray();
			return i;
		}

		private void formforGameplay_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < IMAGE_COUNT; i++)
			{
				CardImages[i] = Image.FromFile($"Assets/Card{i + 1}.png");
			}

			for (int i = 0; i < CARD_COUNT; i++)
			{
				int cardImageIndex = GetRandomCardImageIndex();

				CardComponents[i] = new()
				{
					Location = CARD_0_LOCATION + new Size(CARD_DISTANCE, 0),
					Back = CARD_COLOUR,
					Front = CardImages[cardImageIndex],
				};
			}
		}
	}
}
