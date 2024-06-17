using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	public static class PublicItems
	{
		public static StartMenu formStart = new();
		public static About formAbout = new();
		public static Settings formSettings = new();
		public static Scores formScores = new();
		public static Gameplay formGameplay = new();


		/// <summary>
		/// Copied from <see cref="https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program#:~:text=Wait%20function%20using,wait%20one%20second"/>
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


		////public void DropShadow(object sender, PaintEventArgs e)
		////{
		////	Panel targetPanel = (sender as Panel);
		////	Color[] shadow = new Color[3] {
		////	
		////	};
		////}


		public static void BackToStart(Form form, object sender, EventArgs e)
		{
			form.Hide();
			formStart.Show();
		}

		public static bool Divisible(float x, float y) => x % y == 0;
	}
}
