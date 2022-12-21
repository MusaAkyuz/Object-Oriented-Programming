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
	}
}