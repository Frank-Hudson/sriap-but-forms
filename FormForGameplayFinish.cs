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
	public partial class FormForGameplayFinish : Form
	{
		readonly int Score;
		readonly bool Win;
		readonly string Status;

		public string Username;

		public FormForGameplayFinish(int score, bool win)
		{
			InitializeComponent();
			DialogResult = DialogResult.None;

			Score = score;
			Win = win;
			Status = Win ? "YOU WIN!" : "YOU LOSE!";

			Text = $"GAME OVER - {Status}";
			labelStatus.Text = Status;
			labelScore.Text = $"Score {Score}";
		}

		private void buttonSaveScore_Click(object sender, EventArgs e)
		{
			FormForUsername formUsername = new();
			formUsername.ShowDialog();
			Username = formUsername.GetUsername();
			StreamWriter streamWriter = File.AppendText("Data/scores.txt");
			streamWriter.WriteLine($"{Score} {Username}");
			streamWriter.Close();
		}

		private void buttonReplay_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Retry;
			Close();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
