using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class Card : Component
	{
		public Point Location { get; set; }
		public Color Back { get; set; }
		public Image Front { get; set; }

		public const string TURNED = "turned";
		public const string UNTURNED = "unturned";
		public static readonly Image DEFAULT = Image.FromFile(@"Assets/CardTemplate.png");
		public static readonly Image ERROR = Image.FromFile(@"Assets/CardError.png");

		public Card()
		{
			InitializeComponent();
		}

		public Card(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		public PictureBox GetAsPictureBox(bool isFirstGuess) {
			PictureBox returnButton = new()
			{
				Location = this.Location,
				BackColor = this.Back,
				Image = this.Front,
				InitialImage = Card.DEFAULT,
				ErrorImage = Card.ERROR,
				BackgroundImage = this.Front,
				Tag = Card.UNTURNED,
			};
			returnButton.Click += (object sender, EventArgs e) => {
				if ((string)(sender as PictureBox).Tag == Card.TURNED) return;

				(sender as PictureBox).InitialImage = (sender as PictureBox).BackgroundImage;

				if (!isFirstGuess)
				{
					Timer timer = new Timer { Interval = 1000, };
				}
			};
			return returnButton;
		}
	}
}
