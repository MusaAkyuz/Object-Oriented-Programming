﻿using System;
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

			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				material2txtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(companynametxtbox.Text))
			{
				companynametxtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(companycodetxtbox.Text))
			{
				companycodetxtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(description2txtbox.Text))
			{
				description2txtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(unittxtbox.Text))
			{
				unittxtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(counttxtbox.Text))
			{
				counttxtbox.BackColor = Color.Tomato;
			}
			if (String.IsNullOrEmpty(productiontxtbox.Text))
			{
				productiontxtbox.BackColor = Color.Tomato;
			}

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

		private void button4_Click(object sender, EventArgs e)
		{
			dataGridView2.Rows.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.dataGridView2.SelectedRows.Count > 0)
			{
				dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
			}
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

		private void counttxtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(counttxtbox.Text))
			{
				counttxtbox.BackColor = Color.Tomato;
			}
			else
			{
				counttxtbox.BackColor = DefaultBackColor;
			}
		}

		private void material2txtbox_TextChanged(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(material2txtbox.Text))
			{
				material2txtbox.BackColor = Color.Tomato;	
			}
			else
			{
				material2txtbox.BackColor = DefaultBackColor;
			}
		}

		private void companynametxtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				companynametxtbox.BackColor = Color.Tomato;
			}
			else
			{
				companynametxtbox.BackColor = DefaultBackColor;
			}
		}

		private void description2txtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				description2txtbox.BackColor = Color.Tomato;
			}
			else
			{
				description2txtbox.BackColor = DefaultBackColor;
			}
		}

		private void companycodetxtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				companycodetxtbox.BackColor = Color.Tomato;
			}
			else
			{
				companycodetxtbox.BackColor = DefaultBackColor;
			}
		}

		private void unittxtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				unittxtbox.BackColor = Color.Tomato;
			}
			else
			{
				unittxtbox.BackColor = DefaultBackColor;
			}
		}

		private void productiontxtbox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(material2txtbox.Text))
			{
				productiontxtbox.BackColor = Color.Tomato;
			}
			else
			{
				productiontxtbox.BackColor = DefaultBackColor;
			}
		}
	}
}
