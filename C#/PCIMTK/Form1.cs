using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PDFtoPrinter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PCIMTK
{
	public partial class Form1 : Form
	{
		public string mode;

		public Form1()
		{
			InitializeComponent();

			stockView.ColumnCount = 5;
			stockView.Columns[0].Name = "Company Code";
			stockView.Columns[1].Name = "Company Name";
			stockView.Columns[2].Name = "Material Code";
			stockView.Columns[3].Name = "Description";
			stockView.Columns[4].Name = "Unit";
		}

		[Obsolete]
		private void Form1_Load(object sender, EventArgs e)
		{
			UserModeDefaults.SelectionMode(this);
			UserModeDefaults.RequirementControlSelectionMode(this);
			DatabaseTransactions db = new DatabaseTransactions();
			db.GetData(this);
			PrinterTransactions pr = new PrinterTransactions();
			pr.ShowAvailablePrinters(this);
		}

		[Obsolete]
		private void refreshStockBtn_Click(object sender, EventArgs e)
		{
			filterTxtBox.Text = null;
			DatabaseTransactions db = new DatabaseTransactions();
			db.GetData(this);
		}

		private void stockView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			UserModeDefaults.SelectionMode(this);

			if (e.RowIndex >= 0)
			{
				DataGridViewRow dt = stockView.Rows[e.RowIndex];
				companyCodeTxtBox.Text = dt.Cells["Company Code"].Value.ToString();
				companyNameTxtBox.Text = dt.Cells["Company Name"].Value.ToString();
				mtrlCodeTxtBox.Text = dt.Cells["Material Code"].Value.ToString();
				descriptionTxtBox.Text = dt.Cells["Description"].Value.ToString();
				unitComboBox.SelectedItem = dt.Cells["Unit"].Value.ToString();
			}

			UserModeDefaults.RequirementControlSelectionMode(this);
		}

		private void addBelowBtn_Click(object sender, EventArgs e)
		{
			// Control stage
			if (UserModeDefaults.RequirementControlSelectionMode(this))
			{
				for (int i = 0; i < numberOfBoxNumber.Value; i++)
				{
					documantView.Rows.Add(companyCodeTxtBox.Text,
										  companyNameTxtBox.Text,
										  mtrlCodeTxtBox.Text,
										  descriptionTxtBox.Text,
										  unitComboBox.Text,
										  (Convert.ToInt32(quantityTxtBox.Text) / numberOfBoxNumber.Value).ToString("0."),
										  billNoTxtBox.Text,
										  billDatePicker.Text,
										  productionDatePicker.Text,
										  lotNoTxtBox.Text,
										  revisionTxtBox.Text,
										  numberOfBoxNumber.Value / numberOfBoxNumber.Value);
				}

				UserModeDefaults.SelectionMode(this);
			}
			
		}

		#region TextChangedMethods
		[Obsolete]
		private void filterTxtBox_TextChanged(object sender, EventArgs e)
		{
			DatabaseTransactions db = new DatabaseTransactions();
			db.GetData(this, filterTxtBox.Text.ToString());
		}

		private void mtrlCodeTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection")	UserModeDefaults.RequirementControlSelectionMode(this);
			else                            UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void companyNameTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void companyCodeTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void unitComboBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void quantityTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void productionDatePicker_ValueChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void lotNoTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void numberOfBoxNumber_ValueChanged(object sender, EventArgs e)
		{
			if (this.mode == "Selection") UserModeDefaults.RequirementControlSelectionMode(this);
			else UserModeDefaults.RequirementControlAddingMode(this);
		}
		#endregion

		private void newBtn_Click(object sender, EventArgs e)
		{
			UserModeDefaults.AddingMode(this);
			UserModeDefaults.RequirementControlAddingMode(this);
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			UserModeDefaults.SelectionMode(this);
			UserModeDefaults.RequirementControlSelectionMode(this);
		}

		[Obsolete]
		private void saveBtn_Click(object sender, EventArgs e)
		{
			DatabaseTransactions db = new DatabaseTransactions();
			bool validation = db.InsertData(this);

			if (validation)
			{
				Form1_Load(sender, e);
			}
		}

		private void deleteSelectedBtn_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow cell in documantView.SelectedRows)
			{
				documantView.Rows.RemoveAt(cell.Index);
			}
		}

		private void deleteAllBtn_Click(object sender, EventArgs e)
		{
			documantView.Rows.Clear();
		}

		private void refreshPrinterBtn_Click(object sender, EventArgs e)
		{
			PrinterTransactions pr = new PrinterTransactions();
			pr.ShowAvailablePrinters(this);
		}

		[Obsolete]
		private void createDocumantBtn_Click(object sender, EventArgs e)
		{
			string filename = DocumantTransactions.RenderDocument(this);
			Process.Start(filename);
			progressBar.Value = 0;
		}

		private void printBtn_Click(object sender, EventArgs e)
		{
			string filename = DocumantTransactions.RenderDocument(this);

			PrintDocument pd = new PrintDocument();

			var printer = new PDFtoPrinterPrinter();
			printer.Print(new PrintingOptions(printersComboBox.SelectedItem.ToString(), filename));
			progressBar.Value = 0;
		}
	}
}
