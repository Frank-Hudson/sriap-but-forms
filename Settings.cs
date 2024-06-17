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
			public GridSize2D cardgrid;
			public AllowedTotal images;
			public int duplicates;
			public DifficultyMode difficulty;

			public struct GridSize2D
			{
				public int x;
				public int y;

				public int Area() => this.x * this.y;
			}

			public struct AllowedTotal
			{
				public int allowed;
				public int total;
			}

			public enum DifficultyMode
			{
				Normal,
				Easy,
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
			inputCardsX.Value = SettingsData.cardgrid.x;
			inputCardsY.Value = SettingsData.cardgrid.y;
			labelTotalCards.Text = $"= {SettingsData.cardgrid.Area()}";
			inputCardImages.Text = SettingsData.images.allowed.ToString();
			inputMaxCardImages.Value = SettingsData.images.total;
			inputCardPairs.Value = SettingsData.duplicates;
			inputDifficulty.SelectedItem = inputDifficulty.Items[(int)SettingsData.difficulty];
		}

		private void SettingsLoad(object sender, EventArgs e)
		{

		}

		private void buttonBackClick(object sender, EventArgs e)
		{
			PublicItems.BackToStart(this, sender, e);
		}

		private void buttonSaveClick(object sender, EventArgs e)
		{
			Console.WriteLine("! ERROR : Save  button not implemented!");
		}

		private void inputCardsXChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.x = (int)inputCardsX.Value;
		}

		private void inputCardsYChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.y = (int)inputCardsY.Value;
		}

		private void inputMaxCardImagesChanged(object sender, EventArgs e)
		{
			SettingsData.images.total = (int)inputMaxCardImages.Value;
		}
	}

	public static class Extensions
	{
		public static string ToString(this Settings.SriapSettings.DifficultyMode difficulty) => difficulty switch
		{
			Settings.SriapSettings.DifficultyMode.Normal => "Normal",
			Settings.SriapSettings.DifficultyMode.Easy => "Easy",
			_ => "ERROR: NONEXSISTENT DIFFICULTY MODE",
		};
	}
}
