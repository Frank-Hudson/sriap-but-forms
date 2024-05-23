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
			return logLevel switch
			{
				LogLevel.Debug => "Debug",
				LogLevel.Info => "Info",
				LogLevel.Warn => "Warn",
				LogLevel.Err => "Err",
				LogLevel.Crit => "Crit",
				_ => "None",
			};
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
			this.logs.Insert(0, $"{DateTime.Now:s} [{level}] {message}");
		}

		public void LogFill(string message, LogLevel level = LogLevel.Debug)
		{
			Log(message, level);
			FillLatestLog();
		}

		public void FillLatestLog()
		{
			this.output.Items.Insert(0, this.logs.First());
		}

		public void FillOutput()
		{
			foreach (string log in this.logs)
			{
				this.output.Items.Add(log);
			}
		}

		public override string ToString()
		{
			return base.ToString();
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
