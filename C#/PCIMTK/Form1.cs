using iTextSharp.text;
using iTextSharp.text.pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.IO;
using PDFtoPrinter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace PCIMTK
{
	public partial class Form1 : Form
	{
		public string mode;
		[Obsolete]
		private string logtxt = System.Configuration.ConfigurationManager.AppSettings["LogFilePath"].ToString();

		[Obsolete]
		public Form1()
		{
			try
			{
				InitializeComponent();

				stockView.ColumnCount = 5;
				stockView.Columns[0].Name = "Company Code";
				stockView.Columns[1].Name = "Company Name";
				stockView.Columns[2].Name = "Material Code";
				stockView.Columns[3].Name = "Description";
				stockView.Columns[4].Name = "Unit";
			}
			catch 
			{
				MessageBox.Show("Error while initializing components!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 001
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR001-InitializeComponent");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR001-InitializeComponent");
					tw.Close();
				}
				#endregion

			}

		}

		[Obsolete]
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				UserModeDefaults.SelectionMode(this);
				UserModeDefaults.RequirementControlSelectionMode(this);
				DatabaseTransactions db = new DatabaseTransactions();
				db.GetData(this);
				PrinterTransactions pr = new PrinterTransactions();
				pr.ShowAvailablePrinters(this);

				//numeric up down textchanged bindings
				numberOfBoxNumber.TextChanged += new EventHandler(numberOfBoxNumber_TextChanged);
			}
			catch
			{
				MessageBox.Show("Error while program windows loading!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 002
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR002-Form1Load");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR002-Form1Load");
					tw.Close();
				}
				#endregion
			}
		}

		[Obsolete]
		private void refreshStockBtn_Click(object sender, EventArgs e)
		{
			try
			{
				filterTxtBox.Text = null;
				DatabaseTransactions db = new DatabaseTransactions();
				db.GetData(this);
			}
			catch
			{
				MessageBox.Show("Error while refreshing Stock informations!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 003
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR003-RefreshStockButton-Click");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR003-RefreshStockButton-Click");
					tw.Close();
				}
				#endregion
			}
		}

		[Obsolete]
		private void stockView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				UserModeDefaults.SelectionMode(this);

				if (e.RowIndex >= 0)
				{
					DataGridViewRow dt = stockView.Rows[e.RowIndex];
					companyCodeTxtBox.Text = dt.Cells["Company Code"].Value.ToString();
					companyNameTxtBox.Text = dt.Cells["Company Name"].Value.ToString();
					mtrlCodeTxtBox.Text = dt.Cells["Material Code"].Value.ToString();
					descriptionTxtBox.Text = dt.Cells["Description"].Value.ToString();
					unitComboBox.SelectedItem = dt.Cells["Unit"].Value.ToString();
				}

				UserModeDefaults.RequirementControlSelectionMode(this);
			}
			catch
			{
				MessageBox.Show("Error while fetching clicked data!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 004
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR004-StockViewCellClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR004-StockViewCellClick");
					tw.Close();
				}
				#endregion
			}
		}

		private void addBelowBtn_Click(object sender, EventArgs e)
		{
			try
			{
				// Control stage
				if (UserModeDefaults.RequirementControlSelectionMode(this))
				{
					for (int i = 0; i < numberOfBoxNumber.Value; i++)
					{
						documantView.Rows.Add(companyCodeTxtBox.Text,
											  companyNameTxtBox.Text,
											  mtrlCodeTxtBox.Text,
											  descriptionTxtBox.Text,
											  unitComboBox.Text,
											  (Convert.ToInt32(quantityTxtBox.Text) / numberOfBoxNumber.Value).ToString("0."),
											  billNoTxtBox.Text,
											  billDatePicker.Text,
											  productionDatePicker.Text,
											  lotNoTxtBox.Text,
											  revisionTxtBox.Text,
											  numberOfBoxNumber.Value / numberOfBoxNumber.Value);
					}

					UserModeDefaults.SelectionMode(this);
					UserModeDefaults.RequirementControlSelectionMode(this);
				}
				else
				{
					MessageBox.Show("Required fields must be correctly filled", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Error while adding information to Label List below!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 005
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR005-AddBelowButtonClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR005-AddBelowButtonClick");
					tw.Close();
				}
				#endregion
			}	
		}

		#region TextChangedMethods
		[Obsolete]
		private void filterTxtBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DatabaseTransactions db = new DatabaseTransactions();
				db.GetData(this, filterTxtBox.Text.ToString());
			}
			catch
			{
				MessageBox.Show("Error while filtering", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 006
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR006-FilterTextBoxTextChanged");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR006-FilterTextBoxTextChanged");
					tw.Close();
				}
				#endregion
			}
		}

		private void mtrlCodeTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection")	UserModeDefaults.RequirementControlSelectionMode(this);
			else                            UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void companyNameTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void companyCodeTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void unitComboBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void quantityTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void productionDatePicker_ValueChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void lotNoTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void numberOfBoxNumber_ValueChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

        private void numberOfBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
            else UserModeDefaults.RequirementControlAddingMode(this);
        }
        #endregion

        private void newBtn_Click(object sender, EventArgs e)
		{
			UserModeDefaults.AddingMode(this);
			UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			UserModeDefaults.SelectionMode(this);
			UserModeDefaults.RequirementControlSelectionMode(this);
		}

		[Obsolete]
		private void saveBtn_Click(object sender, EventArgs e)
		{
			try
			{
				DatabaseTransactions db = new DatabaseTransactions();
				bool validation = db.InsertData(this);

				if (validation)
				{
					Form1_Load(sender, e);
				}
			}
			catch
			{
				MessageBox.Show("Error while saving information!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 007
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR007-SaveButtonClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR007-SaveButtonClick");
					tw.Close();
				}
				#endregion
			}
		}

		private void deleteSelectedBtn_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow cell in documantView.SelectedRows)
			{
				documantView.Rows.RemoveAt(cell.Index);
			}
		}

		private void deleteAllBtn_Click(object sender, EventArgs e)
		{
			documantView.Rows.Clear();
		}

		private void refreshPrinterBtn_Click(object sender, EventArgs e)
		{
			try
			{
				PrinterTransactions pr = new PrinterTransactions();
				pr.ShowAvailablePrinters(this);
			}
			catch
			{
				MessageBox.Show("Error while refresh printers!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 008
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR008-RefreshPrinterButtonClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR008-RefreshPrinterButtonClick");
					tw.Close();
				}
				#endregion
			}
		}

		[Obsolete]
		private void createDocumantBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (documantView.Rows.Count != 0)
				{
					string filename = DocumantTransactions.RenderDocument(this);

					string inPDF = filename;
					string outPDF = "TempDocument\\Copy.pdf";
					iTextSharp.text.pdf.PdfReader pdfr = new iTextSharp.text.pdf.PdfReader(inPDF);

					iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
					iTextSharp.text.Document.Compress = true;

					iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(outPDF, FileMode.Create));
					doc.Open();

					PdfContentByte cb = writer.DirectContent;

					PdfImportedPage page;

					for (int i = 1; i < pdfr.NumberOfPages + 1; i++)
					{
						page = writer.GetImportedPage(pdfr, i);
						cb.AddTemplate(page, PageSize.A4.Width / pdfr.GetPageSize(i).Width, 0, 0, PageSize.A4.Height / pdfr.GetPageSize(i).Height, 0, 0);
						doc.NewPage();
					}

					doc.Close();

					PDFtoPrinter.Process.Start(outPDF);
					progressBar.Value = 0;
				}
				else
				{
					MessageBox.Show("There is no document to create document", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Error while creating document!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 009
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR009-CreateDocumantButtonClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR009-CreateDocumantButtonClick");
					tw.Close();
				}
				#endregion
			}
		}

		[Obsolete]
		private void printBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (documantView.Rows.Count != 0)
				{
					string filename = DocumantTransactions.RenderDocument(this);

					PrintDocument pd = new PrintDocument();
					var printer = new PDFtoPrinterPrinter();
					printer.Print(new PrintingOptions(printersComboBox.SelectedItem.ToString(), filename));
					progressBar.Value = 0;
				}
				else
				{
					MessageBox.Show("There is no document to print", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("Error while creating document!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Logging Error 010
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR010-PrintButtonClick");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR010-PrintButtonClick");
					tw.Close();
				}
				#endregion
			}
		}
	}
}
