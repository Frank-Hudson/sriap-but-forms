using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	class PublicItems
	{
		public static FormForStartMenu formStart = new();
		public static FormForGameplay formGameplay = new();
		public static FormForHighScores formHighScores = new();


		public static void Quit(object sender, EventArgs e)
		{
			switch (MessageBox.Show("Are you sure you want to quit?", "Confirm", MessageBoxButtons.YesNo))
			{
				case DialogResult.Yes:
					Application.Exit();
					break;
			}
		}
		

		public static void BackToStart(Form form, object sender, EventArgs e)
		{
			form.Hide();
			formStart.Show();
		}
	}
}
