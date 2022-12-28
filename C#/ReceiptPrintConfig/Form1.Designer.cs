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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reloadbtn = new System.Windows.Forms.Button();
			this.descriptionbtn = new System.Windows.Forms.Button();
			this.descriptiontxtbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.materialbtn = new System.Windows.Forms.Button();
			this.materialtxtbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
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
			this.label4 = new System.Windows.Forms.Label();
			this.boxcodetxtbox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lotnotxtbox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.productiontxtbox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.billdatetxtbox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.billtxtbox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.operatortxtbox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.counttxtbox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.unittxtbox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.companycodetxtbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.description2txtbox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.companynametxtbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.material2txtbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
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
			this.groupBox1.Controls.Add(this.descriptionbtn);
			this.groupBox1.Controls.Add(this.descriptiontxtbox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.materialbtn);
			this.groupBox1.Controls.Add(this.materialtxtbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1018, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock Database";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
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
			this.reloadbtn.Text = "Reload Database";
			this.reloadbtn.UseVisualStyleBackColor = true;
			this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
			// 
			// descriptionbtn
			// 
			this.descriptionbtn.Location = new System.Drawing.Point(831, 140);
			this.descriptionbtn.Name = "descriptionbtn";
			this.descriptionbtn.Size = new System.Drawing.Size(181, 29);
			this.descriptionbtn.TabIndex = 6;
			this.descriptionbtn.Text = "Filter";
			this.descriptionbtn.UseVisualStyleBackColor = true;
			this.descriptionbtn.Click += new System.EventHandler(this.descriptionbtn_Click);
			// 
			// descriptiontxtbox
			// 
			this.descriptiontxtbox.Location = new System.Drawing.Point(831, 113);
			this.descriptiontxtbox.Name = "descriptiontxtbox";
			this.descriptiontxtbox.Size = new System.Drawing.Size(181, 20);
			this.descriptiontxtbox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(828, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description";
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
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.revisiontxtbox);
			this.groupBox2.Controls.Add(this.deleteAll);
			this.groupBox2.Controls.Add(this.deleteSelected);
			this.groupBox2.Controls.Add(this.print);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.addbelowbtn);
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Controls.Add(this.kartoncombobox);
			this.groupBox2.Controls.Add(this.grossweighttxtbox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.boxcodetxtbox);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.lotnotxtbox);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.productiontxtbox);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.billdatetxtbox);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.billtxtbox);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.operatortxtbox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.counttxtbox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.unittxtbox);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.companycodetxtbox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.description2txtbox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.companynametxtbox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.material2txtbox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1018, 396);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Label Info";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(834, 38);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(38, 13);
			this.label17.TabIndex = 38;
			this.label17.Text = "Karton";
			// 
			// revisiontxtbox
			// 
			this.revisiontxtbox.Location = new System.Drawing.Point(468, 133);
			this.revisiontxtbox.Name = "revisiontxtbox";
			this.revisiontxtbox.Size = new System.Drawing.Size(124, 20);
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
			this.groupBox3.Location = new System.Drawing.Point(720, 32);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(102, 58);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Print Type";
			// 
			// singlechkbox
			// 
			this.singlechkbox.AutoSize = true;
			this.singlechkbox.Location = new System.Drawing.Point(6, 19);
			this.singlechkbox.Name = "singlechkbox";
			this.singlechkbox.Size = new System.Drawing.Size(79, 17);
			this.singlechkbox.TabIndex = 31;
			this.singlechkbox.Text = "Single Print";
			this.singlechkbox.UseVisualStyleBackColor = true;
			// 
			// quartedchkbox
			// 
			this.quartedchkbox.AutoSize = true;
			this.quartedchkbox.Location = new System.Drawing.Point(6, 35);
			this.quartedchkbox.Name = "quartedchkbox";
			this.quartedchkbox.Size = new System.Drawing.Size(88, 17);
			this.quartedchkbox.TabIndex = 32;
			this.quartedchkbox.Text = "Quarted Print";
			this.quartedchkbox.UseVisualStyleBackColor = true;
			// 
			// addbelowbtn
			// 
			this.addbelowbtn.Location = new System.Drawing.Point(598, 130);
			this.addbelowbtn.Name = "addbelowbtn";
			this.addbelowbtn.Size = new System.Drawing.Size(102, 71);
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
			this.kartoncombobox.Location = new System.Drawing.Point(888, 35);
			this.kartoncombobox.Name = "kartoncombobox";
			this.kartoncombobox.Size = new System.Drawing.Size(124, 21);
			this.kartoncombobox.TabIndex = 29;
			// 
			// grossweighttxtbox
			// 
			this.grossweighttxtbox.Location = new System.Drawing.Point(468, 181);
			this.grossweighttxtbox.Name = "grossweighttxtbox";
			this.grossweighttxtbox.Size = new System.Drawing.Size(124, 20);
			this.grossweighttxtbox.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(380, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Gross Weight";
			// 
			// boxcodetxtbox
			// 
			this.boxcodetxtbox.Location = new System.Drawing.Point(468, 156);
			this.boxcodetxtbox.Name = "boxcodetxtbox";
			this.boxcodetxtbox.ReadOnly = true;
			this.boxcodetxtbox.Size = new System.Drawing.Size(124, 20);
			this.boxcodetxtbox.TabIndex = 26;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(380, 157);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Box Code";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(380, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Revision";
			// 
			// lotnotxtbox
			// 
			this.lotnotxtbox.Location = new System.Drawing.Point(468, 107);
			this.lotnotxtbox.Name = "lotnotxtbox";
			this.lotnotxtbox.Size = new System.Drawing.Size(232, 20);
			this.lotnotxtbox.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(380, 108);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(39, 13);
			this.label13.TabIndex = 21;
			this.label13.Text = "Lot No";
			// 
			// productiontxtbox
			// 
			this.productiontxtbox.Location = new System.Drawing.Point(468, 83);
			this.productiontxtbox.Name = "productiontxtbox";
			this.productiontxtbox.ReadOnly = true;
			this.productiontxtbox.Size = new System.Drawing.Size(232, 20);
			this.productiontxtbox.TabIndex = 20;
			this.productiontxtbox.TextChanged += new System.EventHandler(this.productiontxtbox_TextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(380, 84);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 13);
			this.label14.TabIndex = 19;
			this.label14.Text = "Production Date";
			// 
			// billdatetxtbox
			// 
			this.billdatetxtbox.Location = new System.Drawing.Point(468, 58);
			this.billdatetxtbox.Name = "billdatetxtbox";
			this.billdatetxtbox.Size = new System.Drawing.Size(232, 20);
			this.billdatetxtbox.TabIndex = 18;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(380, 59);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 13);
			this.label15.TabIndex = 17;
			this.label15.Text = "Bill Date";
			// 
			// billtxtbox
			// 
			this.billtxtbox.Location = new System.Drawing.Point(468, 34);
			this.billtxtbox.Name = "billtxtbox";
			this.billtxtbox.Size = new System.Drawing.Size(232, 20);
			this.billtxtbox.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(380, 35);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(37, 13);
			this.label16.TabIndex = 15;
			this.label16.Text = "Bill No";
			// 
			// operatortxtbox
			// 
			this.operatortxtbox.Location = new System.Drawing.Point(120, 179);
			this.operatortxtbox.Name = "operatortxtbox";
			this.operatortxtbox.Size = new System.Drawing.Size(232, 20);
			this.operatortxtbox.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Operator No";
			// 
			// counttxtbox
			// 
			this.counttxtbox.Location = new System.Drawing.Point(120, 154);
			this.counttxtbox.Name = "counttxtbox";
			this.counttxtbox.Size = new System.Drawing.Size(232, 20);
			this.counttxtbox.TabIndex = 12;
			this.counttxtbox.TextChanged += new System.EventHandler(this.counttxtbox_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(32, 155);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Count";
			// 
			// unittxtbox
			// 
			this.unittxtbox.Location = new System.Drawing.Point(120, 130);
			this.unittxtbox.Name = "unittxtbox";
			this.unittxtbox.ReadOnly = true;
			this.unittxtbox.Size = new System.Drawing.Size(232, 20);
			this.unittxtbox.TabIndex = 10;
			this.unittxtbox.TextChanged += new System.EventHandler(this.unittxtbox_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(32, 131);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(26, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Unit";
			// 
			// companycodetxtbox
			// 
			this.companycodetxtbox.Location = new System.Drawing.Point(120, 105);
			this.companycodetxtbox.Name = "companycodetxtbox";
			this.companycodetxtbox.ReadOnly = true;
			this.companycodetxtbox.Size = new System.Drawing.Size(232, 20);
			this.companycodetxtbox.TabIndex = 8;
			this.companycodetxtbox.TextChanged += new System.EventHandler(this.companycodetxtbox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Company Code";
			// 
			// description2txtbox
			// 
			this.description2txtbox.Location = new System.Drawing.Point(120, 81);
			this.description2txtbox.Name = "description2txtbox";
			this.description2txtbox.ReadOnly = true;
			this.description2txtbox.Size = new System.Drawing.Size(232, 20);
			this.description2txtbox.TabIndex = 6;
			this.description2txtbox.TextChanged += new System.EventHandler(this.description2txtbox_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Description";
			// 
			// companynametxtbox
			// 
			this.companynametxtbox.Location = new System.Drawing.Point(120, 56);
			this.companynametxtbox.Name = "companynametxtbox";
			this.companynametxtbox.ReadOnly = true;
			this.companynametxtbox.Size = new System.Drawing.Size(232, 20);
			this.companynametxtbox.TabIndex = 4;
			this.companynametxtbox.TextChanged += new System.EventHandler(this.companynametxtbox_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Company Name";
			// 
			// material2txtbox
			// 
			this.material2txtbox.Location = new System.Drawing.Point(120, 32);
			this.material2txtbox.Name = "material2txtbox";
			this.material2txtbox.ReadOnly = true;
			this.material2txtbox.Size = new System.Drawing.Size(232, 20);
			this.material2txtbox.TabIndex = 2;
			this.material2txtbox.TextChanged += new System.EventHandler(this.material2txtbox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Material Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 674);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Receipt Print";
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
		private System.Windows.Forms.Button descriptionbtn;
		private System.Windows.Forms.TextBox descriptiontxtbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button materialbtn;
		private System.Windows.Forms.TextBox materialtxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button reloadbtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox companycodetxtbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox description2txtbox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox companynametxtbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox material2txtbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button print;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox singlechkbox;
		private System.Windows.Forms.CheckBox quartedchkbox;
		private System.Windows.Forms.Button addbelowbtn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox kartoncombobox;
		private System.Windows.Forms.TextBox grossweighttxtbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox boxcodetxtbox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox lotnotxtbox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox productiontxtbox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox billdatetxtbox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox billtxtbox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox operatortxtbox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox counttxtbox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox unittxtbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button deleteSelected;
		private System.Windows.Forms.Button deleteAll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox revisiontxtbox;
		private System.Windows.Forms.Label label17;
	}
}

