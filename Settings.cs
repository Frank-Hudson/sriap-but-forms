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
using Newtonsoft.Json;

namespace SriapButForms
{
	public partial class Settings : Form
	{
		const string SETTINGS_FILE_PATH = "Data/settings.json";

		public readonly SriapSettings SettingsData;

		public class SriapSettings
		{
			public CoordsXY cardgrid;
			public AllowedTotal images;
			public int duplicates;

			public struct CoordsXY
			{
				public int x;
				public int y;
			}

			public struct AllowedTotal
			{
				public int allowed;
				public int total;
			}
		}

		public Settings()
		{
			InitializeComponent();

			try
			{
				SettingsData = JsonConvert.DeserializeObject<SriapSettings>(File.ReadAllText(SETTINGS_FILE_PATH));
			}
			catch (JsonSerializationException jse)
			{
				MessageBox.Show($"There was an error serializing the settings JSON:\n{jse.Message}", "JSON Serialization Error");
				Application.Exit();
			}
			catch (PathTooLongException pe)
			{
				MessageBox.Show($"The path for the settings file was too long:\n{pe.Message}", "Path Error");
				Application.Exit();
			}
			catch (FileNotFoundException fe)
			{
				MessageBox.Show($"The file in the path provided while opening settings was not found:\n{fe.Message}", "File Error");
				Application.Exit();
			}
			catch (DirectoryNotFoundException de)
			{
				if (de.Message.Contains("settings.json"))
				{
					MessageBox.Show($"The `Data/settings.json` file is missing, please place the Data directory at the program's root\n({AppDomain.CurrentDomain.BaseDirectory}).\n\nThe relevant files can be found here: https://github.com/Frank-Hudson/sriap-but-forms/tree/master/Data", "Missing Files");
				}
				else
				{
					MessageBox.Show($"The directory in the path provided while opening settings was not found:\n{de.Message}", "Directory Error");
				}
				Application.Exit();
			}
			catch (UnauthorizedAccessException ae)
			{
				MessageBox.Show($"Access is not permitted to the settings file:\n{ae.Message}", "Access Error");
				Application.Exit();
			}
			catch (IOException ioe)
			{
				MessageBox.Show($"There was an IO error parsing settings:\n{ioe.Message}", "IO Error");
				Application.Exit();
			}
			catch (Exception er)
			{
				MessageBox.Show($"There was an unidentified error parsing settings:\n{er}", "Unidentified Error");
				Application.Exit();
			}

			FillSettingControls();
		}

		void FillSettingControls()
		{
			numericCardGridX.Value = SettingsData.cardgrid.x;
			numericCardGridY.Value = SettingsData.cardgrid.y;
			labelImages.Text = SettingsData.images.allowed.ToString();
			numericMaximumImages.Value = SettingsData.images.total;
			numericPairs.Value = SettingsData.duplicates;
		}

		private void FormForSettings_Load(object sender, EventArgs e)
		{

		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Console.WriteLine("! ERROR : Save  button not implemented!");
		}

		private void numericCardGridX_ValueChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.x = (int)numericCardGridX.Value;
		}

		private void numericCardGridY_ValueChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.y = (int)numericCardGridY.Value;
		}

		private void numericMaximumImages_ValueChanged(object sender, EventArgs e)
		{
			SettingsData.images.total = (int)numericMaximumImages.Value;
		}
	}
}
