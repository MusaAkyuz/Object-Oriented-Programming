using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PCIMTK
{
	internal class UserModeDefaults
	{
		public static void SelectionMode(Form1 f)
		{
			f.mode = "Selection";

			f.stockView.Enabled =				true;
			f.filterTxtBox.Enabled =			true;
			f.refreshStockBtn.Enabled =			true;
			f.quantityTxtBox.Enabled =			true;
			f.billNoTxtBox.Enabled =			true;
			f.billDatePicker.Enabled =			true;
			f.productionDatePicker.Enabled =	true;
			f.lotNoTxtBox.Enabled =				true;
			f.revisionTxtBox.Enabled =			true;
			f.numberOfBoxNumber.Enabled =		true;
			f.addBelowBtn.Enabled =				true;
			f.newBtn.Enabled =					true;
			f.documantView.Enabled =			true;
			f.deleteAllBtn.Enabled =			true;
			f.deleteSelectedBtn.Enabled =		true;
			f.printBtn.Enabled =				true;
			f.printersComboBox.Enabled =		true;
			f.progressBar.Enabled =				true;
			f.createDocumantBtn.Enabled =		true;
			f.refreshPrinterBtn.Enabled =		true;
			f.externalCheck.Enabled =			true;

			f.mtrlCodeTxtBox.Enabled =			false;
			f.companyNameTxtBox.Enabled =		false;
			f.companyCodeTxtBox.Enabled =		false;
			f.descriptionTxtBox.Enabled =		false;
			f.unitComboBox.Enabled =			false;
			f.backBtn.Enabled =					false;
			f.saveBtn.Enabled =					false;
			f.externalTxtBox.Enabled =			false;

			// Initializing Text and Values
			f.filterTxtBox.Text = null;
			f.mtrlCodeTxtBox.Text = null;
			f.companyNameTxtBox.Text = null;
			f.companyCodeTxtBox.Text = null;
			f.descriptionTxtBox.Text = null;
			f.unitComboBox.Text = null;
			f.quantityTxtBox.Text = null;
			f.billNoTxtBox.Text = null;
			f.billDatePicker.Value = DateTime.Now;
			f.productionDatePicker.Value = DateTime.Now;
			f.lotNoTxtBox.Text = null;
			f.revisionTxtBox.Text = null;
			f.numberOfBoxNumber.Value = 0;
			f.externalCheck.Checked = false;
			f.externalTxtBox.Text = null;

			f.mtrlCodeReq.Visible = false;
			f.companyNameReq.Visible = false;
			f.companyCodeReq.Visible = false;
			f.descriptionReq.Visible = false;
			f.unitReq.Visible = false;
			f.quantityReq.Visible = false;
			f.productionDateReq.Visible = false;
			f.lotNoReq.Visible = false;
			f.numberOfBoxReq.Visible = false;
			f.externalReq.Visible = false;
		}

		public static void AddingMode(Form1 f)
		{
			f.mode = "Adding";

			f.mtrlCodeTxtBox.Enabled =			true;
			f.descriptionTxtBox.Enabled =		true;
			f.unitComboBox.Enabled =			true;
			f.backBtn.Enabled =					true;
			f.saveBtn.Enabled =					true;

			f.stockView.Enabled =				false;
			f.filterTxtBox.Enabled =			false;
			f.refreshStockBtn.Enabled =			false;
			f.companyNameTxtBox.Enabled =		false;
			f.companyCodeTxtBox.Enabled =		false;
			f.quantityTxtBox.Enabled =			false;
			f.billNoTxtBox.Enabled =			false;
			f.billDatePicker.Enabled =			false;
			f.productionDatePicker.Enabled =	false;
			f.lotNoTxtBox.Enabled =				false;
			f.revisionTxtBox.Enabled =			false;
			f.numberOfBoxNumber.Enabled =		false;
			f.addBelowBtn.Enabled =				false;
			f.newBtn.Enabled =					false;
			f.documantView.Enabled =			false;
			f.deleteAllBtn.Enabled =			false;
			f.deleteSelectedBtn.Enabled =		false;
			f.printBtn.Enabled =				false;
			f.printersComboBox.Enabled =		false;
			f.progressBar.Enabled =				false;
			f.createDocumantBtn.Enabled =		false;
			f.refreshPrinterBtn.Enabled =		false;
			f.externalCheck.Enabled =			false;
			f.externalTxtBox.Enabled =			false;

			// Changing mode Text and Values
			f.filterTxtBox.Text = null;
			f.mtrlCodeTxtBox.Text = null;
			f.companyNameTxtBox.Text = null;
			f.companyCodeTxtBox.Text = null;
			f.descriptionTxtBox.Text = null;
			f.unitComboBox.Text = null;
			f.quantityTxtBox.Text = null;
			f.billNoTxtBox.Text = null;
			f.billDatePicker.Value = DateTime.Now;
			f.productionDatePicker.Value = DateTime.Now;
			f.lotNoTxtBox.Text = null;
			f.revisionTxtBox.Text = null;
			f.numberOfBoxNumber.Value = 0;
			f.externalCheck.Checked = false;
			f.externalTxtBox.Text = null;

			f.mtrlCodeReq.Visible = false;
			f.companyNameReq.Visible = false;
			f.companyCodeReq.Visible = false;
			f.descriptionReq.Visible = false;
			f.unitReq.Visible = false;
			f.quantityReq.Visible = false;
			f.productionDateReq.Visible = false;
			f.lotNoReq.Visible = false;
			f.numberOfBoxReq.Visible = false;
			f.externalReq.Visible = false;
		}

		public static bool RequirementControlSelectionMode(Form1 f)
		{
			bool mtrl, comName, comCode, desc, unit, quan, prod, lot, number, external;

			if (String.IsNullOrEmpty(f.mtrlCodeTxtBox.Text) || !(f.mtrlCodeTxtBox.Text.Length == 9 || f.mtrlCodeTxtBox.Text.Length == 10))		
																	{ f.mtrlCodeReq.Visible = true; mtrl = false; }
			else													{ f.mtrlCodeReq.Visible = false; mtrl = true; }

			if (String.IsNullOrEmpty(f.companyNameTxtBox.Text))		{ f.companyNameReq.Visible = true; comName = false; }
			else													{ f.companyNameReq.Visible = false; comName = true; }

			if (String.IsNullOrEmpty(f.companyCodeTxtBox.Text))		{ f.companyCodeReq.Visible = true; comCode = false; }
			else													{ f.companyCodeReq.Visible = false; comCode = true; }

			if (String.IsNullOrEmpty(f.descriptionTxtBox.Text))		{ f.descriptionReq.Visible = true; desc = false; }
			else													{ f.descriptionReq.Visible = false; desc = true; }

			if (String.IsNullOrEmpty(f.unitComboBox.Text))			{ f.unitReq.Visible = true; unit = false; }
			else													{ f.unitReq.Visible = false; unit = true; }

			if (String.IsNullOrEmpty(f.quantityTxtBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(f.quantityTxtBox.Text, "[^0-9]"))		
																	{ f.quantityReq.Visible = true; quan = false; }
			else													{ f.quantityReq.Visible = false; quan = true; }

			if (String.IsNullOrEmpty(f.productionDatePicker.Text))	{ f.productionDateReq.Visible = true; prod = false; }
			else													{ f.productionDateReq.Visible = false; prod = true; }

			if (String.IsNullOrEmpty(f.lotNoTxtBox.Text))			{ f.lotNoReq.Visible = true; lot = false; }
			else													{ f.lotNoReq.Visible = false; lot = true; }

			if (f.numberOfBoxNumber.Value <= 0)						{ f.numberOfBoxReq.Visible = true; number = false; }
			else													{ f.numberOfBoxReq.Visible = false; number = true; }

			if (f.externalCheck.Checked) 
			{
				if (String.IsNullOrEmpty(f.externalTxtBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(f.externalTxtBox.Text, "[^0-9]"))
																	{ f.externalReq.Visible = true; external = false; }
				else												{ f.externalReq.Visible = false; external = true; }
			}
			else													{ f.externalReq.Visible = false; external = true; }

			return mtrl && comCode && comName && desc && unit && quan && prod && lot && number && external;
		}

		public static bool RequirementControlAddingMode(Form1 f)
		{
			bool mtrl, desc, unit, prod;

			if (String.IsNullOrEmpty(f.mtrlCodeTxtBox.Text) || !(f.mtrlCodeTxtBox.Text.Length == 9 || f.mtrlCodeTxtBox.Text.Length == 10))
																	{ f.mtrlCodeReq.Visible = true; mtrl = false; }
			else													{ f.mtrlCodeReq.Visible = false; mtrl = true; }

			if (String.IsNullOrEmpty(f.descriptionTxtBox.Text))		{ f.descriptionReq.Visible = true; desc = false; }
			else													{ f.descriptionReq.Visible = false; desc = true; }

			if (String.IsNullOrEmpty(f.unitComboBox.Text))			{ f.unitReq.Visible = true; unit = false; }
			else													{ f.unitReq.Visible = false; unit = true; }

			if (String.IsNullOrEmpty(f.productionDatePicker.Text))	{ f.productionDateReq.Visible = true; prod = false; }
			else													{ f.productionDateReq.Visible = false; prod = true; }

			return mtrl && desc && unit && prod;
		}
	}
}
