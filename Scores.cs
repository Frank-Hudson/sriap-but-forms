﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SriapButForms
{
	public partial class Scores : Form
	{
		const string SCORES_FILE_PATH = "Data/scores.txt";

		class Score
		{
			public int score { get; }
			public string time { get; }
			public string user { get; }

			public Score(int score, string time, string user)
			{
				this.score = score;
				this.time = time;
				this.user = user;
			}

			public Score(string[] playerScoreParts)
			{
				this.user = playerScoreParts.Length >= 3 ? playerScoreParts[2] : "#! NO USERNAME";
				this.score = int.Parse(playerScoreParts[0]);

				string timePart = playerScoreParts[1];
				List<char> timePartList = timePart.ToList();
				timePartList.Remove('(');
				timePartList.Remove(')');

				this.time = new(timePartList.ToArray());
			}

			public override string ToString() => $"{this.score} ({this.time}) {this.user}";

			public int CompareTo(Score other) => this.score.CompareTo(other.score);

			public Label GetScoreLabel() => new()
			{
				Text = this.score.ToString()
			};

			public Label GetUserLabel() => new()
			{
				Text = this.user
			};
		}

		List<Score> scores = new();

		public Scores()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void FormForHighScores_Load(object sender, EventArgs e)
		{
			string[] scoresLines = File.ReadAllLines(SCORES_FILE_PATH);

			for (int i = 0; i < scoresLines.Length; i++)
			{
				string[] scoreUserPair = scoresLines[i].Split(' ', 3);
				try
				{
					scores.Add(new Score(scoreUserPair));
				}
				catch (FormatException fe)
				{
					MessageBox.Show($"There was a format error parsing scores:\n{fe}", "Format Error");
				}
				catch (OverflowException oe)
				{
					MessageBox.Show($"There was an overflow error parsing scores:\n{oe}", "Overflow Error");
				}
				catch (Exception er)
				{
					MessageBox.Show($"There was an unidentified error parsing scores:\n{er}", "Unidentified Error");
				}
			}

			scores = scores.OrderByDescending(s => s.score).ToList();

			for (int i = 0; i < scores.Count; i++)
			{
				tableHighScores.Rows.Add(new string[3] { scores[i].score.ToString(), scores[i].time, scores[i].user });
			}
		}
	}
}
