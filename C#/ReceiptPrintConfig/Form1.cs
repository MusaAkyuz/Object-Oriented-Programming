using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Data.OleDb;
using System.Diagnostics;
using System.Xml.Linq;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using PdfSharp.Pdf;
using System.Drawing.Printing;
using System.Threading;
using Spire.Pdf;
using System.Management;
using PDFtoPrinter;

namespace ReceiptPrintConfig
{
	public partial class Form1 : Form
	{
		private string providerName = "Deneme";
		DatabaseTransaction db = new DatabaseTransaction();
		public List<List<string>> allData = new List<List<string>>();
		public int listId = 0;
		public string boxCode;
		private List<string> printers = new List<string>();

		public Form1()
		{
			InitializeComponent();

			// DataGridView Initial Settings
			#region DataGridViewInitialSettings
			dataGridView1.ColumnCount = 5;
			dataGridView1.Columns[0].Name = "Company Code"; 
			dataGridView1.Columns[1].Name = "Company Name";
			dataGridView1.Columns[2].Name = "Material Code";
			dataGridView1.Columns[3].Name = "Description";
			dataGridView1.Columns[4].Name = "Unit";

			dataGridView2.ColumnCount = 6;
			dataGridView2.Columns[0].Name = "Company Name";
			dataGridView2.Columns[1].Name = "Material Code";
			dataGridView2.Columns[2].Name = "Description";
			dataGridView2.Columns[3].Name = "Company Code";
			dataGridView2.Columns[4].Name = "Count";
			dataGridView2.Columns[5].Name = "Unit";
			#endregion
		}

		public void CallTextBoxControl()
		{
			TextBoxControl(matLabel, material2txtbox);
			TextBoxControl(comLabel, companynametxtbox);
			TextBoxControl(descLabel, description2txtbox);
			TextBoxControl(comCodeLabel, companycodetxtbox);
			TextBoxControl(countLabel, counttxtbox, "[^0-9]");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region Form1InitialSettings
			
			newStock.Enabled = true;
			saveDatabase.Enabled = false;
			material2txtbox.Enabled = true;
			material2txtbox.ReadOnly = true;
			material2txtbox.Text = null;

			companynametxtbox.Enabled = true;
			companynametxtbox.Text = null;

			description2txtbox.Enabled = true;
			description2txtbox.ReadOnly = true;
			description2txtbox.Text = null;

			companycodetxtbox.Enabled = true;
			companycodetxtbox.Text = null;

			counttxtbox.Enabled = true;
			counttxtbox.Text = null;

			billtxtbox.Enabled = true;
			billtxtbox.Text = null;

			//productiontxtbox.Enabled = true;
			//productiontxtbox.Text = null;
			//productiontxtbox.ReadOnly = true;
			dateTimePicker2.Enabled = true;
			
			lotnotxtbox.Enabled = true;
			lotnotxtbox.Text = null;
			addbelowbtn.Enabled = true;
			deleteAll.Enabled = true;
			deleteSelected.Enabled = true;
			dataGridView2.Enabled = true;
			createDocumant.Enabled = true;
			revisiontxtbox.Enabled = true;
			revisiontxtbox.Text = null;
			singlechkbox.Enabled = true;
			quartedchkbox.Enabled = true;
			materialtxtbox.Enabled = true;
			materialbtn.Enabled = true;
			reloadbtn.Enabled = true;
			dataGridView1.Enabled = true;
			dateTimePicker1.Enabled = true;
			backbtn.Enabled = false;

			matLabel.Visible= true;
			comCodeLabel.Visible= true;
			descLabel.Visible= true;
			comLabel.Visible= true;
			unitLabel.Visible= true;
			countLabel.Visible= true;

			numericUpDown1.Enabled = true;
			numericUpDown1.Value = 1;
			label2.Visible = false;

			printersRefresh.Enabled = true;
			printerCombo.Enabled = true;
			print.Enabled = true;

			unitCombo.Enabled = false;
			unitCombo.Text = null;
			#endregion

			PrinterRefresh();
			CallTextBoxControl();
			UnitBoxControl();
			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock";

				//Bir adet public ArrayList oluşturulup her değişikliği ile onu da değiştirelim. 
				ArrayList row = db.QueryToArrayList(cnn, query, null);

				dataGridView1.Rows.Clear();

				for (int i = 0; i < row.Count; i+=7)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView1);
					newRow.Cells[0].Value = row[i + 1];
					newRow.Cells[1].Value = row[i + 2];
					newRow.Cells[2].Value = row[i + 3];
					newRow.Cells[3].Value = row[i + 4];
					newRow.Cells[4].Value = row[i + 5];
					dataGridView1.Rows.Add(newRow);
				}

