using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class Card : PictureBox
	{
		public const string TURNED = "turned";
		public const string UNTURNED = "unturned";
		public static readonly Image DEFAULT = Properties.Resources.CardTemplate;
		public static readonly Image ERROR = Properties.Resources.CardError;

		public Image CardImage { get; set; }

		public Card()
		{
			InitializeComponent();
		}

		public Card(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
