using System;
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
	public partial class FormForHighScores : Form
	{
		class Score
		{
			public int score { get; }
			public string user { get; }

			public Score(int score, string user)
			{
				this.score = score;
				this.user = user;
			}

			public Score(string[] scoreUserPair)
			{
				if (scoreUserPair.Length >= 2)
				{
					this.user = scoreUserPair[1];
				}
				else
				{
					this.user = "#! NO USERNAME";
				}
				this.score = int.Parse(scoreUserPair[0]);
			}

			public override string ToString()
			{
				return $"{this.score} {this.user}";
			}

			public int CompareTo(Score other)
			{
				return this.score.CompareTo(other.score);
			}

			public Label GetScoreLabel()
			{
				return new()
				{
					Text = this.score.ToString()
				};
			}

			public Label GetUserLabel()
			{
				return new()
				{
					Text = this.user
				};
			}
		}

		List<Score> scores = new();

		public FormForHighScores()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void FormForHighScores_Load(object sender, EventArgs e)
		{
			string[] scoresLines = File.ReadAllLines("Data/scores.txt");

			for (int i = 0; i < scoresLines.Length; i++)
			{
				string[] scoreUserPair = scoresLines[i].Split(' ', 2);
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
				tableHighScores.Rows.Add(new[] { scores[i].score.ToString(), scores[i].user });
			}
		}
	}
}