				boxCode = GetBoxCodeId();
			}

			//dataGridView1.SelectedCells[0].Selected = true;
		}

		private void materialbtn_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE MaterialCode LIKE @code";
				OleDbParameter parameter = new OleDbParameter();
				parameter.ParameterName = "@code";
				parameter.Value = materialtxtbox.Text;
				if (materialtxtbox.Text != "")
				{
					ArrayList row = db.QueryToArrayList(cnn, query, parameter);

					dataGridView1.Rows.Clear();

					for (int i = 0; i < row.Count; i += 7)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = row[i + 1];
						newRow.Cells[1].Value = row[i + 2];
						newRow.Cells[2].Value = row[i + 3];
						newRow.Cells[3].Value = row[i + 4];
						newRow.Cells[4].Value = row[i + 5];
						dataGridView1.Rows.Add(newRow);
					}
				}
				else
				{
					Form1_Load(sender, e);
				}
				
				cnn.Close();
			}
		}

		private void reloadbtn_Click(object sender, EventArgs e)
		{
			materialtxtbox.Text = String.Empty;
			Form1_Load(sender, e);
		}

		private void addbelowbtn_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(material2txtbox.Text) &&
				!String.IsNullOrEmpty(counttxtbox.Text) &&
				!System.Text.RegularExpressions.Regex.IsMatch(counttxtbox.Text, "[^0-9]") &&
				!String.IsNullOrEmpty(companycodetxtbox.Text) &&
				!String.IsNullOrEmpty(companynametxtbox.Text) &&
				!String.IsNullOrEmpty(description2txtbox.Text) &&
				!String.IsNullOrEmpty(dateTimePicker2.Text) &&
				!String.IsNullOrEmpty(numericUpDown1.Value.ToString()) &&
				numericUpDown1.Value > 0)
			{
				for(int x = 0; x < numericUpDown1.Value; x++)
				{
					if (String.IsNullOrEmpty(billtxtbox.Text))
					{
						listId++;
						allData.Add(new List<string> {material2txtbox.Text,
													  companynametxtbox.Text,
													  description2txtbox.Text,
													  companycodetxtbox.Text,
													  unitCombo.SelectedItem.ToString(),
													  counttxtbox.Text,
													  "",
													  "", //bill date
													  dateTimePicker2.Text, //production date
													  lotnotxtbox.Text,
													  revisiontxtbox.Text,
													  boxCode,
													  singlechkbox.Checked.ToString(),
													  quartedchkbox.Checked.ToString(),
													  listId.ToString(),
													  numericUpDown1.Value.ToString()}
												);
					}
					else
					{
						listId++;
						allData.Add(new List<string> {material2txtbox.Text,
													  companynametxtbox.Text,
													  description2txtbox.Text,
													  companycodetxtbox.Text,
													  unitCombo.SelectedItem.ToString(),
													  counttxtbox.Text,
													  billtxtbox.Text,
													  dateTimePicker1.Text, //bill date
													  dateTimePicker2.Text, //production date
													  lotnotxtbox.Text,
													  revisiontxtbox.Text,
													  boxCode,
													  singlechkbox.Checked.ToString(),
													  quartedchkbox.Checked.ToString(),
													  listId.ToString(),
													  numericUpDown1.Value.ToString()}
												  );
					}

					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView2);
					newRow.Cells[0].Value = companynametxtbox.Text;
					newRow.Cells[1].Value = material2txtbox.Text;
					newRow.Cells[2].Value = description2txtbox.Text;
					newRow.Cells[3].Value = companycodetxtbox.Text;
					newRow.Cells[4].Value = (Convert.ToUInt32(counttxtbox.Text) / numericUpDown1.Value).ToString("0.");
					newRow.Cells[5].Value = unitCombo.SelectedItem.ToString();
					dataGridView2.Rows.Add(newRow);
				}
			}
		}

		private void deleteSelected_Click(object sender, EventArgs e)
		{
			if (this.dataGridView2.SelectedRows.Count > 0)
			{
				int index = this.dataGridView2.CurrentCell.RowIndex;
				allData.RemoveAt(index);
				dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
			}
		}
		private void deleteAll_Click(object sender, EventArgs e)
		{
			dataGridView2.Rows.Clear();
			allData.Clear();
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
				companycodetxtbox.Text = dt.Cells["Company Code"].Value.ToString();
				companynametxtbox.Text = dt.Cells["Company Name"].Value.ToString();
				material2txtbox.Text = dt.Cells["Material Code"].Value.ToString();
				description2txtbox.Text = dt.Cells["Description"].Value.ToString();
				unitCombo.SelectedItem = dt.Cells["Unit"].Value.ToString();
			}
		}

		private void print_Click(object sender, EventArgs e)
		{
			if (dataGridView2.Rows.Count > 0)
			{
				foreach (var list in allData)
				{
					var boxCode2 = GetBoxCodeId();
					DocumantTransactions doc = new DocumantTransactions();
					// Create a MigraDoc document
					Document document = doc.CreateDocument(materialCode: list[0],
													   lotno: list[9],
													   companyName: list[1],
													   billno: list[6],
													   billnoDate: list[7],
													   boxcode: GetBoxCodeId(),
													   count: list[5],
													   unit: list[4],
													   productiondate: list[8],
													   companyCode: list[3],
													   numOfBox: list[15]);
					document.UseCmykColor = true;
					const bool unicode = false;
					PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);

					// Associate the MigraDoc document with a renderer
					pdfRenderer.Document = document;

					// Layout and render document to PDF
					pdfRenderer.RenderDocument();

					// Save the document...
					string filename = "TempDocument\\Receiver";
					long time = DateTime.Now.ToFileTime();
					BoxCodeUpdateMain(boxCode2);
					filename += time + ".pdf";
					pdfRenderer.PdfDocument.Save(filename);
					// ...and start a viewer.
					PDFtoPrinter.Process.Start(filename);
				}
				Form1_Load(sender, e);
			}
			else
			{
				MessageBox.Show("There is no data to print!");
			}
		}

		public void BoxCodeUpdateMain(string boxCode)
		{
			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "INSERT INTO Box (BoxCode) VALUES (@code)";
				OleDbParameter parameter = new OleDbParameter();
				parameter.ParameterName = "@code";
				parameter.Value = boxCode;
				DatabaseTransaction db = new DatabaseTransaction();
				db.BoxCodeUpdate(cnn, query, parameter);
			}

		}

		public string GetBoxCodeId()
		{
			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				cnn.Open();
				string query2 = "SELECT Id, BoxCode FROM [Box]";
				OleDbDataReader dataReader;
				OleDbCommand cmd = new OleDbCommand(query2, cnn);

				dataReader = cmd.ExecuteReader();
				if (dataReader.HasRows)
				{
					while (dataReader.Read())
					{
						boxCode = dataReader["Id"].ToString();
						//numericUpDown1.Value.ToString() = dataReader["Id"].ToString();
						//revisiontxtbox.Text = dataReader["BoxCode"].ToString();
					}
				}
			}

			return boxCode;
		}

		private void newStock_Click(object sender, EventArgs e)
		{
			var configSettings = new List<string>(ConfigurationSettings.AppSettings["ReceiverCompany1"].Split(new char[] { ';' }));

			#region Settings
			//Enable part
			newStock.Enabled = false;
			saveDatabase.Enabled = true;
			material2txtbox.Enabled = true;
			material2txtbox.ReadOnly = false;
			material2txtbox.Text = null;

			companynametxtbox.Enabled = false;
			companynametxtbox.Text = configSettings[1].ToString();

			description2txtbox.Enabled = true;
			description2txtbox.ReadOnly = false;
			description2txtbox.Text = null;

			companycodetxtbox.Enabled = false;
			companycodetxtbox.Text = configSettings[0].ToString();

			counttxtbox.Enabled = false;
			counttxtbox.Text = null;

			billtxtbox.Enabled = false;
			billtxtbox.Text = null;

			//dateTimePicker2.Enabled = false;
			//productiontxtbox.Text = null;
			//productiontxtbox.ReadOnly = true;
			dateTimePicker2.Enabled = false;

			lotnotxtbox.Enabled = false;
			lotnotxtbox.Text = null;
			addbelowbtn.Enabled = false;
			deleteAll.Enabled = false;
			deleteSelected.Enabled = false;
			dataGridView2.Enabled = false;
			createDocumant.Enabled = false;
			revisiontxtbox.Enabled = false;
			revisiontxtbox.Text = null;
			singlechkbox.Enabled = false;
			quartedchkbox.Enabled = false;
			materialtxtbox.Enabled = false;
			materialbtn.Enabled = false;
			reloadbtn.Enabled = false;
			dataGridView1.Enabled = false;
			dateTimePicker1.Enabled = false;
			backbtn.Enabled = true;

			label2.Visible = false;
			numericUpDown1.Enabled = false;

			printersRefresh.Enabled = false;
			printerCombo.Enabled = false;
			print.Enabled = false;

			unitCombo.Enabled = true;
			unitCombo.Text = null;
			#endregion

			CallTextBoxControl();
		}

		public void TextBoxControl(System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, string regex = null)
		{
			if(txt.Enabled == true)
			{
				if(!String.IsNullOrEmpty(regex))
				{
					if (String.IsNullOrEmpty(txt.Text) || System.Text.RegularExpressions.Regex.IsMatch(txt.Text, regex))
					{
						lbl.Visible = true;
					}
					else
					{
						lbl.Visible = false;
					}
				}
				else
				{
					if (String.IsNullOrEmpty(txt.Text))
					{
						lbl.Visible = true;
					}
					else
					{
						lbl.Visible = false;
					}
				}
			}
			else
			{
				lbl.Visible = false;
			}
		}

		private void material2txtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(matLabel ,material2txtbox);
		}

		private void companynametxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(comLabel ,companynametxtbox);
		}

		private void description2txtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(descLabel ,description2txtbox);
		}

		private void companycodetxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(comCodeLabel, companycodetxtbox);
		}

		private void counttxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(countLabel, counttxtbox, "[^0-9]");
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			Form1_Load(sender, e);
		}

		private void saveDatabase_Click(object sender, EventArgs e)
		{
			bool validation = !String.IsNullOrEmpty(material2txtbox.Text) &&
			   !String.IsNullOrEmpty(description2txtbox.Text) &&
			   !String.IsNullOrEmpty(unitCombo.Text);

			if (validation)
			{
				try
				{
					//Database Insert
					using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
					{
						DatabaseTransaction db = new DatabaseTransaction();

						string query = "INSERT INTO Stock (MaterialCode, Description, Unit, CreateDateTime) VALUES (@code, @desc, @unit, @date)";

						List<OleDbParameter> par = new List<OleDbParameter>();
						par.Add(new OleDbParameter("@code", material2txtbox.Text));
						par.Add(new OleDbParameter("@desc", description2txtbox.Text));
						par.Add(new OleDbParameter("@unit", unitCombo.SelectedItem.ToString()));
						par.Add(new OleDbParameter("@date", DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")));

						db.DatabaseInsert(cnn, query, par);
					}
					Form1_Load(sender, e);
				}
				catch (System.FormatException)
				{
					MessageBox.Show("Check date format!");
				}
				catch
				{
					MessageBox.Show("Unknown error");
				}
			}
			else
			{
				MessageBox.Show("Fill required contents!");
			}

			Form1_Load(sender, e);
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if(numericUpDown1.Value < 1)
			{
				label2.Visible = true;
			}
			else
			{
				label2.Visible = false;
			}
		}

		private void print_Click_1(object sender, EventArgs e)
		{
			//ArrayList printerData = new ArrayList();
			////----
			Document splicedDocument = new Document();
			//Section section = splicedDocument.AddSection();
			////----
			///

			if(printers.Contains(printerCombo.SelectedItem))
			{
				if (dataGridView2.Rows.Count > 0)
				{
					foreach (var list in allData)
					{
						//System.Threading.Thread.Sleep(100);
						var boxCode2 = GetBoxCodeId();
						DocumantTransactions doc = new DocumantTransactions();
						// Create a MigraDoc document
						Document document = doc.CreateDocument(materialCode: list[0],
															   lotno: list[9],
															   companyName: list[1],
															   billno: list[6],
															   billnoDate: list[7],
															   boxcode: GetBoxCodeId(),
															   count: list[5],
															   unit: list[4],
															   productiondate: list[8],
															   companyCode: list[3],
															   numOfBox: list[15]);

						var section2 = document.Sections[0].Clone();
						splicedDocument.Add(section2);

						//document.UseCmykColor = true;
						//const bool unicode = false;
						//PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);

						// Associate the MigraDoc document with a renderer
						//pdfRenderer.Document = document;

						// Layout and render document to PDF
						//pdfRenderer.RenderDocument();

						// Save the document...
						//string filename = "TempDocument\\Receiver";
						//long time = DateTime.Now.ToFileTime();
						BoxCodeUpdateMain(boxCode2);
						//filename += time + ".pdf";
						//pdfRenderer.PdfDocument.Save(filename);

						//for (var sectionIndex = 0; sectionIndex < document.Sections.Count; sectionIndex++)
						//{

						//}
					}

					PdfDocumentRenderer pdfRenderer2 = new PdfDocumentRenderer();

					// Associate the MigraDoc document with a renderer
					pdfRenderer2.Document = splicedDocument;

					// Layout and render document to PDF
					pdfRenderer2.RenderDocument();

					// Save the document...
					string filename2 = "TempDocument\\Receiver";
					filename2 += boxCode + ".pdf";
					pdfRenderer2.PdfDocument.Save(filename2);
					// ...and start a viewer.
					PrintDocument pd = new PrintDocument();

					try
					{
						//using (PrintDialog Dialog = new PrintDialog())
						//{
						//	Dialog.ShowDialog();

						//	ProcessStartInfo printProcessInfo = new ProcessStartInfo()
						//	{
						//		Verb = "print",
						//		CreateNoWindow = true,
						//		FileName = filename2,
						//		WindowStyle = ProcessWindowStyle.Hidden
						//	};

						//	Process printProcess = new Process();
						//	printProcess.StartInfo = printProcessInfo;
						//	printProcess.Start();

						//	printProcess.WaitForInputIdle();

						//	Thread.Sleep(3000);

						//	if (false == printProcess.CloseMainWindow())
						//	{
						//		printProcess.Kill();
						//	}
						//}
						//using (var doc = PdfDocument(filename2))
						//{

						//-------------------------------------------------------

						//}
						//Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument(filename2);
						//doc.PrintSettings.PrinterName = printerCombo.SelectedItem.ToString();
						//doc.PrintSettings.PrintController = new StandardPrintController();
						//doc.Print();

						//------------------------------------------------------

						//PdfDocument doc = new PdfDocument(filename2);
						//PrintDialog pt = new PrintDialog();
						//pt.PrinterSettings.PrinterName = printerCombo.SelectedItem.ToString();

						//var startInfo = new ProcessStartInfo
						//{
						//	FileName = filename2,
						//	CreateNoWindow = true,
						//	ErrorDialog = false,
						//	UseShellExecute = false,
						//	Verb = "print",
						//	WindowStyle = ProcessWindowStyle.Minimized,
						//	RedirectStandardInput = true,
						//	RedirectStandardOutput = false
						//};

						//using (var process = Process.Start(startInfo))
						//{
						//	process.CloseMainWindow();
						//	process.Kill();
						//}

						//-----------------------------------------------------------------

						var printer = new PDFtoPrinterPrinter();
						printer.Print(new PrintingOptions(printerCombo.SelectedItem.ToString(), filename2));

					}
					catch
					{
						MessageBox.Show("Error");
						Form1_Load(sender, e);
					}
					
					Form1_Load(sender, e);
				}
				else
				{
					MessageBox.Show("There is no data to print!");
				}
			}
			else
			{
				MessageBox.Show("Printer is not Okay!");
			}
		}

		private void printersRefresh_Click(object sender, EventArgs e)
		{
			PrinterRefresh();
		}

		public void PrinterRefresh()
		{
			printers.Clear();
			printerCombo.Items.Clear();
			foreach (String printer in PrinterSettings.InstalledPrinters)
			{
				printerCombo.Items.Add(printer.ToString());
				printers.Add(printer.ToString());
			}

			PrinterSettings settings = new PrinterSettings();
			printerCombo.Text = settings.PrinterName;
		}

		private void unitCombo_TextChanged(object sender, EventArgs e)
		{
			UnitBoxControl();	
		}

		public void UnitBoxControl()
		{
			if (String.IsNullOrEmpty(unitCombo.Text))
			{
				unitLabel.Visible = true;
			}
			else
			{
				unitLabel.Visible = false;
			}
		}
	}
}
