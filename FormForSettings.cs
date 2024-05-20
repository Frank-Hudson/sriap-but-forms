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
	public partial class FormForSettings : Form
	{
		public FormForSettings()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}
	}
}
