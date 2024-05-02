using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SriapButForms
{
	public static class Extensions
	{
		public static string ToString(this LogLevel logLevel)
		{
			switch (logLevel)
			{
				case LogLevel.Debug: return "Debug";
				case LogLevel.Info: return "Info";
				case LogLevel.Warn: return "Warn";
				case LogLevel.Err: return "Err";
				case LogLevel.Crit: return "Crit";
				case LogLevel.None:
				default: return "None";
			}
		}
	}

	public enum LogLevel
	{
		None = 0,
		Debug = 10,
		Info = 20,
		Warn = 30,
		Err = 40,
		Crit = 50,
	}

	public partial class AppLog : Component
	{
		public readonly List<string> logs = new();
		public ListBox output;

		public void Log(string message, LogLevel level = LogLevel.Debug)
		{
			this.logs.Add($"{DateTime.Now:s} [{level}] {message}");
		}

		public void LogFill(string message, LogLevel level = LogLevel.Debug)
		{
			Log(message, level);
			FillLatestLog();
		}

		public void FillLatestLog()
		{
			this.output.Items.Add(this.logs.Last());
		}

		public void FillOutput()
		{
			foreach (string log in this.logs)
			{
				this.output.Items.Add(log);
			}
		}

		public AppLog()
		{
			InitializeComponent();
		}

		public AppLog(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
