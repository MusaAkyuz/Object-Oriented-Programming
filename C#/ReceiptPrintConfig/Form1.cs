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

namespace ReceiptPrintConfig
{
	public partial class Form1 : Form
	{
		private string providerName = "Deneme";
		DatabaseTransaction db = new DatabaseTransaction();

		public Form1()
		{
			InitializeComponent();
			dataGridView1.ColumnCount = 6;
			dataGridView1.Columns[0].Name = "Company Code"; 
			dataGridView1.Columns[1].Name = "Company Name";
			dataGridView1.Columns[2].Name = "Material Code";
			dataGridView1.Columns[3].Name = "Description";
			dataGridView1.Columns[4].Name = "Unit";
			dataGridView1.Columns[5].Name = "Production Date";

			dataGridView2.ColumnCount = 8;
			dataGridView2.Columns[0].Name = "Company Name";
			dataGridView2.Columns[1].Name = "Material Code";
			dataGridView2.Columns[2].Name = "Description";
			dataGridView2.Columns[3].Name = "Company Code";
			dataGridView2.Columns[4].Name = "Count";
			dataGridView2.Columns[5].Name = "Unit";
			dataGridView2.Columns[6].Name = "Box Gross";
			dataGridView2.Columns[7].Name = "Karton";

			kartoncombobox.SelectedIndex = 0;

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				cnn.Open();
				string query = "SELECT Id, BoxCode FROM [Box]";
				OleDbDataReader dataReader;
				OleDbCommand cmd = new OleDbCommand(query, cnn);

				dataReader = cmd.ExecuteReader();
				if (dataReader.HasRows)
				{
					while(dataReader.Read())
					{
						boxcodetxtbox.Text = dataReader["Id"].ToString();
					}
				}
			}
			//foreach (DataGridViewColumn col in dataGridView1.Columns)
			//{
			//	dataGridView1.Columns[col.Index].DefaultCellStyle.BackColor = Color.Lavender;
			//}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TextBoxControl(material2txtbox);
			TextBoxControl(companynametxtbox);
			TextBoxControl(description2txtbox);
			TextBoxControl(companycodetxtbox);
			TextBoxControl(unittxtbox);
			TextBoxControl(counttxtbox);
			TextBoxControl(productiontxtbox);

			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock";
				ArrayList row = db.QueryToArrayList(cnn, query, null);

				dataGridView1.Rows.Clear();

