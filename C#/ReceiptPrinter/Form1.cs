using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
//using System.Data.SqlClient;

namespace ReceiptPrinter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Connection settings
			string cnnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\muss\\Desktop\\Database\\Database1.accdb";
			//string cnnString2 = "Data Source=.;Initial Catalog=Customer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			//OleDbConnection cnn = new OleDbConnection(cnnString);
			OleDbConnection cnn = new OleDbConnection(cnnString);
			//SqlConnection cnn = new SqlConnection(cnnString2);
			cnn.Open();
			OleDbDataAdapter _dataAdapter = new OleDbDataAdapter("SELECT * FROM Stock", cnnString);
			//SqlDataAdapter _dataAdapter = new SqlDataAdapter("SELECT * FROM Customer", cnnString2);
			DataSet _dataSet = new DataSet();
			_dataAdapter.Fill(_dataSet, "Stock");
			databaseView.DataSource = _dataSet.Tables["Stock"];
		}
	}
}