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

namespace ReceiptPrintConfig
{
	public partial class Form1 : Form
	{
		private string providerName = "Deneme";
		DatabaseTransaction db = new DatabaseTransaction();

		public Form1()
		{
			InitializeComponent();
			dataGridView1.ColumnCount = 5;
			dataGridView1.Columns[0].Name = "Company";
			dataGridView1.Columns[1].Name = "MaterialCode";
			dataGridView1.Columns[2].Name = "Description";
			dataGridView1.Columns[3].Name = "Unit";
			dataGridView1.Columns[4].Name = "CrateDateTime";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(db.GetConnectionStrings(providerName)))
			{
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock";
				ArrayList row = db.QueryToArrayList(cnn, query, null);

				dataGridView1.Rows.Clear();

				for (int i = 0; i < row.Count; i+=5)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView1);
					newRow.Cells[0].Value = row[i];
					newRow.Cells[1].Value = row[i + 1];
					newRow.Cells[2].Value = row[i + 2];
					newRow.Cells[3].Value = row[i + 3];
					newRow.Cells[4].Value = row[i + 4];
					dataGridView1.Rows.Add(newRow);
				}
			}
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

					for (int i = 0; i < row.Count; i += 5)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = row[i];
						newRow.Cells[1].Value = row[i + 1];
						newRow.Cells[2].Value = row[i + 2];
						newRow.Cells[3].Value = row[i + 3];
						newRow.Cells[4].Value = row[i + 4];
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
	}
}
