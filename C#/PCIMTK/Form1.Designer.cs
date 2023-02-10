namespace PCIMTK
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.refreshStockBtn = new System.Windows.Forms.Button();
			this.mtrlCodeFilterLabel = new System.Windows.Forms.Label();
			this.filterTxtBox = new System.Windows.Forms.TextBox();
			this.stockView = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.externalTxtBox = new System.Windows.Forms.TextBox();
			this.externalCheck = new System.Windows.Forms.CheckBox();
			this.quantityReq = new System.Windows.Forms.Label();
			this.unitReq = new System.Windows.Forms.Label();
			this.descriptionReq = new System.Windows.Forms.Label();
			this.companyCodeReq = new System.Windows.Forms.Label();
			this.companyNameReq = new System.Windows.Forms.Label();
			this.productionDateReq = new System.Windows.Forms.Label();
			this.lotNoReq = new System.Windows.Forms.Label();
			this.numberOfBoxReq = new System.Windows.Forms.Label();
			this.mtrlCodeReq = new System.Windows.Forms.Label();
			this.createDocumantBtn = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.printBtn = new System.Windows.Forms.Button();
			this.printersComboBox = new System.Windows.Forms.ComboBox();
			this.refreshPrinterBtn = new System.Windows.Forms.Button();
			this.deleteSelectedBtn = new System.Windows.Forms.Button();
			this.deleteAllBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.newBtn = new System.Windows.Forms.Button();
			this.addBelowBtn = new System.Windows.Forms.Button();
			this.documantView = new System.Windows.Forms.DataGridView();
			this.CompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumberOfBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productionDatePicker = new System.Windows.Forms.DateTimePicker();
			this.billDatePicker = new System.Windows.Forms.DateTimePicker();
			this.revisionTxtBox = new System.Windows.Forms.TextBox();
			this.numberOfBoxNumber = new System.Windows.Forms.NumericUpDown();
			this.lotNoTxtBox = new System.Windows.Forms.TextBox();
			this.billNoTxtBox = new System.Windows.Forms.TextBox();
			this.revisionLbl = new System.Windows.Forms.Label();
			this.lotNoLbl = new System.Windows.Forms.Label();
			this.productionDateLbl = new System.Windows.Forms.Label();
			this.numberOfBoxLbl = new System.Windows.Forms.Label();
			this.billDateLbl = new System.Windows.Forms.Label();
			this.billNoLbl = new System.Windows.Forms.Label();
			this.unitComboBox = new System.Windows.Forms.ComboBox();
			this.quantityTxtBox = new System.Windows.Forms.TextBox();
			this.descriptionTxtBox = new System.Windows.Forms.TextBox();
			this.companyCodeTxtBox = new System.Windows.Forms.TextBox();
			this.companyNameTxtBox = new System.Windows.Forms.TextBox();
			this.mtrlCodeTxtBox = new System.Windows.Forms.TextBox();
			this.unitLbl = new System.Windows.Forms.Label();
			this.descriptionLbl = new System.Windows.Forms.Label();
			this.companyNameCode = new System.Windows.Forms.Label();
			this.quantityLbl = new System.Windows.Forms.Label();
			this.companyNameLbl = new System.Windows.Forms.Label();
			this.mtrlCodeLbl = new System.Windows.Forms.Label();
			this.externalReq = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documantView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfBoxNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.refreshStockBtn);
			this.groupBox1.Controls.Add(this.mtrlCodeFilterLabel);
			this.groupBox1.Controls.Add(this.filterTxtBox);
			this.groupBox1.Controls.Add(this.stockView);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(985, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Material List";
			// 
			// refreshStockBtn
			// 
			this.refreshStockBtn.Location = new System.Drawing.Point(827, 203);
			this.refreshStockBtn.Name = "refreshStockBtn";
			this.refreshStockBtn.Size = new System.Drawing.Size(152, 43);
			this.refreshStockBtn.TabIndex = 3;
			this.refreshStockBtn.Text = "Refresh List";
			this.refreshStockBtn.UseVisualStyleBackColor = true;
			this.refreshStockBtn.Click += new System.EventHandler(this.refreshStockBtn_Click);
			// 
			// mtrlCodeFilterLabel
			// 
			this.mtrlCodeFilterLabel.AutoSize = true;
			this.mtrlCodeFilterLabel.Location = new System.Drawing.Point(828, 20);
			this.mtrlCodeFilterLabel.Name = "mtrlCodeFilterLabel";
			this.mtrlCodeFilterLabel.Size = new System.Drawing.Size(72, 13);
			this.mtrlCodeFilterLabel.TabIndex = 2;
			this.mtrlCodeFilterLabel.Text = "Material Code";
			// 
			// filterTxtBox
			// 
			this.filterTxtBox.Location = new System.Drawing.Point(827, 38);
			this.filterTxtBox.Name = "filterTxtBox";
			this.filterTxtBox.Size = new System.Drawing.Size(152, 20);
			this.filterTxtBox.TabIndex = 1;
			this.filterTxtBox.TextChanged += new System.EventHandler(this.filterTxtBox_TextChanged);
			// 
			// stockView
			// 
			this.stockView.AllowUserToAddRows = false;
			this.stockView.AllowUserToDeleteRows = false;
			this.stockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stockView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stockView.Location = new System.Drawing.Point(7, 20);
			this.stockView.Name = "stockView";
			this.stockView.ReadOnly = true;
			this.stockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.stockView.Size = new System.Drawing.Size(814, 226);
			this.stockView.TabIndex = 0;
			this.stockView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockView_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.externalReq);
			this.groupBox2.Controls.Add(this.externalTxtBox);
			this.groupBox2.Controls.Add(this.externalCheck);
			this.groupBox2.Controls.Add(this.quantityReq);
			this.groupBox2.Controls.Add(this.unitReq);
			this.groupBox2.Controls.Add(this.descriptionReq);
			this.groupBox2.Controls.Add(this.companyCodeReq);
			this.groupBox2.Controls.Add(this.companyNameReq);
			this.groupBox2.Controls.Add(this.productionDateReq);
			this.groupBox2.Controls.Add(this.lotNoReq);
			this.groupBox2.Controls.Add(this.numberOfBoxReq);
			this.groupBox2.Controls.Add(this.mtrlCodeReq);
			this.groupBox2.Controls.Add(this.createDocumantBtn);
			this.groupBox2.Controls.Add(this.progressBar);
			this.groupBox2.Controls.Add(this.printBtn);
			this.groupBox2.Controls.Add(this.printersComboBox);
			this.groupBox2.Controls.Add(this.refreshPrinterBtn);
			this.groupBox2.Controls.Add(this.deleteSelectedBtn);
			this.groupBox2.Controls.Add(this.deleteAllBtn);
			this.groupBox2.Controls.Add(this.saveBtn);
			this.groupBox2.Controls.Add(this.backBtn);
			this.groupBox2.Controls.Add(this.newBtn);
			this.groupBox2.Controls.Add(this.addBelowBtn);
			this.groupBox2.Controls.Add(this.documantView);
			this.groupBox2.Controls.Add(this.productionDatePicker);
			this.groupBox2.Controls.Add(this.billDatePicker);
			this.groupBox2.Controls.Add(this.revisionTxtBox);
			this.groupBox2.Controls.Add(this.numberOfBoxNumber);
			this.groupBox2.Controls.Add(this.lotNoTxtBox);
			this.groupBox2.Controls.Add(this.billNoTxtBox);
			this.groupBox2.Controls.Add(this.revisionLbl);
			this.groupBox2.Controls.Add(this.lotNoLbl);
			this.groupBox2.Controls.Add(this.productionDateLbl);
			this.groupBox2.Controls.Add(this.numberOfBoxLbl);
			this.groupBox2.Controls.Add(this.billDateLbl);
			this.groupBox2.Controls.Add(this.billNoLbl);
			this.groupBox2.Controls.Add(this.unitComboBox);
			this.groupBox2.Controls.Add(this.quantityTxtBox);
			this.groupBox2.Controls.Add(this.descriptionTxtBox);
			this.groupBox2.Controls.Add(this.companyCodeTxtBox);
			this.groupBox2.Controls.Add(this.companyNameTxtBox);
			this.groupBox2.Controls.Add(this.mtrlCodeTxtBox);
			this.groupBox2.Controls.Add(this.unitLbl);
			this.groupBox2.Controls.Add(this.descriptionLbl);
			this.groupBox2.Controls.Add(this.companyNameCode);
			this.groupBox2.Controls.Add(this.quantityLbl);
			this.groupBox2.Controls.Add(this.companyNameLbl);
			this.groupBox2.Controls.Add(this.mtrlCodeLbl);
			this.groupBox2.Location = new System.Drawing.Point(13, 270);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(984, 429);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Label Info";
			// 
			// externalTxtBox
			// 
			this.externalTxtBox.Location = new System.Drawing.Point(677, 58);
			this.externalTxtBox.Name = "externalTxtBox";
			this.externalTxtBox.Size = new System.Drawing.Size(133, 20);
			this.externalTxtBox.TabIndex = 53;
			this.externalTxtBox.TextChanged += new System.EventHandler(this.externalTxtBox_TextChanged);
			// 
			// externalCheck
			// 
			this.externalCheck.AutoSize = true;
			this.externalCheck.Location = new System.Drawing.Point(677, 38);
			this.externalCheck.Name = "externalCheck";
			this.externalCheck.Size = new System.Drawing.Size(158, 17);
			this.externalCheck.TabIndex = 52;
			this.externalCheck.Text = "External Quantity Document";
			this.externalCheck.UseVisualStyleBackColor = true;
			this.externalCheck.CheckedChanged += new System.EventHandler(this.externalCheck_CheckedChanged);
			// 
			// quantityReq
			// 
			this.quantityReq.AutoSize = true;
			this.quantityReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantityReq.ForeColor = System.Drawing.Color.Red;
			this.quantityReq.Location = new System.Drawing.Point(58, 153);
			this.quantityReq.Name = "quantityReq";
			this.quantityReq.Size = new System.Drawing.Size(21, 20);
			this.quantityReq.TabIndex = 50;
			this.quantityReq.Text = "**";
			// 
			// unitReq
			// 
			this.unitReq.AutoSize = true;
			this.unitReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unitReq.ForeColor = System.Drawing.Color.Red;
			this.unitReq.Location = new System.Drawing.Point(37, 129);
			this.unitReq.Name = "unitReq";
			this.unitReq.Size = new System.Drawing.Size(21, 20);
			this.unitReq.TabIndex = 49;
			this.unitReq.Text = "**";
			// 
			// descriptionReq
			// 
			this.descriptionReq.AutoSize = true;
			this.descriptionReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionReq.ForeColor = System.Drawing.Color.Red;
			this.descriptionReq.Location = new System.Drawing.Point(71, 105);
			this.descriptionReq.Name = "descriptionReq";
			this.descriptionReq.Size = new System.Drawing.Size(21, 20);
			this.descriptionReq.TabIndex = 48;
			this.descriptionReq.Text = "**";
			// 
			// companyCodeReq
			// 
			this.companyCodeReq.AutoSize = true;
			this.companyCodeReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.companyCodeReq.ForeColor = System.Drawing.Color.Red;
			this.companyCodeReq.Location = new System.Drawing.Point(90, 81);
			this.companyCodeReq.Name = "companyCodeReq";
			this.companyCodeReq.Size = new System.Drawing.Size(21, 20);
			this.companyCodeReq.TabIndex = 47;
			this.companyCodeReq.Text = "**";
			// 
			// companyNameReq
			// 
			this.companyNameReq.AutoSize = true;
			this.companyNameReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.companyNameReq.ForeColor = System.Drawing.Color.Red;
			this.companyNameReq.Location = new System.Drawing.Point(93, 56);
			this.companyNameReq.Name = "companyNameReq";
			this.companyNameReq.Size = new System.Drawing.Size(21, 20);
			this.companyNameReq.TabIndex = 46;
			this.companyNameReq.Text = "**";
			// 
			// productionDateReq
			// 
			this.productionDateReq.AutoSize = true;
			this.productionDateReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productionDateReq.ForeColor = System.Drawing.Color.Red;
			this.productionDateReq.Location = new System.Drawing.Point(417, 80);
			this.productionDateReq.Name = "productionDateReq";
			this.productionDateReq.Size = new System.Drawing.Size(21, 20);
			this.productionDateReq.TabIndex = 45;
			this.productionDateReq.Text = "**";
			// 
			// lotNoReq
			// 
			this.lotNoReq.AutoSize = true;
			this.lotNoReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lotNoReq.ForeColor = System.Drawing.Color.Red;
			this.lotNoReq.Location = new System.Drawing.Point(373, 104);
			this.lotNoReq.Name = "lotNoReq";
			this.lotNoReq.Size = new System.Drawing.Size(21, 20);
			this.lotNoReq.TabIndex = 44;
			this.lotNoReq.Text = "**";
			// 
			// numberOfBoxReq
			// 
			this.numberOfBoxReq.AutoSize = true;
			this.numberOfBoxReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberOfBoxReq.ForeColor = System.Drawing.Color.Red;
			this.numberOfBoxReq.Location = new System.Drawing.Point(412, 152);
			this.numberOfBoxReq.Name = "numberOfBoxReq";
			this.numberOfBoxReq.Size = new System.Drawing.Size(21, 20);
			this.numberOfBoxReq.TabIndex = 43;
			this.numberOfBoxReq.Text = "**";
			// 
			// mtrlCodeReq
			// 
			this.mtrlCodeReq.AutoSize = true;
			this.mtrlCodeReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtrlCodeReq.ForeColor = System.Drawing.Color.Red;
			this.mtrlCodeReq.Location = new System.Drawing.Point(83, 31);
			this.mtrlCodeReq.Name = "mtrlCodeReq";
			this.mtrlCodeReq.Size = new System.Drawing.Size(21, 20);
			this.mtrlCodeReq.TabIndex = 42;
			this.mtrlCodeReq.Text = "**";
			// 
			// createDocumantBtn
			// 
			this.createDocumantBtn.Location = new System.Drawing.Point(861, 391);
			this.createDocumantBtn.Name = "createDocumantBtn";
			this.createDocumantBtn.Size = new System.Drawing.Size(117, 32);
			this.createDocumantBtn.TabIndex = 41;
			this.createDocumantBtn.Text = "Create Documant";
			this.createDocumantBtn.UseVisualStyleBackColor = true;
			this.createDocumantBtn.Click += new System.EventHandler(this.createDocumantBtn_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(734, 391);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(124, 32);
			this.progressBar.TabIndex = 40;
			// 
			// printBtn
			// 
			this.printBtn.Location = new System.Drawing.Point(637, 390);
			this.printBtn.Name = "printBtn";
			this.printBtn.Size = new System.Drawing.Size(91, 32);
			this.printBtn.TabIndex = 39;
			this.printBtn.Text = "Print";
			this.printBtn.UseVisualStyleBackColor = true;
			this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
			// 
			// printersComboBox
			// 
			this.printersComboBox.FormattingEnabled = true;
			this.printersComboBox.Location = new System.Drawing.Point(498, 397);
			this.printersComboBox.Name = "printersComboBox";
			this.printersComboBox.Size = new System.Drawing.Size(133, 21);
			this.printersComboBox.TabIndex = 38;
			// 
			// refreshPrinterBtn
			// 
			this.refreshPrinterBtn.Location = new System.Drawing.Point(375, 391);
			this.refreshPrinterBtn.Name = "refreshPrinterBtn";
			this.refreshPrinterBtn.Size = new System.Drawing.Size(117, 32);
			this.refreshPrinterBtn.TabIndex = 37;
			this.refreshPrinterBtn.Text = "Refresh Printers";
			this.refreshPrinterBtn.UseVisualStyleBackColor = true;
			this.refreshPrinterBtn.Click += new System.EventHandler(this.refreshPrinterBtn_Click);
			// 
			// deleteSelectedBtn
			// 
			this.deleteSelectedBtn.Location = new System.Drawing.Point(103, 392);
			this.deleteSelectedBtn.Name = "deleteSelectedBtn";
			this.deleteSelectedBtn.Size = new System.Drawing.Size(91, 32);
			this.deleteSelectedBtn.TabIndex = 35;
			this.deleteSelectedBtn.Text = "Delete Selected";
			this.deleteSelectedBtn.UseVisualStyleBackColor = true;
			this.deleteSelectedBtn.Click += new System.EventHandler(this.deleteSelectedBtn_Click);
			// 
			// deleteAllBtn
			// 
			this.deleteAllBtn.Location = new System.Drawing.Point(6, 391);
			this.deleteAllBtn.Name = "deleteAllBtn";
			this.deleteAllBtn.Size = new System.Drawing.Size(91, 32);
			this.deleteAllBtn.TabIndex = 34;
			this.deleteAllBtn.Text = "Delete All";
			this.deleteAllBtn.UseVisualStyleBackColor = true;
			this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(865, 127);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(113, 53);
			this.saveBtn.TabIndex = 33;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(865, 72);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(113, 52);
			this.backBtn.TabIndex = 32;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// newBtn
			// 
			this.newBtn.Location = new System.Drawing.Point(865, 14);
			this.newBtn.Name = "newBtn";
			this.newBtn.Size = new System.Drawing.Size(113, 56);
			this.newBtn.TabIndex = 31;
			this.newBtn.Text = "New";
			this.newBtn.UseVisualStyleBackColor = true;
			this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
			// 
			// addBelowBtn
			// 
			this.addBelowBtn.Location = new System.Drawing.Point(649, 102);
			this.addBelowBtn.Name = "addBelowBtn";
			this.addBelowBtn.Size = new System.Drawing.Size(117, 69);
			this.addBelowBtn.TabIndex = 30;
			this.addBelowBtn.Text = "Add Below";
			this.addBelowBtn.UseVisualStyleBackColor = true;
			this.addBelowBtn.Click += new System.EventHandler(this.addBelowBtn_Click);
			// 
			// documantView
			// 
			this.documantView.AllowUserToAddRows = false;
			this.documantView.AllowUserToDeleteRows = false;
			this.documantView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.documantView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.documantView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.documantView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyCode,
            this.CompanyName,
            this.MaterialCode,
            this.Description,
            this.Unit,
            this.Quantity,
            this.BillNo,
            this.BillDate,
            this.ProductionDate,
            this.LotNo,
            this.Revision,
            this.NumberOfBox});
			this.documantView.Location = new System.Drawing.Point(6, 183);
			this.documantView.Name = "documantView";
			this.documantView.ReadOnly = true;
			this.documantView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.documantView.Size = new System.Drawing.Size(972, 203);
			this.documantView.TabIndex = 29;
			// 
			// CompanyCode
			// 
			this.CompanyCode.HeaderText = "Company Code";
			this.CompanyCode.Name = "CompanyCode";
			this.CompanyCode.ReadOnly = true;
			// 
			// CompanyName
			// 
			this.CompanyName.HeaderText = "Company Name";
			this.CompanyName.Name = "CompanyName";
			this.CompanyName.ReadOnly = true;
			// 
			// MaterialCode
			// 
			this.MaterialCode.HeaderText = "Material Code";
			this.MaterialCode.Name = "MaterialCode";
			this.MaterialCode.ReadOnly = true;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// Unit
			// 
			this.Unit.HeaderText = "Unit";
			this.Unit.Name = "Unit";
			this.Unit.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// BillNo
			// 
			this.BillNo.HeaderText = "Bill No";
			this.BillNo.Name = "BillNo";
			this.BillNo.ReadOnly = true;
			this.BillNo.Visible = false;
			// 
			// BillDate
			// 
			this.BillDate.HeaderText = "Bill Date";
			this.BillDate.Name = "BillDate";
			this.BillDate.ReadOnly = true;
			this.BillDate.Visible = false;
			// 
			// ProductionDate
			// 
			this.ProductionDate.HeaderText = "Production Date";
			this.ProductionDate.Name = "ProductionDate";
			this.ProductionDate.ReadOnly = true;
			this.ProductionDate.Visible = false;
			// 
			// LotNo
			// 
			this.LotNo.HeaderText = "Lot No";
			this.LotNo.Name = "LotNo";
			this.LotNo.ReadOnly = true;
			this.LotNo.Visible = false;
			// 
			// Revision
			// 
			this.Revision.HeaderText = "Revision";
			this.Revision.Name = "Revision";
			this.Revision.ReadOnly = true;
			this.Revision.Visible = false;
			// 
			// NumberOfBox
			// 
			this.NumberOfBox.HeaderText = "NumberOfBox";
			this.NumberOfBox.Name = "NumberOfBox";
			this.NumberOfBox.ReadOnly = true;
			this.NumberOfBox.Visible = false;
			// 
			// productionDatePicker
			// 
			this.productionDatePicker.Location = new System.Drawing.Point(443, 77);
			this.productionDatePicker.Name = "productionDatePicker";
			this.productionDatePicker.Size = new System.Drawing.Size(199, 20);
			this.productionDatePicker.TabIndex = 28;
			this.productionDatePicker.ValueChanged += new System.EventHandler(this.productionDatePicker_ValueChanged);
			// 
			// billDatePicker
			// 
			this.billDatePicker.Location = new System.Drawing.Point(443, 53);
			this.billDatePicker.Name = "billDatePicker";
			this.billDatePicker.Size = new System.Drawing.Size(199, 20);
			this.billDatePicker.TabIndex = 27;
			// 
			// revisionTxtBox
			// 
			this.revisionTxtBox.Location = new System.Drawing.Point(443, 127);
			this.revisionTxtBox.Name = "revisionTxtBox";
			this.revisionTxtBox.Size = new System.Drawing.Size(199, 20);
			this.revisionTxtBox.TabIndex = 26;
			// 
			// numberOfBoxNumber
			// 
			this.numberOfBoxNumber.Location = new System.Drawing.Point(443, 152);
			this.numberOfBoxNumber.Name = "numberOfBoxNumber";
			this.numberOfBoxNumber.Size = new System.Drawing.Size(199, 20);
			this.numberOfBoxNumber.TabIndex = 25;
			this.numberOfBoxNumber.ValueChanged += new System.EventHandler(this.numberOfBoxNumber_ValueChanged);
			// 
			// lotNoTxtBox
			// 
			this.lotNoTxtBox.Location = new System.Drawing.Point(443, 102);
			this.lotNoTxtBox.Name = "lotNoTxtBox";
			this.lotNoTxtBox.Size = new System.Drawing.Size(199, 20);
			this.lotNoTxtBox.TabIndex = 22;
			this.lotNoTxtBox.TextChanged += new System.EventHandler(this.lotNoTxtBox_TextChanged);
			// 
			// billNoTxtBox
			// 
			this.billNoTxtBox.Location = new System.Drawing.Point(443, 29);
			this.billNoTxtBox.Name = "billNoTxtBox";
			this.billNoTxtBox.Size = new System.Drawing.Size(199, 20);
			this.billNoTxtBox.TabIndex = 19;
			// 
			// revisionLbl
			// 
			this.revisionLbl.AutoSize = true;
			this.revisionLbl.Location = new System.Drawing.Point(338, 130);
			this.revisionLbl.Name = "revisionLbl";
			this.revisionLbl.Size = new System.Drawing.Size(48, 13);
			this.revisionLbl.TabIndex = 18;
			this.revisionLbl.Text = "Revision";
			// 
			// lotNoLbl
			// 
			this.lotNoLbl.AutoSize = true;
			this.lotNoLbl.Location = new System.Drawing.Point(338, 105);
			this.lotNoLbl.Name = "lotNoLbl";
			this.lotNoLbl.Size = new System.Drawing.Size(39, 13);
			this.lotNoLbl.TabIndex = 17;
			this.lotNoLbl.Text = "Lot No";
			// 
			// productionDateLbl
			// 
			this.productionDateLbl.AutoSize = true;
			this.productionDateLbl.Location = new System.Drawing.Point(338, 81);
			this.productionDateLbl.Name = "productionDateLbl";
			this.productionDateLbl.Size = new System.Drawing.Size(84, 13);
			this.productionDateLbl.TabIndex = 16;
			this.productionDateLbl.Text = "Production Date";
			// 
			// numberOfBoxLbl
			// 
			this.numberOfBoxLbl.AutoSize = true;
			this.numberOfBoxLbl.Location = new System.Drawing.Point(338, 153);
			this.numberOfBoxLbl.Name = "numberOfBoxLbl";
			this.numberOfBoxLbl.Size = new System.Drawing.Size(79, 13);
			this.numberOfBoxLbl.TabIndex = 15;
			this.numberOfBoxLbl.Text = "Number Of Box";
			// 
			// billDateLbl
			// 
			this.billDateLbl.AutoSize = true;
			this.billDateLbl.Location = new System.Drawing.Point(338, 56);
			this.billDateLbl.Name = "billDateLbl";
			this.billDateLbl.Size = new System.Drawing.Size(46, 13);
			this.billDateLbl.TabIndex = 14;
			this.billDateLbl.Text = "Bill Date";
			// 
			// billNoLbl
			// 
			this.billNoLbl.AutoSize = true;
			this.billNoLbl.Location = new System.Drawing.Point(338, 32);
			this.billNoLbl.Name = "billNoLbl";
			this.billNoLbl.Size = new System.Drawing.Size(37, 13);
			this.billNoLbl.TabIndex = 13;
			this.billNoLbl.Text = "Bill No";
			// 
			// unitComboBox
			// 
			this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.unitComboBox.FormattingEnabled = true;
			this.unitComboBox.Items.AddRange(new object[] {
            "PCS",
            "KG",
            "Meter",
            "Milimeter"});
			this.unitComboBox.Location = new System.Drawing.Point(121, 126);
			this.unitComboBox.Name = "unitComboBox";
			this.unitComboBox.Size = new System.Drawing.Size(196, 21);
			this.unitComboBox.TabIndex = 12;
			this.unitComboBox.TextChanged += new System.EventHandler(this.unitComboBox_TextChanged);
			// 
			// quantityTxtBox
			// 
			this.quantityTxtBox.Location = new System.Drawing.Point(121, 151);
			this.quantityTxtBox.Name = "quantityTxtBox";
			this.quantityTxtBox.Size = new System.Drawing.Size(196, 20);
			this.quantityTxtBox.TabIndex = 11;
			this.quantityTxtBox.TextChanged += new System.EventHandler(this.quantityTxtBox_TextChanged);
			// 
			// descriptionTxtBox
			// 
			this.descriptionTxtBox.Location = new System.Drawing.Point(121, 102);
			this.descriptionTxtBox.Name = "descriptionTxtBox";
			this.descriptionTxtBox.Size = new System.Drawing.Size(196, 20);
			this.descriptionTxtBox.TabIndex = 9;
			this.descriptionTxtBox.TextChanged += new System.EventHandler(this.descriptionTxtBox_TextChanged);
			// 
			// companyCodeTxtBox
			// 
			this.companyCodeTxtBox.Location = new System.Drawing.Point(121, 78);
			this.companyCodeTxtBox.Name = "companyCodeTxtBox";
			this.companyCodeTxtBox.Size = new System.Drawing.Size(196, 20);
			this.companyCodeTxtBox.TabIndex = 8;
			this.companyCodeTxtBox.TextChanged += new System.EventHandler(this.companyCodeTxtBox_TextChanged);
			// 
			// companyNameTxtBox
			// 
			this.companyNameTxtBox.Location = new System.Drawing.Point(121, 53);
			this.companyNameTxtBox.Name = "companyNameTxtBox";
			this.companyNameTxtBox.Size = new System.Drawing.Size(196, 20);
			this.companyNameTxtBox.TabIndex = 7;
			this.companyNameTxtBox.TextChanged += new System.EventHandler(this.companyNameTxtBox_TextChanged);
			// 
			// mtrlCodeTxtBox
			// 
			this.mtrlCodeTxtBox.Location = new System.Drawing.Point(121, 29);
			this.mtrlCodeTxtBox.Name = "mtrlCodeTxtBox";
			this.mtrlCodeTxtBox.Size = new System.Drawing.Size(196, 20);
			this.mtrlCodeTxtBox.TabIndex = 6;
			this.mtrlCodeTxtBox.TextChanged += new System.EventHandler(this.mtrlCodeTxtBox_TextChanged);
			// 
			// unitLbl
			// 
			this.unitLbl.AutoSize = true;
			this.unitLbl.Location = new System.Drawing.Point(16, 130);
			this.unitLbl.Name = "unitLbl";
			this.unitLbl.Size = new System.Drawing.Size(26, 13);
			this.unitLbl.TabIndex = 5;
			this.unitLbl.Text = "Unit";
			// 
			// descriptionLbl
			// 
			this.descriptionLbl.AutoSize = true;
			this.descriptionLbl.Location = new System.Drawing.Point(16, 105);
			this.descriptionLbl.Name = "descriptionLbl";
			this.descriptionLbl.Size = new System.Drawing.Size(60, 13);
			this.descriptionLbl.TabIndex = 4;
			this.descriptionLbl.Text = "Description";
			// 
			// companyNameCode
			// 
			this.companyNameCode.AutoSize = true;
			this.companyNameCode.Location = new System.Drawing.Point(16, 81);
			this.companyNameCode.Name = "companyNameCode";
			this.companyNameCode.Size = new System.Drawing.Size(79, 13);
			this.companyNameCode.TabIndex = 3;
			this.companyNameCode.Text = "Company Code";
			// 
			// quantityLbl
			// 
			this.quantityLbl.AutoSize = true;
			this.quantityLbl.Location = new System.Drawing.Point(16, 153);
			this.quantityLbl.Name = "quantityLbl";
			this.quantityLbl.Size = new System.Drawing.Size(46, 13);
			this.quantityLbl.TabIndex = 2;
			this.quantityLbl.Text = "Quantity";
			// 
			// companyNameLbl
			// 
			this.companyNameLbl.AutoSize = true;
			this.companyNameLbl.Location = new System.Drawing.Point(16, 56);
			this.companyNameLbl.Name = "companyNameLbl";
			this.companyNameLbl.Size = new System.Drawing.Size(82, 13);
			this.companyNameLbl.TabIndex = 1;
			this.companyNameLbl.Text = "Company Name";
			// 
			// mtrlCodeLbl
			// 
			this.mtrlCodeLbl.AutoSize = true;
			this.mtrlCodeLbl.Location = new System.Drawing.Point(16, 32);
			this.mtrlCodeLbl.Name = "mtrlCodeLbl";
			this.mtrlCodeLbl.Size = new System.Drawing.Size(72, 13);
			this.mtrlCodeLbl.TabIndex = 0;
			this.mtrlCodeLbl.Text = "Material Code";
			// 
			// externalReq
			// 
			this.externalReq.AutoSize = true;
			this.externalReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.externalReq.ForeColor = System.Drawing.Color.Red;
			this.externalReq.Location = new System.Drawing.Point(810, 60);
			this.externalReq.Name = "externalReq";
			this.externalReq.Size = new System.Drawing.Size(21, 20);
			this.externalReq.TabIndex = 54;
			this.externalReq.Text = "**";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 711);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "PCI MTK";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.documantView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfBoxNumber)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label mtrlCodeFilterLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.Button refreshStockBtn;
		public System.Windows.Forms.TextBox filterTxtBox;
		public System.Windows.Forms.DataGridView stockView;
		public System.Windows.Forms.Label unitLbl;
		public System.Windows.Forms.Label descriptionLbl;
		public System.Windows.Forms.Label companyNameCode;
		public System.Windows.Forms.Label quantityLbl;
		public System.Windows.Forms.Label companyNameLbl;
		public System.Windows.Forms.Label mtrlCodeLbl;
		public System.Windows.Forms.DateTimePicker productionDatePicker;
		public System.Windows.Forms.DateTimePicker billDatePicker;
		public System.Windows.Forms.TextBox revisionTxtBox;
		public System.Windows.Forms.NumericUpDown numberOfBoxNumber;
		public System.Windows.Forms.TextBox lotNoTxtBox;
		public System.Windows.Forms.TextBox billNoTxtBox;
		public System.Windows.Forms.Label revisionLbl;
		public System.Windows.Forms.Label lotNoLbl;
		public System.Windows.Forms.Label productionDateLbl;
		public System.Windows.Forms.Label numberOfBoxLbl;
		public System.Windows.Forms.Label billDateLbl;
		public System.Windows.Forms.Label billNoLbl;
		public System.Windows.Forms.ComboBox unitComboBox;
		public System.Windows.Forms.TextBox quantityTxtBox;
		public System.Windows.Forms.TextBox descriptionTxtBox;
		public System.Windows.Forms.TextBox companyCodeTxtBox;
		public System.Windows.Forms.TextBox companyNameTxtBox;
		public System.Windows.Forms.TextBox mtrlCodeTxtBox;
		public System.Windows.Forms.Button saveBtn;
		public System.Windows.Forms.Button backBtn;
		public System.Windows.Forms.Button newBtn;
		public System.Windows.Forms.Button addBelowBtn;
		public System.Windows.Forms.DataGridView documantView;
		public System.Windows.Forms.Button refreshPrinterBtn;
		public System.Windows.Forms.Button deleteSelectedBtn;
		public System.Windows.Forms.Button deleteAllBtn;
		public System.Windows.Forms.Button createDocumantBtn;
		public System.Windows.Forms.ProgressBar progressBar;
		public System.Windows.Forms.Button printBtn;
		public System.Windows.Forms.ComboBox printersComboBox;
		public System.Windows.Forms.Label quantityReq;
		public System.Windows.Forms.Label unitReq;
		public System.Windows.Forms.Label descriptionReq;
		public System.Windows.Forms.Label companyCodeReq;
		public System.Windows.Forms.Label companyNameReq;
		public System.Windows.Forms.Label productionDateReq;
		public System.Windows.Forms.Label lotNoReq;
		public System.Windows.Forms.Label numberOfBoxReq;
		public System.Windows.Forms.Label mtrlCodeReq;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Revision;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfBox;
		public System.Windows.Forms.TextBox externalTxtBox;
		public System.Windows.Forms.CheckBox externalCheck;
		public System.Windows.Forms.Label externalReq;
	}
}

