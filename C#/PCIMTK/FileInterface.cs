using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PCIMTK
{
	public class FileInterface
	{
		[Obsolete]
		private static string logtxt = System.Configuration.ConfigurationManager.AppSettings["LogFilePath"].ToString();

		public string CompanyCode { get; set; }
		public string CompanyName { get; set; }
		public string MaterialCode { get; set; }
		public string Description { get; set; }
		public string Unit { get; set; }
		public int Quantity { get; set; }
		public string BillNo { get; set; }
		public string BillDate { get; set; }
		public string ProductionDate { get; set; }
		public string LotNo { get; set; }
		public string Revision { get; set; }
		public decimal NumberOfBox { get; set; }

		[Obsolete]
		public static List<FileInterface> UpdateList(Form1 f)
		{
			try
			{
				List<FileInterface> data = new List<FileInterface>();
				for (int i = 0; i < f.documantView.Rows.Count; i++)
				{
					data.Add(new FileInterface()
					{
						CompanyCode = f.documantView.Rows[i].Cells["CompanyCode"].Value.ToString(),
						CompanyName = f.documantView.Rows[i].Cells["CompanyName"].Value.ToString(),
						MaterialCode = f.documantView.Rows[i].Cells["MaterialCode"].Value.ToString(),
						Description = f.documantView.Rows[i].Cells["Description"].Value.ToString(),
						Unit = f.documantView.Rows[i].Cells["Unit"].Value.ToString(),
						Quantity = Convert.ToInt32(f.documantView.Rows[i].Cells["Quantity"].Value),
						BillNo = f.documantView.Rows[i].Cells["BillNo"].Value.ToString(),
						BillDate = f.documantView.Rows[i].Cells["BillDate"].Value.ToString(),
						ProductionDate = f.documantView.Rows[i].Cells["ProductionDate"].Value.ToString(),
						LotNo = f.documantView.Rows[i].Cells["LotNo"].Value.ToString(),
						Revision = f.documantView.Rows[i].Cells["Revision"].Value.ToString(),
						NumberOfBox = Convert.ToDecimal(f.documantView.Rows[i].Cells["NumberOfBox"].Value)
					});
				}

				return data;
			}
			catch
			{
				System.Windows.MessageBox.Show("Error while background process\nPlease contact with provider!", "Error", MessageBoxButton.OK);

				// Logging Error 012
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR012-UpdateList-FileInterface");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR012-UpdateList-FileInterface");
					tw.Close();
				}
				#endregion
			}

			return null;
		}
	}
}
