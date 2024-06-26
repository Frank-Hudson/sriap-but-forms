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
	public partial class Username : Form
	{
		public Username()
		{
			InitializeComponent();
			inputUsername.Height = 26;
			Location += new Size(0, 20);
		}

		public string GetUsername() => inputUsername.Text;

		bool IsBlank(string value) => string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
		
		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (!(
				IsBlank(inputUsername.Text) &&
				MessageBox.Show("Are you sure you don't want to save a username with your score?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No
			)) Close();
		}
	}
}
