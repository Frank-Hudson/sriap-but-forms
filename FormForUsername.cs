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
	public partial class FormForUsername : Form
	{
		public FormForUsername()
		{
			InitializeComponent();
			inputUsername.Height = 26;
			Location += new Size(0, 20);
		}

		public string GetUsername() { return inputUsername.Text; }

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (
				(string.IsNullOrEmpty(inputUsername.Text) || string.IsNullOrWhiteSpace(inputUsername.Text)) &&
				MessageBox.Show("Are you sure you don't want to save a username with your score?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No
			) return;
			this.Close();
		}
	}
}
