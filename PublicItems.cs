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
		public static FormForSettings formSettings = new();
		public static About formAbout = new();


		/// <summary>
		/// From 
		/// <see cref="https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program#:~:text=Wait%20function%20using,wait%20one%20second"/>
		/// </summary>
		public static void Wait(int milliseconds)
		{
			var timer1 = new System.Windows.Forms.Timer();
			if (milliseconds == 0 || milliseconds < 0) return;

			// Console.WriteLine("start wait timer");
			timer1.Interval = milliseconds;
			timer1.Enabled = true;
			timer1.Start();

			timer1.Tick += (s, e) =>
			{
				timer1.Enabled = false;
				timer1.Stop();
				// Console.WriteLine("stop wait timer");
			};

			while (timer1.Enabled)
			{
				Application.DoEvents();
			}
		}


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
