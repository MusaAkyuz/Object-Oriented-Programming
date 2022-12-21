using System.Data;
using System.Data.OleDb;

namespace ReceiptPrintAccess
{
	public partial class Form1 : Form
	{
		string cnnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\muss\\Desktop\\Database\\Arcelik.mdb";
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using (OleDbConnection cnn = new OleDbConnection(cnnStr))
			{
				OleDbDataAdapter _adapter = new OleDbDataAdapter("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock", cnn);
				DataSet _dataset = new DataSet();
				_adapter.Fill(_dataset, "Stock");
				dataGridView1.DataSource = _dataset.Tables["Stock"];
			}
		}

		private void materialbtn_Click(object sender, EventArgs e)
		{
			descriptiontxtbox.Text = String.Empty;
			if (!string.IsNullOrWhiteSpace(materialtxtbox.Text))
			{
				using (OleDbConnection cnn = new OleDbConnection(cnnStr))
				{
					OleDbCommand cmd = new OleDbCommand("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE MaterialCode LIKE @code", cnn);
					cmd.Parameters.Add("@code", string.Format("%{0}%", materialtxtbox.Text));
					OleDbDataAdapter _adapter = new OleDbDataAdapter();
					_adapter.SelectCommand = cmd;
					DataSet _dataset = new DataSet();
					_adapter.Fill(_dataset, "Stock");
					dataGridView1.DataSource = _dataset.Tables["Stock"];
				}
			}
		}

		private void reloadbtn_Click(object sender, EventArgs e)
		{
			materialtxtbox.Text = String.Empty;
			descriptiontxtbox.Text = String.Empty;
			using (OleDbConnection cnn = new OleDbConnection(cnnStr))
			{
				OleDbDataAdapter _adapter = new OleDbDataAdapter("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock", cnn);
				DataSet _dataset = new DataSet();
				_adapter.Fill(_dataset, "Stock");
				dataGridView1.DataSource = _dataset.Tables["Stock"];
			}
		}

		private void descriptionbtn_Click(object sender, EventArgs e)
		{
			materialtxtbox.Text = String.Empty;
			if (!string.IsNullOrWhiteSpace(descriptiontxtbox.Text))
			{
				using (OleDbConnection cnn = new OleDbConnection(cnnStr))
				{
					OleDbCommand cmd = new OleDbCommand("SELECT MaterialCode, Description, Unit, CreateDateTime FROM Stock WHERE Description LIKE @code", cnn);
					cmd.Parameters.Add("@code", string.Format("%{0}%", descriptiontxtbox.Text));
					OleDbDataAdapter _adapter = new OleDbDataAdapter();
					_adapter.SelectCommand = cmd;
					DataSet _dataset = new DataSet();
					_adapter.Fill(_dataset, "Stock");
					dataGridView1.DataSource = _dataset.Tables["Stock"];
				}
			}
		}
	}
}