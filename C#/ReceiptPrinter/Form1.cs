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
			string cnnString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\muss\\Desktop\\Database\\Database1.accdb";
			//OleDbConnection cnn = new OleDbConnection(cnnString);
			OleDbConnection cnn = new OleDbConnection(cnnString);
			cnn.Open();
			OleDbDataAdapter _dataAdapter = new OleDbDataAdapter("SELECT * FROM Stock", cnnString);
			DataSet _dataSet = new DataSet();
			_dataAdapter.Fill(_dataSet, "Stock");
			databaseView.DataSource = _dataSet.Tables["Stock"];
		}
	}
}