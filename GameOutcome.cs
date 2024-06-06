using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class GameOutcome : Form
	{
		readonly TimeSpan Time;
		readonly int Score;
		readonly bool Win;
		readonly string Status;

		public string Username;

		public GameOutcome(TimeSpan time, int score, bool win)
		{
			InitializeComponent();
			DialogResult = DialogResult.None;

			Time = time;
			Score = score;
			Win = win;
			Status = Win ? "YOU WIN!" : "YOU LOSE!";

			Text = $"GAME OVER - {Status}";
			labelStatus.Text = Status;
			labelScore.Text = $"Score {Score}";
			labelTime.Text = Time.ToString(@"mm\:ss");
		}

		private void buttonSaveScore_Click(object sender, EventArgs e)
		{
			Username formUsername = new();
			formUsername.ShowDialog();
			Username = formUsername.GetUsername();
			StreamWriter streamWriter = File.AppendText("Data/scores.txt");
			streamWriter.WriteLine($"{Score} {Username}");
			streamWriter.Close();
		}

		void Close(DialogResult dialogResult)
		{
			DialogResult = dialogResult;
			Close();
		}

		private void buttonReplay_Click(object sender, EventArgs e)
		{
			Close(DialogResult.Retry);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			Close(DialogResult.Abort);
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
