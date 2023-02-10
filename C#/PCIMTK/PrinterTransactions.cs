using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PCIMTK
{
	internal class PrinterTransactions
	{
		public List<string> Printers = new List<string>();
		[Obsolete]
		private string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();

		[Obsolete]
		public void ShowAvailablePrinters(Form1 f)
		{
			try
			{
				Printers.Clear();
				f.printersComboBox.Items.Clear();
				foreach (String printer in PrinterSettings.InstalledPrinters)
				{
					f.printersComboBox.Items.Add(printer.ToString());
					Printers.Add(printer.ToString());
				}

				PrinterSettings settings = new PrinterSettings();
				f.printersComboBox.Text = settings.PrinterName;
			}
			catch
			{
				System.Windows.MessageBox.Show("Error while showing available printers!", "Error", MessageBoxButton.OK);

				// Logging Error 011
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR011-ShowAvailablePrinters");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR011-ShowAvailablePrinters");
					tw.Close();
				}
				#endregion
			}
		}
	}
}
