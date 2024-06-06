﻿using System;
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
	public partial class StartMenu : Form
	{
		public StartMenu()
		{
			InitializeComponent();
		}

		private void GoToForm(Form form)
		{
			this.Hide();
			form.Show();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			GoToForm(PublicItems.formGameplay);
		}

		private void buttonHighScores_Click(object sender, EventArgs e)
		{
			GoToForm(PublicItems.formScores);
		}

		private void buttonSettings_Click(object sender, EventArgs e)
		{
			GoToForm(PublicItems.formSettings);
		}

		private void buttonAbout_Click(object sender, EventArgs e)
		{
			PublicItems.formAbout.Show();
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}