				for (int i = 0; i < row.Count; i+=6)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView1);
					newRow.Cells[0].Value = row[i];
					newRow.Cells[1].Value = row[i + 1];
					newRow.Cells[2].Value = row[i + 2];
					newRow.Cells[3].Value = row[i + 3];
					newRow.Cells[4].Value = row[i + 4];
					newRow.Cells[5].Value = row[i + 5];
					dataGridView1.Rows.Add(newRow);
				}
			}
			dataGridView1.SelectedCells[0].Selected = true;
		}

		private void materialbtn_Click(object sender, EventArgs e)
		{
			descriptiontxtbox.Text = String.Empty;
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

					for (int i = 0; i < row.Count; i += 6)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = row[i];
						newRow.Cells[1].Value = row[i + 1];
						newRow.Cells[2].Value = row[i + 2];
						newRow.Cells[3].Value = row[i + 3];
						newRow.Cells[4].Value = row[i + 4];
						newRow.Cells[5].Value = row[i + 5];
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

		private void descriptionbtn_Click(object sender, EventArgs e)
		{
			materialtxtbox.Text = String.Empty;
			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE Description LIKE @code";
				OleDbParameter parameter = new OleDbParameter();
				parameter.ParameterName = "@code";
				parameter.Value = descriptiontxtbox.Text.ToLower();
				if (descriptiontxtbox.Text != "")
				{
					ArrayList row = db.QueryToArrayList(cnn, query, parameter);

					dataGridView1.Rows.Clear();

					for (int i = 0; i < row.Count; i += 6)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = row[i];
						newRow.Cells[1].Value = row[i + 1];
						newRow.Cells[2].Value = row[i + 2];
						newRow.Cells[3].Value = row[i + 3];
						newRow.Cells[4].Value = row[i + 4];
						newRow.Cells[5].Value = row[i + 5];
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
			descriptiontxtbox.Text = String.Empty;
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
				!String.IsNullOrEmpty(unittxtbox.Text) &&
				!String.IsNullOrEmpty(productiontxtbox.Text))
			{
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
				dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
			}
		}
		private void deleteAll_Click(object sender, EventArgs e)
		{
			dataGridView2.Rows.Clear();
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				material2txtbox.Text = row.Cells["Material Code"].Value.ToString();
				companycodetxtbox.Text = row.Cells["Company Code"].Value.ToString();
				companynametxtbox.Text = row.Cells["Company Name"].Value.ToString();
				unittxtbox.Text = row.Cells["Unit"].Value.ToString();
				productiontxtbox.Text = row.Cells["Production Date"].Value.ToString();
				description2txtbox.Text = row.Cells["Description"].Value.ToString();
			}
		}

		private Document CreateDocument(string companyName,
										string materialCode,
										string description,
										string companyCode,
										string count,
										string unit,
										string boxGross,
										string karton)
		{
			// Create a new MigraDoc document
			Document document = new Document();

			// Add a section to the document
			Section section = document.AddSection();
			section.PageSetup.TopMargin = "1.5cm";

			//Arçelik and qr code image
			var image = section.AddImage("arcelik.png");
			image.Width = new Unit(150, UnitType.Point); ;
			image.Height = new Unit(150, UnitType.Point);
			image.Left = ShapePosition.Center;
			image.RelativeVertical = RelativeVertical.Line;
			image.RelativeHorizontal = RelativeHorizontal.Margin;
			image.Top = ShapePosition.Top;
			image.WrapFormat.Style = WrapStyle.Through;
			image = section.AddImage("qr.png");
			image.Width = new Unit(80, UnitType.Point); ;
			image.Height = new Unit(80, UnitType.Point);
			image.Left = ShapePosition.Right;

			Paragraph par;

			//Arçelik A.Ş.
			par = section.AddParagraph();
			par.Format.SpaceBefore = "3.3cm";
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 15;
			par.Format.Font.Bold = true;
			par.AddText("Arçelik A.Ş.");

			//PCI
			par = section.AddParagraph();
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 11;
			par.AddText("PCI");

			//Malzeme Tanıtım Kartı
			par = section.AddParagraph();
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 11;
			par.AddText("Malzeme Tanitim Karti");
			par.Format.SpaceAfter = "1.4cm";

			//All information
			Table table = section.AddTable();
			table.Format.SpaceBefore = "0.3cm";
			Column _headers = table.AddColumn("3cm");
			Column _doublePoint = table.AddColumn("0.5cm");
			Column _values = table.AddColumn("3cm");

			Row row = table.AddRow();
			row.Cells[0].AddParagraph("Company name");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(companyName);
			row.Cells[2].Format.Font.Bold = true;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Material Code");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(materialCode);

			row = table.AddRow();
			row.Cells[0].AddParagraph("Description");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(description);

			row = table.AddRow();
			row.Cells[0].AddParagraph("Company Code");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(companyCode);

			row = table.AddRow();
			row.Cells[0].AddParagraph("Count");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(count);

			row = table.AddRow();
			row.Cells[0].AddParagraph("Unit");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(unit);
			row.Cells[2].Format.Font.Bold = true;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Box Gross");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(boxGross);

			row = table.AddRow();
			row.Cells[0].AddParagraph("Karton");
			row.Cells[1].AddParagraph(":");
			row.Cells[2].AddParagraph(karton);

			return document;
		}

		private void print_Click(object sender, EventArgs e)
		{
			ArrayList printerData = new ArrayList();

			if (dataGridView2.Rows.Count > 0)
			{
				foreach (DataGridViewRow row in dataGridView2.Rows)
				{
					// Create a MigraDoc document
					Document document = CreateDocument(companyName: row.Cells[0].Value.ToString(),
													   materialCode: row.Cells[1].Value.ToString(),
													   description: row.Cells[2].Value.ToString(),
													   companyCode: row.Cells[3].Value.ToString(),
													   count: row.Cells[4].Value.ToString(),
													   unit: row.Cells[5].Value.ToString(),
													   boxGross: row.Cells[6].Value.ToString(),
													   karton: row.Cells[7].Value.ToString());
					document.UseCmykColor = true;
					const bool unicode = false;
					PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);

					// Associate the MigraDoc document with a renderer
					pdfRenderer.Document = document;

					// Layout and render document to PDF
					pdfRenderer.RenderDocument();

					// Save the document...
					string filename = "C:\\Users\\muss\\Desktop\\Receiver";
					filename += DateTime.Now.ToFileTime() + ".pdf";
					pdfRenderer.PdfDocument.Save(filename);
					// ...and start a viewer.
					Process.Start(filename);
				}
			}
			else
			{
				MessageBox.Show("There is no data to print!");
			}
		}

		private void newStock_Click(object sender, EventArgs e)
		{
			////ReadOnly part
			//material2txtbox.ReadOnly = false;
			//companynametxtbox.ReadOnly = false;
			//description2txtbox.ReadOnly = false;
			//companycodetxtbox.ReadOnly = false;
			//unittxtbox.ReadOnly = false;
			//counttxtbox.ReadOnly = true;
			//companycodetxtbox.ReadOnly = true;
			//operatortxtbox.ReadOnly = true;
			//billtxtbox.ReadOnly = true;
			//billdatetxtbox.ReadOnly = true;
			//productiontxtbox.ReadOnly = false;
			//lotnotxtbox.ReadOnly = true;
			//revisiontxtbox.ReadOnly = true;
			//boxcodetxtbox.ReadOnly = true;
			//grossweighttxtbox.ReadOnly = true;
			//singlechkbox.Enabled = false;
			//quartedchkbox.Enabled = false;
			//kartoncombobox.Enabled = false;
			
		}

		public void TextBoxControl(System.Windows.Forms.TextBox txt, string regex = null)
		{
			if(txt.Enabled == true)
			{
				if(!String.IsNullOrEmpty(regex))
				{
					if (String.IsNullOrEmpty(txt.Text) || System.Text.RegularExpressions.Regex.IsMatch(txt.Text, regex))
					{
						txt.BackColor = System.Drawing.Color.Tomato;
					}
					else
					{
						txt.BackColor = DefaultBackColor;
					}
				}
				else
				{
					if (String.IsNullOrEmpty(txt.Text))
					{
						txt.BackColor = System.Drawing.Color.Tomato;
					}
					else
					{
						txt.BackColor = DefaultBackColor;
					}
				}
			}
			else
			{
				txt.BackColor = DefaultBackColor;
			}
		}

		private void material2txtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(material2txtbox);
		}

		private void companynametxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(companynametxtbox);
		}

		private void description2txtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(description2txtbox);
		}

		private void companycodetxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(companycodetxtbox);
		}

		private void unittxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(unittxtbox);
		}

		private void counttxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(counttxtbox, "[^0-9]");
		}

		private void productiontxtbox_TextChanged(object sender, EventArgs e)
		{
			TextBoxControl(productiontxtbox);
		}
	}
}
