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
				public int used;
				public int loaded;
			}

			public enum DifficultyMode
			{
				Normal,
				Easy,
			}
		}

		private bool Valid;

		public Settings()
		{
			InitializeComponent();

			this.inputCardsX.ValueChanged += inputCardsChanged;
			this.inputCardsX.ValueChanged += inputValidifiableChanged;
			this.inputCardsY.ValueChanged += inputCardsChanged;
			this.inputCardsY.ValueChanged += inputValidifiableChanged;
			this.inputUsedImages.ValueChanged += inputValidifiableChanged;
			this.inputLoadedImages.ValueChanged += inputValidifiableChanged;
			this.inputDuplicates.ValueChanged += inputValidifiableChanged;

			try
			{
				SettingsData = JsonConvert.DeserializeObject<SriapSettings>(File.ReadAllText(SETTINGS_FILE_PATH));
			}
			catch (JsonSerializationException jse)
			{
				MessageBox.Show($"There was an error deserializing the settings JSON:\n{jse.Message}", "JSON Serialization Error");
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
			int totalCards = SettingsData.cardgrid.Area();
			inputCardsX.Value = SettingsData.cardgrid.x;
			inputCardsY.Value = SettingsData.cardgrid.y;
			infoTotalCards.Text = $"= {totalCards}";
			inputUsedImages.Value = SettingsData.images.used;
			inputLoadedImages.Value = SettingsData.images.loaded;
			inputDuplicates.Value = SettingsData.duplicates;
			inputDifficulty.SelectedItem = inputDifficulty.Items[(int)SettingsData.difficulty];
			int totalPlayCards = SettingsData.images.used * SettingsData.duplicates;
			int result = totalCards / totalPlayCards;
			int remainder = totalCards % totalPlayCards;
			Valid = result == 1 && remainder == 0 && inputUsedImages.Value <= inputLoadedImages.Value;
			if (Valid)
			{
				outputValid.Text = "✓";
				outputValid.ForeColor = Color.FromArgb(100, 230, 120);
			}
			else
			{
				outputValid.Text = "✗";
				outputValid.ForeColor = Color.FromArgb(230, 100, 120);
			}
			infoValidRule.Text = $"{totalCards} / ({SettingsData.images.used} * {SettingsData.duplicates}) = {result} remainder {remainder}";
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
			if (!Valid)
			{
				MessageBox.Show();
			}

			// When the settings are saved, each is written to the
			// Data/settings.json file as serialized JSON
			try
			{
				File.WriteAllText(SETTINGS_FILE_PATH, JsonConvert.SerializeObject(SettingsData, Formatting.Indented));
			}
			catch (JsonSerializationException jse)
			{
				MessageBox.Show($"There was an error serializing the settings data to JSON:\n{jse.Message}", "JSON Serialization Error");
				Application.Exit();
			}
			catch (PathTooLongException pe)
			{
				MessageBox.Show($"The path for the settings file is too long:\n{pe.Message}", "Path Error");
				Application.Exit();
			}
			catch (FileNotFoundException fe)
			{
				MessageBox.Show($"The settings file wasn't found:\n{fe.Message}", "File Error");
				Application.Exit();
			}
			catch (DirectoryNotFoundException de)
			{
				if (de.Message.Contains("settings.json"))
				{
					MessageBox.Show($"The `Data/settings.json` file is missing, please place the `Data` directory at the program's root\n(\"{AppDomain.CurrentDomain.BaseDirectory}\").\n\nThe relevant files can be found here: https://github.com/Frank-Hudson/sriap-but-forms/tree/master/Data", "Missing Files");
				}
				else
				{
					MessageBox.Show($"Directory not found opening `Data/settings.json`:\n{de.Message}", "Directory Error");
				}
				Application.Exit();
			}
			catch (UnauthorizedAccessException ae)
			{
				MessageBox.Show($"Access to the settings file is not permitted:\n{ae.Message}", "Access Error");
				Application.Exit();
			}
			catch (IOException ioe)
			{
				MessageBox.Show($"There was an IO error writing settings:\n{ioe.Message}", "IO Error");
				Application.Exit();
			}
			catch (Exception er)
			{
				MessageBox.Show($"There was an unidentified error writing settings:\n{er}", "Unidentified Error");
				Application.Exit();
			}

			MessageBox.Show("Settings Saved Successfully!", "Success!");
		}

		private void inputCardsXChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.x = (int)inputCardsX.Value;
		}

		private void inputCardsYChanged(object sender, EventArgs e)
		{
			SettingsData.cardgrid.y = (int)inputCardsY.Value;
		}

		private void inputCardsChanged(object sender, EventArgs e)
		{
			infoTotalCards.Text = $"= {SettingsData.cardgrid.Area()}";
		}

		private void inputDuplicatesChanged(object sender, EventArgs e)
		{
			SettingsData.duplicates = (int)inputDuplicates.Value;
		}

		private void inputLoadedImagesChanged(object sender, EventArgs e)
		{
			SettingsData.images.loaded = (int)inputLoadedImages.Value;
		}

		private void inputUsedImagesChanged(object sender, EventArgs e)
		{
			SettingsData.images.used = (int)inputUsedImages.Value;
		}

		private void inputValidifiableChanged(object sender, EventArgs e)
		{
			FillSettingControls();
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
