using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class Card : PictureBox
	{
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
	}
}
