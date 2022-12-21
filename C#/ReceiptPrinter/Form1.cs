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
using ReceiptPrinter.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
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
			using (var context = new ArcelikDbContext())
			{
				var stc = context.Stocks.FromSqlRaw("SELECT * FROM STOCKS").ToList();
				databaseView.DataSource = stc;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using(var context = new ArcelikDbContext())
			{
				var stc = context.Stocks.FromSqlRaw("SELECT * FROM STOCKS").ToList();
				databaseView.DataSource = stc;
			}
		}

		private void filterbtn_Click(object sender, EventArgs e)
		{
			using (var context = new ArcelikDbContext())
			{
				if (metarialCodenmbbox != String.Empty && descriptiontxtbox != String.Empty)
				{
					var stc = context.Stocks.FromSqlRaw("SELECT * FROM STOCKS").ToList();
					databaseView.DataSource = stc;
				}
				if (!metarialCodenmbbox != String.Empty && !descriptiontxtbox != String.Empty)
				{
					MessageBox.Show("Cannot fill both area!");
				}
				else if (!metarialCodenmbbox != String.Empty)
				{

					int metarialCode = Convert.ToInt32(metarialCodenmbbox.Text);
					var stc = context.Stocks.FromSqlRaw("SELECT * FROM STOCKS").Where(s => s.MetarialCode == metarialCode).ToList();
					databaseView.DataSource = stc;
				}
				else if (!descriptiontxtbox != String.Empty)
				{
					string description = descriptiontxtbox.Text;
					var stc = context.Stocks.FromSqlRaw("SELECT * FROM STOCKS").Where(s => s.Description == description).ToList();
					databaseView.DataSource = stc;
				}
				else
				{
					MessageBox.Show("No such entry!");
				}
			}
		}
	}
}