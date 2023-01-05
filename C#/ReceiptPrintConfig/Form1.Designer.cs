namespace ReceiptPrintConfig
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reloadbtn = new System.Windows.Forms.Button();
			this.materialbtn = new System.Windows.Forms.Button();
			this.materialtxtbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.countLabel = new System.Windows.Forms.Label();
			this.unitLabel = new System.Windows.Forms.Label();
			this.comCodeLabel = new System.Windows.Forms.Label();
			this.descLabel = new System.Windows.Forms.Label();
			this.comLabel = new System.Windows.Forms.Label();
			this.matLabel = new System.Windows.Forms.Label();
			this.backbtn = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.saveDatabase = new System.Windows.Forms.Button();
			this.newStock = new System.Windows.Forms.Button();
			this.cardLabelM = new System.Windows.Forms.Label();
			this.revisiontxtbox = new System.Windows.Forms.TextBox();
			this.deleteAll = new System.Windows.Forms.Button();
			this.deleteSelected = new System.Windows.Forms.Button();
			this.print = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.singlechkbox = new System.Windows.Forms.CheckBox();
			this.quartedchkbox = new System.Windows.Forms.CheckBox();
			this.addbelowbtn = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.kartoncombobox = new System.Windows.Forms.ComboBox();
			this.grossweighttxtbox = new System.Windows.Forms.TextBox();
			this.grosLabelM = new System.Windows.Forms.Label();
			this.boxcodetxtbox = new System.Windows.Forms.TextBox();
			this.boxLabelM = new System.Windows.Forms.Label();
			this.revLabelM = new System.Windows.Forms.Label();
			this.lotnotxtbox = new System.Windows.Forms.TextBox();
			this.lotLabelM = new System.Windows.Forms.Label();
			this.prodLabelM = new System.Windows.Forms.Label();
			this.billDateLabelM = new System.Windows.Forms.Label();
			this.billtxtbox = new System.Windows.Forms.TextBox();
			this.billNoLabelM = new System.Windows.Forms.Label();
			this.operatortxtbox = new System.Windows.Forms.TextBox();
			this.opLabelM = new System.Windows.Forms.Label();
			this.counttxtbox = new System.Windows.Forms.TextBox();
			this.countLabelM = new System.Windows.Forms.Label();
			this.unittxtbox = new System.Windows.Forms.TextBox();
			this.unitLabelM = new System.Windows.Forms.Label();
			this.companycodetxtbox = new System.Windows.Forms.TextBox();
			this.comCodeLabelM = new System.Windows.Forms.Label();
			this.description2txtbox = new System.Windows.Forms.TextBox();
			this.descLabelM = new System.Windows.Forms.Label();
			this.companynametxtbox = new System.Windows.Forms.TextBox();
			this.comLabelM = new System.Windows.Forms.Label();
			this.material2txtbox = new System.Windows.Forms.TextBox();
			this.matLabelM = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.reloadbtn);
			this.groupBox1.Controls.Add(this.materialbtn);
			this.groupBox1.Controls.Add(this.materialtxtbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1018, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Material List";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(815, 184);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			// 
			// reloadbtn
			// 
			this.reloadbtn.Location = new System.Drawing.Point(831, 176);
			this.reloadbtn.Name = "reloadbtn";
			this.reloadbtn.Size = new System.Drawing.Size(181, 29);
			this.reloadbtn.TabIndex = 7;
			this.reloadbtn.Text = "Refresh List";
			this.reloadbtn.UseVisualStyleBackColor = true;
			this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
			// 
			// materialbtn
			// 
			this.materialbtn.Location = new System.Drawing.Point(831, 64);
			this.materialbtn.Name = "materialbtn";
			this.materialbtn.Size = new System.Drawing.Size(181, 29);
			this.materialbtn.TabIndex = 3;
			this.materialbtn.Text = "Filter";
			this.materialbtn.UseVisualStyleBackColor = true;
			this.materialbtn.Click += new System.EventHandler(this.materialbtn_Click);
			// 
			// materialtxtbox
			// 
			this.materialtxtbox.Location = new System.Drawing.Point(831, 37);
			this.materialtxtbox.Name = "materialtxtbox";
			this.materialtxtbox.Size = new System.Drawing.Size(181, 20);
			this.materialtxtbox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(828, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Material Code";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.countLabel);
			this.groupBox2.Controls.Add(this.unitLabel);
			this.groupBox2.Controls.Add(this.comCodeLabel);
			this.groupBox2.Controls.Add(this.descLabel);
			this.groupBox2.Controls.Add(this.comLabel);
			this.groupBox2.Controls.Add(this.matLabel);
			this.groupBox2.Controls.Add(this.backbtn);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.saveDatabase);
			this.groupBox2.Controls.Add(this.newStock);
			this.groupBox2.Controls.Add(this.cardLabelM);
			this.groupBox2.Controls.Add(this.revisiontxtbox);
			this.groupBox2.Controls.Add(this.deleteAll);
			this.groupBox2.Controls.Add(this.deleteSelected);
			this.groupBox2.Controls.Add(this.print);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.addbelowbtn);
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Controls.Add(this.kartoncombobox);
			this.groupBox2.Controls.Add(this.grossweighttxtbox);
			this.groupBox2.Controls.Add(this.grosLabelM);
			this.groupBox2.Controls.Add(this.boxcodetxtbox);
			this.groupBox2.Controls.Add(this.boxLabelM);
			this.groupBox2.Controls.Add(this.revLabelM);
			this.groupBox2.Controls.Add(this.lotnotxtbox);
			this.groupBox2.Controls.Add(this.lotLabelM);
			this.groupBox2.Controls.Add(this.prodLabelM);
			this.groupBox2.Controls.Add(this.billDateLabelM);
			this.groupBox2.Controls.Add(this.billtxtbox);
			this.groupBox2.Controls.Add(this.billNoLabelM);
			this.groupBox2.Controls.Add(this.operatortxtbox);
			this.groupBox2.Controls.Add(this.opLabelM);
			this.groupBox2.Controls.Add(this.counttxtbox);
			this.groupBox2.Controls.Add(this.countLabelM);
			this.groupBox2.Controls.Add(this.unittxtbox);
			this.groupBox2.Controls.Add(this.unitLabelM);
			this.groupBox2.Controls.Add(this.companycodetxtbox);
			this.groupBox2.Controls.Add(this.comCodeLabelM);
			this.groupBox2.Controls.Add(this.description2txtbox);
			this.groupBox2.Controls.Add(this.descLabelM);
			this.groupBox2.Controls.Add(this.companynametxtbox);
			this.groupBox2.Controls.Add(this.comLabelM);
			this.groupBox2.Controls.Add(this.material2txtbox);
			this.groupBox2.Controls.Add(this.matLabelM);
			this.groupBox2.Location = new System.Drawing.Point(12, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1018, 396);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Label Info";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(489, 83);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(211, 20);
			this.dateTimePicker2.TabIndex = 52;
			// 
			// countLabel
			// 
			this.countLabel.AutoSize = true;
			this.countLabel.BackColor = System.Drawing.Color.Transparent;
			this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.countLabel.Location = new System.Drawing.Point(62, 155);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(20, 18);
			this.countLabel.TabIndex = 50;
			this.countLabel.Text = "**";
			// 
			// unitLabel
			// 
			this.unitLabel.AutoSize = true;
			this.unitLabel.BackColor = System.Drawing.Color.Transparent;
			this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unitLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.unitLabel.Location = new System.Drawing.Point(53, 131);
			this.unitLabel.Name = "unitLabel";
			this.unitLabel.Size = new System.Drawing.Size(20, 18);
			this.unitLabel.TabIndex = 49;
			this.unitLabel.Text = "**";
			// 
			// comCodeLabel
			// 
			this.comCodeLabel.AutoSize = true;
			this.comCodeLabel.BackColor = System.Drawing.Color.Transparent;
			this.comCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comCodeLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.comCodeLabel.Location = new System.Drawing.Point(106, 106);
			this.comCodeLabel.Name = "comCodeLabel";
			this.comCodeLabel.Size = new System.Drawing.Size(20, 18);
			this.comCodeLabel.TabIndex = 48;
			this.comCodeLabel.Text = "**";
			// 
			// descLabel
			// 
			this.descLabel.AutoSize = true;
			this.descLabel.BackColor = System.Drawing.Color.Transparent;
			this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.descLabel.Location = new System.Drawing.Point(87, 82);
			this.descLabel.Name = "descLabel";
			this.descLabel.Size = new System.Drawing.Size(20, 18);
			this.descLabel.TabIndex = 47;
			this.descLabel.Text = "**";
			// 
			// comLabel
			// 
			this.comLabel.AutoSize = true;
			this.comLabel.BackColor = System.Drawing.Color.Transparent;
			this.comLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.comLabel.Location = new System.Drawing.Point(109, 55);
			this.comLabel.Name = "comLabel";
			this.comLabel.Size = new System.Drawing.Size(20, 18);
			this.comLabel.TabIndex = 46;
			this.comLabel.Text = "**";
			// 
			// matLabel
			// 
			this.matLabel.AutoSize = true;
			this.matLabel.BackColor = System.Drawing.Color.Transparent;
			this.matLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matLabel.ForeColor = System.Drawing.Color.OrangeRed;
			this.matLabel.Location = new System.Drawing.Point(99, 31);
			this.matLabel.Name = "matLabel";
			this.matLabel.Size = new System.Drawing.Size(20, 18);
			this.matLabel.TabIndex = 45;
			this.matLabel.Text = "**";
			// 
			// backbtn
			// 
			this.backbtn.Location = new System.Drawing.Point(906, 62);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(102, 39);
			this.backbtn.TabIndex = 44;
			this.backbtn.Text = "Back";
			this.backbtn.UseVisualStyleBackColor = true;
			this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(489, 59);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
			this.dateTimePicker1.TabIndex = 43;
			// 
			// saveDatabase
			// 
			this.saveDatabase.Location = new System.Drawing.Point(906, 105);
			this.saveDatabase.Name = "saveDatabase";
			this.saveDatabase.Size = new System.Drawing.Size(102, 37);
			this.saveDatabase.TabIndex = 40;
			this.saveDatabase.Text = "Save";
			this.saveDatabase.UseVisualStyleBackColor = true;
			this.saveDatabase.Click += new System.EventHandler(this.saveDatabase_Click);
			// 
			// newStock
			// 
			this.newStock.Location = new System.Drawing.Point(906, 21);
			this.newStock.Name = "newStock";
			this.newStock.Size = new System.Drawing.Size(102, 37);
			this.newStock.TabIndex = 39;
			this.newStock.Text = "New Material";
			this.newStock.UseVisualStyleBackColor = true;
			this.newStock.Click += new System.EventHandler(this.newStock_Click);
			// 
			// cardLabelM
			// 
			this.cardLabelM.AutoSize = true;
			this.cardLabelM.Location = new System.Drawing.Point(714, 37);
			this.cardLabelM.Name = "cardLabelM";
			this.cardLabelM.Size = new System.Drawing.Size(38, 13);
			this.cardLabelM.TabIndex = 38;
			this.cardLabelM.Text = "Carton";
			// 
			// revisiontxtbox
			// 
			this.revisiontxtbox.Location = new System.Drawing.Point(489, 133);
			this.revisiontxtbox.Name = "revisiontxtbox";
			this.revisiontxtbox.Size = new System.Drawing.Size(103, 20);
			this.revisiontxtbox.TabIndex = 37;
			// 
			// deleteAll
			// 
			this.deleteAll.Location = new System.Drawing.Point(680, 364);
			this.deleteAll.Name = "deleteAll";
			this.deleteAll.Size = new System.Drawing.Size(107, 23);
			this.deleteAll.TabIndex = 36;
			this.deleteAll.Text = "Delete All";
			this.deleteAll.UseVisualStyleBackColor = true;
			this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
			// 
			// deleteSelected
			// 
			this.deleteSelected.Location = new System.Drawing.Point(793, 364);
			this.deleteSelected.Name = "deleteSelected";
			this.deleteSelected.Size = new System.Drawing.Size(107, 23);
			this.deleteSelected.TabIndex = 35;
			this.deleteSelected.Text = "Delete Selected";
			this.deleteSelected.UseVisualStyleBackColor = true;
			this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
			// 
			// print
			// 
			this.print.Location = new System.Drawing.Point(906, 365);
			this.print.Name = "print";
			this.print.Size = new System.Drawing.Size(106, 23);
			this.print.TabIndex = 34;
			this.print.Text = "Print";
			this.print.UseVisualStyleBackColor = true;
			this.print.Click += new System.EventHandler(this.print_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.singlechkbox);
			this.groupBox3.Controls.Add(this.quartedchkbox);
			this.groupBox3.Location = new System.Drawing.Point(717, 74);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(102, 68);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Print Type";
			this.groupBox3.Visible = false;
			// 
			// singlechkbox
			// 
			this.singlechkbox.AutoSize = true;
			this.singlechkbox.Location = new System.Drawing.Point(8, 24);
			this.singlechkbox.Name = "singlechkbox";
			this.singlechkbox.Size = new System.Drawing.Size(79, 17);
			this.singlechkbox.TabIndex = 31;
			this.singlechkbox.Text = "Single Print";
			this.singlechkbox.UseVisualStyleBackColor = true;
			this.singlechkbox.Visible = false;
			// 
			// quartedchkbox
			// 
			this.quartedchkbox.AutoSize = true;
			this.quartedchkbox.Location = new System.Drawing.Point(8, 40);
			this.quartedchkbox.Name = "quartedchkbox";
			this.quartedchkbox.Size = new System.Drawing.Size(88, 17);
			this.quartedchkbox.TabIndex = 32;
			this.quartedchkbox.Text = "Quarted Print";
			this.quartedchkbox.UseVisualStyleBackColor = true;
			this.quartedchkbox.Visible = false;
			// 
			// addbelowbtn
			// 
			this.addbelowbtn.Location = new System.Drawing.Point(633, 148);
			this.addbelowbtn.Name = "addbelowbtn";
			this.addbelowbtn.Size = new System.Drawing.Size(154, 44);
			this.addbelowbtn.TabIndex = 30;
			this.addbelowbtn.Text = "Add Below";
			this.addbelowbtn.UseVisualStyleBackColor = true;
			this.addbelowbtn.Click += new System.EventHandler(this.addbelowbtn_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(7, 207);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(1005, 151);
			this.dataGridView2.TabIndex = 8;
			// 
			// kartoncombobox
			// 
			this.kartoncombobox.FormattingEnabled = true;
			this.kartoncombobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.kartoncombobox.Location = new System.Drawing.Point(758, 34);
			this.kartoncombobox.Name = "kartoncombobox";
			this.kartoncombobox.Size = new System.Drawing.Size(130, 21);
			this.kartoncombobox.TabIndex = 29;
			// 
			// grossweighttxtbox
			// 
			this.grossweighttxtbox.Location = new System.Drawing.Point(489, 181);
			this.grossweighttxtbox.Name = "grossweighttxtbox";
			this.grossweighttxtbox.Size = new System.Drawing.Size(103, 20);
			this.grossweighttxtbox.TabIndex = 28;
			// 
			// grosLabelM
			// 
			this.grosLabelM.AutoSize = true;
			this.grosLabelM.Location = new System.Drawing.Point(380, 182);
			this.grosLabelM.Name = "grosLabelM";
			this.grosLabelM.Size = new System.Drawing.Size(71, 13);
			this.grosLabelM.TabIndex = 27;
			this.grosLabelM.Text = "Gross Weight";
			// 
			// boxcodetxtbox
			// 
			this.boxcodetxtbox.Location = new System.Drawing.Point(489, 156);
			this.boxcodetxtbox.Name = "boxcodetxtbox";
			this.boxcodetxtbox.ReadOnly = true;
			this.boxcodetxtbox.Size = new System.Drawing.Size(103, 20);
			this.boxcodetxtbox.TabIndex = 26;
			// 
			// boxLabelM
			// 
			this.boxLabelM.AutoSize = true;
			this.boxLabelM.Location = new System.Drawing.Point(380, 157);
			this.boxLabelM.Name = "boxLabelM";
			this.boxLabelM.Size = new System.Drawing.Size(53, 13);
			this.boxLabelM.TabIndex = 25;
			this.boxLabelM.Text = "Box Code";
			// 
			// revLabelM
			// 
			this.revLabelM.AutoSize = true;
			this.revLabelM.Location = new System.Drawing.Point(380, 133);
			this.revLabelM.Name = "revLabelM";
			this.revLabelM.Size = new System.Drawing.Size(48, 13);
			this.revLabelM.TabIndex = 23;
			this.revLabelM.Text = "Revision";
			// 
			// lotnotxtbox
			// 
			this.lotnotxtbox.Location = new System.Drawing.Point(489, 107);
			this.lotnotxtbox.Name = "lotnotxtbox";
			this.lotnotxtbox.Size = new System.Drawing.Size(211, 20);
			this.lotnotxtbox.TabIndex = 22;
			// 
			// lotLabelM
			// 
			this.lotLabelM.AutoSize = true;
			this.lotLabelM.Location = new System.Drawing.Point(380, 108);
			this.lotLabelM.Name = "lotLabelM";
			this.lotLabelM.Size = new System.Drawing.Size(39, 13);
			this.lotLabelM.TabIndex = 21;
			this.lotLabelM.Text = "Lot No";
			// 
			// prodLabelM
			// 
			this.prodLabelM.AutoSize = true;
			this.prodLabelM.Location = new System.Drawing.Point(380, 84);
			this.prodLabelM.Name = "prodLabelM";
			this.prodLabelM.Size = new System.Drawing.Size(84, 13);
			this.prodLabelM.TabIndex = 19;
			this.prodLabelM.Text = "Production Date";
			// 
			// billDateLabelM
			// 
			this.billDateLabelM.AutoSize = true;
			this.billDateLabelM.Location = new System.Drawing.Point(380, 59);
			this.billDateLabelM.Name = "billDateLabelM";
			this.billDateLabelM.Size = new System.Drawing.Size(46, 13);
			this.billDateLabelM.TabIndex = 17;
			this.billDateLabelM.Text = "Bill Date";
			// 
			// billtxtbox
			// 
			this.billtxtbox.Location = new System.Drawing.Point(489, 34);
			this.billtxtbox.Name = "billtxtbox";
			this.billtxtbox.Size = new System.Drawing.Size(211, 20);
			this.billtxtbox.TabIndex = 16;
			// 
			// billNoLabelM
			// 
			this.billNoLabelM.AutoSize = true;
			this.billNoLabelM.Location = new System.Drawing.Point(380, 35);
			this.billNoLabelM.Name = "billNoLabelM";
			this.billNoLabelM.Size = new System.Drawing.Size(37, 13);
			this.billNoLabelM.TabIndex = 15;
			this.billNoLabelM.Text = "Bill No";
			// 
			// operatortxtbox
			// 
			this.operatortxtbox.Location = new System.Drawing.Point(139, 179);
			this.operatortxtbox.Name = "operatortxtbox";
			this.operatortxtbox.Size = new System.Drawing.Size(213, 20);
			this.operatortxtbox.TabIndex = 14;
			// 
			// opLabelM
			// 
			this.opLabelM.AutoSize = true;
			this.opLabelM.Location = new System.Drawing.Point(32, 180);
			this.opLabelM.Name = "opLabelM";
			this.opLabelM.Size = new System.Drawing.Size(65, 13);
			this.opLabelM.TabIndex = 13;
			this.opLabelM.Text = "Operator No";
			// 
			// counttxtbox
			// 
			this.counttxtbox.Location = new System.Drawing.Point(139, 154);
			this.counttxtbox.Name = "counttxtbox";
			this.counttxtbox.Size = new System.Drawing.Size(213, 20);
			this.counttxtbox.TabIndex = 12;
			this.counttxtbox.TextChanged += new System.EventHandler(this.counttxtbox_TextChanged);
			// 
			// countLabelM
			// 
			this.countLabelM.AutoSize = true;
			this.countLabelM.Location = new System.Drawing.Point(32, 155);
			this.countLabelM.Name = "countLabelM";
			this.countLabelM.Size = new System.Drawing.Size(35, 13);
			this.countLabelM.TabIndex = 11;
			this.countLabelM.Text = "Count";
			// 
			// unittxtbox
			// 
			this.unittxtbox.Location = new System.Drawing.Point(139, 130);
			this.unittxtbox.Name = "unittxtbox";
			this.unittxtbox.ReadOnly = true;
			this.unittxtbox.Size = new System.Drawing.Size(213, 20);
			this.unittxtbox.TabIndex = 10;
			this.unittxtbox.TextChanged += new System.EventHandler(this.unittxtbox_TextChanged);
			// 
			// unitLabelM
			// 
			this.unitLabelM.AutoSize = true;
			this.unitLabelM.Location = new System.Drawing.Point(32, 131);
			this.unitLabelM.Name = "unitLabelM";
			this.unitLabelM.Size = new System.Drawing.Size(26, 13);
			this.unitLabelM.TabIndex = 9;
			this.unitLabelM.Text = "Unit";
			// 
			// companycodetxtbox
			// 
			this.companycodetxtbox.Location = new System.Drawing.Point(139, 105);
			this.companycodetxtbox.Name = "companycodetxtbox";
			this.companycodetxtbox.ReadOnly = true;
			this.companycodetxtbox.Size = new System.Drawing.Size(213, 20);
			this.companycodetxtbox.TabIndex = 8;
			this.companycodetxtbox.TextChanged += new System.EventHandler(this.companycodetxtbox_TextChanged);
			// 
			// comCodeLabelM
			// 
			this.comCodeLabelM.AutoSize = true;
			this.comCodeLabelM.Location = new System.Drawing.Point(32, 106);
			this.comCodeLabelM.Name = "comCodeLabelM";
			this.comCodeLabelM.Size = new System.Drawing.Size(79, 13);
			this.comCodeLabelM.TabIndex = 7;
			this.comCodeLabelM.Text = "Company Code";
			// 
			// description2txtbox
			// 
			this.description2txtbox.Location = new System.Drawing.Point(139, 81);
			this.description2txtbox.Name = "description2txtbox";
			this.description2txtbox.ReadOnly = true;
			this.description2txtbox.Size = new System.Drawing.Size(213, 20);
			this.description2txtbox.TabIndex = 6;
			this.description2txtbox.TextChanged += new System.EventHandler(this.description2txtbox_TextChanged);
			// 
			// descLabelM
			// 
			this.descLabelM.AutoSize = true;
			this.descLabelM.Location = new System.Drawing.Point(32, 82);
			this.descLabelM.Name = "descLabelM";
			this.descLabelM.Size = new System.Drawing.Size(60, 13);
			this.descLabelM.TabIndex = 5;
			this.descLabelM.Text = "Description";
			// 
			// companynametxtbox
			// 
			this.companynametxtbox.Location = new System.Drawing.Point(139, 56);
			this.companynametxtbox.Name = "companynametxtbox";
			this.companynametxtbox.ReadOnly = true;
			this.companynametxtbox.Size = new System.Drawing.Size(213, 20);
			this.companynametxtbox.TabIndex = 4;
			this.companynametxtbox.TextChanged += new System.EventHandler(this.companynametxtbox_TextChanged);
			// 
			// comLabelM
			// 
			this.comLabelM.AutoSize = true;
			this.comLabelM.Location = new System.Drawing.Point(32, 57);
			this.comLabelM.Name = "comLabelM";
			this.comLabelM.Size = new System.Drawing.Size(82, 13);
			this.comLabelM.TabIndex = 3;
			this.comLabelM.Text = "Company Name";
			// 
			// material2txtbox
			// 
			this.material2txtbox.Location = new System.Drawing.Point(139, 32);
			this.material2txtbox.Name = "material2txtbox";
			this.material2txtbox.ReadOnly = true;
			this.material2txtbox.Size = new System.Drawing.Size(213, 20);
			this.material2txtbox.TabIndex = 2;
			this.material2txtbox.TextChanged += new System.EventHandler(this.material2txtbox_TextChanged);
			// 
			// matLabelM
			// 
			this.matLabelM.AutoSize = true;
			this.matLabelM.Location = new System.Drawing.Point(32, 33);
			this.matLabelM.Name = "matLabelM";
			this.matLabelM.Size = new System.Drawing.Size(72, 13);
			this.matLabelM.TabIndex = 0;
			this.matLabelM.Text = "Material Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 674);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "PCİ-MTK";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button materialbtn;
		private System.Windows.Forms.TextBox materialtxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button reloadbtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox companycodetxtbox;
		private System.Windows.Forms.Label comCodeLabelM;
		private System.Windows.Forms.TextBox description2txtbox;
		private System.Windows.Forms.Label descLabelM;
		private System.Windows.Forms.TextBox companynametxtbox;
		private System.Windows.Forms.Label comLabelM;
		private System.Windows.Forms.TextBox material2txtbox;
		private System.Windows.Forms.Label matLabelM;
		private System.Windows.Forms.Button print;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox singlechkbox;
		private System.Windows.Forms.CheckBox quartedchkbox;
		private System.Windows.Forms.Button addbelowbtn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox kartoncombobox;
		private System.Windows.Forms.TextBox grossweighttxtbox;
		private System.Windows.Forms.Label grosLabelM;
		private System.Windows.Forms.TextBox boxcodetxtbox;
		private System.Windows.Forms.Label boxLabelM;
		private System.Windows.Forms.Label revLabelM;
		private System.Windows.Forms.TextBox lotnotxtbox;
		private System.Windows.Forms.Label lotLabelM;
		private System.Windows.Forms.Label prodLabelM;
		private System.Windows.Forms.Label billDateLabelM;
		private System.Windows.Forms.TextBox billtxtbox;
		private System.Windows.Forms.Label billNoLabelM;
		private System.Windows.Forms.TextBox operatortxtbox;
		private System.Windows.Forms.Label opLabelM;
		private System.Windows.Forms.TextBox counttxtbox;
		private System.Windows.Forms.Label countLabelM;
		private System.Windows.Forms.TextBox unittxtbox;
		private System.Windows.Forms.Label unitLabelM;
		private System.Windows.Forms.Button deleteSelected;
		private System.Windows.Forms.Button deleteAll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox revisiontxtbox;
		private System.Windows.Forms.Label cardLabelM;
		private System.Windows.Forms.Button saveDatabase;
		private System.Windows.Forms.Button newStock;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button backbtn;
		private System.Windows.Forms.Label matLabel;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.Label unitLabel;
		private System.Windows.Forms.Label comCodeLabel;
		private System.Windows.Forms.Label descLabel;
		private System.Windows.Forms.Label comLabel;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
	}
}

