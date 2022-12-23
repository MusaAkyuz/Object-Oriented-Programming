using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace ReceiptPrintAccess
{
	public partial class Form1 : Form
	{
		string cnnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\muss\\Desktop\\Database\\Arcelik.mdb";
		private static ArrayList Id = new ArrayList();
		private static ArrayList MaterialCode = new ArrayList();
		private static ArrayList Description = new ArrayList();
		private static ArrayList Unit = new ArrayList();
		private static ArrayList CreateDateTime = new ArrayList();

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
			Id.Clear();
			MaterialCode.Clear();
			Description.Clear();
			Unit.Clear();
			CreateDateTime.Clear();
			dataGridView1.Rows.Clear();

			using (OleDbConnection cnn = new OleDbConnection(cnnStr))
			{
				//OleDbDataAdapter _adapter = new OleDbDataAdapter("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock", cnn);
				//DataSet _dataset = new DataSet();
				//_adapter.Fill(_dataset, "Stock");
				//dataGridView1.DataSource = _dataset.Tables["Stock"];
				cnn.Open();
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock";
				OleDbDataReader row;
				OleDbCommand cmd = new OleDbCommand(query, cnn);
				row = cmd.ExecuteReader();

				if (row.HasRows)
				{
					while (row.Read())
					{
						Id.Add("112");
						MaterialCode.Add(row["MaterialCode"].ToString());
						Description.Add(row["Description"].ToString());
						Unit.Add(row["Unit"].ToString());
						CreateDateTime.Add(row["CreateDateTime"].ToString());
					}
				}

				dataGridView1.Rows.Clear();

				for (int i = 0; i < MaterialCode.Count; i++)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView1);
					newRow.Cells[0].Value = Id[i];
					newRow.Cells[1].Value = MaterialCode[i];
					newRow.Cells[2].Value = Description[i];
					newRow.Cells[3].Value = Unit[i];
					newRow.Cells[4].Value = CreateDateTime[i];
					dataGridView1.Rows.Add(newRow);
				}
				cnn.Close();
			}
		}

		private void materialbtn_Click(object sender, EventArgs e)
		{
			Id.Clear();
			MaterialCode.Clear();
			Description.Clear();
			Unit.Clear();
			CreateDateTime.Clear();
			dataGridView1.Rows.Clear();
			descriptiontxtbox.Text = String.Empty;

			if (!string.IsNullOrWhiteSpace(materialtxtbox.Text))
			{
				using (OleDbConnection cnn = new OleDbConnection(cnnStr))
				{
					//OleDbCommand cmd = new OleDbCommand("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE MaterialCode LIKE @code", cnn);
					//cmd.Parameters.Add("@code", string.Format("%{0}%", materialtxtbox.Text));
					//OleDbDataAdapter _adapter = new OleDbDataAdapter();
					//_adapter.SelectCommand = cmd;
					//DataSet _dataset = new DataSet();
					//_adapter.Fill(_dataset, "Stock");
					//dataGridView1.DataSource = _dataset.Tables["Stock"];
					cnn.Open();
					string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE MaterialCode LIKE @code";
					OleDbDataReader row;
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					cmd.Parameters.Add("@code", string.Format("%{0}%", materialtxtbox.Text));
					row = cmd.ExecuteReader();

					if (row.HasRows)
					{
						while (row.Read())
						{
							Id.Add("112");
							MaterialCode.Add(row["MaterialCode"].ToString());
							Description.Add(row["Description"].ToString());
							Unit.Add(row["Unit"].ToString());
							CreateDateTime.Add(row["CreateDateTime"].ToString());
						}
					}

					for (int i = 0; i < MaterialCode.Count; i++)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = Id[i];
						newRow.Cells[1].Value = MaterialCode[i];
						newRow.Cells[2].Value = Description[i];
						newRow.Cells[3].Value = Unit[i];
						newRow.Cells[4].Value = CreateDateTime[i];
						dataGridView1.Rows.Add(newRow);
					}
					cnn.Close();
				}
			}
		}

		private void reloadbtn_Click(object sender, EventArgs e)
		{
			Id.Clear();
			MaterialCode.Clear();
			Description.Clear();
			Unit.Clear();
			CreateDateTime.Clear();
			dataGridView1.Rows.Clear();
			materialtxtbox.Text = String.Empty;
			descriptiontxtbox.Text = String.Empty;

			using (OleDbConnection cnn = new OleDbConnection(cnnStr))
			{
				//OleDbDataAdapter _adapter = new OleDbDataAdapter("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock", cnn);
				//DataSet _dataset = new DataSet();
				//_adapter.Fill(_dataset, "Stock");
				//dataGridView1.DataSource = _dataset.Tables["Stock"];
				cnn.Open();
				string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock";
				OleDbDataReader row;
				OleDbCommand cmd = new OleDbCommand(query, cnn);
				row = cmd.ExecuteReader();

				if (row.HasRows)
				{
					while (row.Read())
					{
						Id.Add("112");
						MaterialCode.Add(row["MaterialCode"].ToString());
						Description.Add(row["Description"].ToString());
						Unit.Add(row["Unit"].ToString());
						CreateDateTime.Add(row["CreateDateTime"].ToString());
					}
				}

				dataGridView1.Rows.Clear();
				for (int i = 0; i < Id.Count; i++)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dataGridView1);
					newRow.Cells[0].Value = Id[i];
					newRow.Cells[1].Value = MaterialCode[i];
					newRow.Cells[2].Value = Description[i];
					newRow.Cells[3].Value = Unit[i];
					newRow.Cells[4].Value = CreateDateTime[i];
					dataGridView1.Rows.Add(newRow);
				}
				cnn.Close();
			}
		}

		private void descriptionbtn_Click(object sender, EventArgs e)
		{
			Id.Clear();
			MaterialCode.Clear();
			Description.Clear();
			Unit.Clear();
			CreateDateTime.Clear();
			dataGridView1.Rows.Clear();
			materialtxtbox.Text = String.Empty;

			if (!string.IsNullOrWhiteSpace(descriptiontxtbox.Text))
			{
				using (OleDbConnection cnn = new OleDbConnection(cnnStr))
				{
					//OleDbCommand cmd = new OleDbCommand("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE Description LIKE @code", cnn);
					//cmd.Parameters.Add("@code", string.Format("%{0}%", descriptiontxtbox.Text));
					//OleDbDataAdapter _adapter = new OleDbDataAdapter();
					//_adapter.SelectCommand = cmd;
					//DataSet _dataset = new DataSet();
					//_adapter.Fill(_dataset, "Stock");
					//dataGridView1.DataSource = _dataset.Tables["Stock"];
					cnn.Open();
					string query = "SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE Description LIKE @code";
					OleDbDataReader row;
					OleDbCommand cmd = new OleDbCommand(query, cnn);
					cmd.Parameters.Add("@code", string.Format("%{0}%", descriptiontxtbox.Text));
					row = cmd.ExecuteReader();

					if (row.HasRows)
					{
						while (row.Read())
						{
							Id.Add("112");
							MaterialCode.Add(row["MaterialCode"].ToString());
							Description.Add(row["Description"].ToString());
							Unit.Add(row["Unit"].ToString());
							CreateDateTime.Add(row["CreateDateTime"].ToString());
						}
					}

					dataGridView1.Rows.Clear();
					for (int i = 0; i < Id.Count; i++)
					{
						DataGridViewRow newRow = new DataGridViewRow();
						newRow.CreateCells(dataGridView1);
						newRow.Cells[0].Value = Id[i];
						newRow.Cells[1].Value = MaterialCode[i];
						newRow.Cells[2].Value = Description[i];
						newRow.Cells[3].Value = Unit[i];
						newRow.Cells[4].Value = CreateDateTime[i];
						dataGridView1.Rows.Add(newRow);
					}
					cnn.Close();
				}
			}
		}
	}
}