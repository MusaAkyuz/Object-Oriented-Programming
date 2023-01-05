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
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ReceiptPrintConfig
{
	public partial class Form1 : Form
	{
		private string providerName = "Deneme";
		DatabaseTransaction db = new DatabaseTransaction();

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

			dataGridView2.ColumnCount = 8;
			dataGridView2.Columns[0].Name = "Company Name";
			dataGridView2.Columns[1].Name = "Material Code";
			dataGridView2.Columns[2].Name = "Description";
			dataGridView2.Columns[3].Name = "Company Code";
			dataGridView2.Columns[4].Name = "Count";
			dataGridView2.Columns[5].Name = "Unit";
			dataGridView2.Columns[6].Name = "Box Gross";
			dataGridView2.Columns[7].Name = "Karton";
			#endregion
		}

		public void CallTextBoxControl()
		{
			TextBoxControl(matLabel, material2txtbox);
			TextBoxControl(comLabel, companynametxtbox);
			TextBoxControl(descLabel, description2txtbox);
			TextBoxControl(comCodeLabel, companycodetxtbox);
			TextBoxControl(unitLabel, unittxtbox);
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

			unittxtbox.Enabled = true;
			unittxtbox.ReadOnly = true;
			unittxtbox.Text = null;

			counttxtbox.Enabled = true;
			counttxtbox.Text = null;

			operatortxtbox.Enabled = true;
			operatortxtbox.Text = null;
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
			print.Enabled = true;
			revisiontxtbox.Enabled = true;
			revisiontxtbox.Text = null;
			boxcodetxtbox.Enabled = true;
			grossweighttxtbox.Enabled = true;
			grossweighttxtbox.Text = null;
			singlechkbox.Enabled = true;
			quartedchkbox.Enabled = true;
			kartoncombobox.Enabled = true;
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
			#endregion

			CallTextBoxControl();
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

				cnn.Open();
				string query2 = "SELECT Id, BoxCode FROM [Box]";
				OleDbDataReader dataReader;
				OleDbCommand cmd = new OleDbCommand(query2, cnn);

				dataReader = cmd.ExecuteReader();
				if (dataReader.HasRows)
				{
					while (dataReader.Read())
					{
						boxcodetxtbox.Text = dataReader["Id"].ToString();
						//revisiontxtbox.Text = dataReader["BoxCode"].ToString();
					}
				}
			}

			//dataGridView1.SelectedCells[0].Selected = true;
			kartoncombobox.SelectedIndex = 0;
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

		public List<List<string>> allData = new List<List<string>>();
		public int listId = 0;
		private void addbelowbtn_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(material2txtbox.Text) &&
				!String.IsNullOrEmpty(counttxtbox.Text) &&
				!System.Text.RegularExpressions.Regex.IsMatch(counttxtbox.Text, "[^0-9]") &&
				!String.IsNullOrEmpty(companycodetxtbox.Text) &&
				!String.IsNullOrEmpty(companynametxtbox.Text) &&
				!String.IsNullOrEmpty(description2txtbox.Text) &&
				!String.IsNullOrEmpty(unittxtbox.Text) &&
				!String.IsNullOrEmpty(dateTimePicker2.Text))
			{
				listId++;
				allData.Add(new List<string> {material2txtbox.Text,
										  companynametxtbox.Text,
										  description2txtbox.Text,
										  companycodetxtbox.Text,
										  unittxtbox.Text,
										  counttxtbox.Text,
										  operatortxtbox.Text,
										  billtxtbox.Text,
										  dateTimePicker1.Text,
										  dateTimePicker2.Text,
										  lotnotxtbox.Text,
										  revisiontxtbox.Text,
										  boxcodetxtbox.Text,
										  grossweighttxtbox.Text,
										  singlechkbox.Checked.ToString(),
										  quartedchkbox.Checked.ToString(),
										  kartoncombobox.Text,
										  listId.ToString()}
										  );

				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(dataGridView2);
				newRow.Cells[0].Value = companynametxtbox.Text;
				newRow.Cells[1].Value = material2txtbox.Text;
				newRow.Cells[2].Value = description2txtbox.Text;
				newRow.Cells[3].Value = companycodetxtbox.Text;
				newRow.Cells[4].Value = counttxtbox.Text;
				newRow.Cells[5].Value = unittxtbox.Text;
				newRow.Cells[6].Value = grossweighttxtbox.Text;
				newRow.Cells[7].Value = kartoncombobox.SelectedItem;
				dataGridView2.Rows.Add(newRow);
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
				unittxtbox.Text = dt.Cells["Unit"].Value.ToString();
			}
		}

		private void print_Click(object sender, EventArgs e)
		{
			ArrayList printerData = new ArrayList();

			if (dataGridView2.Rows.Count > 0)
			{
				foreach (var list in allData)
				{
					DocumantTransactions doc = new DocumantTransactions();
					// Create a MigraDoc document
					Document document = doc.CreateDocument(materialCode: list[0],
													   lotno: list[10],
													   companyName: list[1],
													   billno: list[7],
													   billnoDate: list[8],
													   boxcode: list[12],
													   count: list[5],
													   unit: list[4],
													   productiondate: list[9],
													   companyCode: list[3]);
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
					BoxCodeUpdateMain(time);
					filename += time + ".pdf";
					pdfRenderer.PdfDocument.Save(filename);
					// ...and start a viewer.
					Process.Start(filename);
				}
				Form1_Load(sender, e);
			}
			else
			{
				MessageBox.Show("There is no data to print!");
			}
		}

		public void BoxCodeUpdateMain(long time)
		{
			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "INSERT INTO Box (BoxCode) VALUES (@code)";
				OleDbParameter parameter = new OleDbParameter();
				parameter.ParameterName = "@code";
				parameter.Value = time.ToString();
				DatabaseTransaction db = new DatabaseTransaction();
				db.BoxCodeUpdate(cnn, query, parameter);
			}
				
		}

		private void newStock_Click(object sender, EventArgs e)
		{
			var configSettings = new List<string>(ConfigurationSettings.AppSettings["ReceiverCompany1"].Split(new char[] { ';' }));

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

			unittxtbox.Enabled = true;
			unittxtbox.ReadOnly = false;
			unittxtbox.Text = null;

			counttxtbox.Enabled = false;
			counttxtbox.Text = null;

			operatortxtbox.Enabled = false;
			operatortxtbox.Text = null;
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
			print.Enabled = false;
			revisiontxtbox.Enabled = false;
			revisiontxtbox.Text = null;
			boxcodetxtbox.Enabled = false;
			boxcodetxtbox.Text = null;
			grossweighttxtbox.Enabled = false;
			grossweighttxtbox.Text = null;
			singlechkbox.Enabled = false;
			quartedchkbox.Enabled = false;
			kartoncombobox.Enabled = false;
			materialtxtbox.Enabled = false;
			materialbtn.Enabled = false;
			reloadbtn.Enabled = false;
			dataGridView1.Enabled = false;
			dateTimePicker1.Enabled = false;
			backbtn.Enabled = true;

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

		private void unittxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(unitLabel, unittxtbox);
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
			   !String.IsNullOrEmpty(unittxtbox.Text);

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
						par.Add(new OleDbParameter("@unit", unittxtbox.Text));
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
		}
	}
}
