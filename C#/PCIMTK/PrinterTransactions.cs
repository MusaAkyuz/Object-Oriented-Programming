using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCIMTK
{
	internal class PrinterTransactions
	{
		public List<string> Printers = new List<string>();

		public void ShowAvailablePrinters(Form1 f)
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
	}
}
