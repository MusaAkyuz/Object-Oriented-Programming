namespace ReceiptPrinter
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.databaseView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.metarialCodenmbbox = new System.Windows.Forms.NumericUpDown();
			this.filterbtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.descriptiontxtbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.databaseView)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metarialCodenmbbox)).BeginInit();
			this.SuspendLayout();
			// 
			// databaseView
			// 
			this.databaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.databaseView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.databaseView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
			this.databaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.databaseView.Location = new System.Drawing.Point(6, 22);
			this.databaseView.Name = "databaseView";
			this.databaseView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.databaseView.RowTemplate.Height = 25;
			this.databaseView.Size = new System.Drawing.Size(677, 244);
			this.databaseView.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(689, 243);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Refresh Database";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.metarialCodenmbbox);
			this.groupBox1.Controls.Add(this.filterbtn);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.descriptiontxtbox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.databaseView);
			this.groupBox1.Location = new System.Drawing.Point(12, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(872, 272);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock Database";
			// 
			// metarialCodenmbbox
			// 
			this.metarialCodenmbbox.Location = new System.Drawing.Point(689, 40);
			this.metarialCodenmbbox.Name = "metarialCodenmbbox";
			this.metarialCodenmbbox.Size = new System.Drawing.Size(177, 23);
			this.metarialCodenmbbox.TabIndex = 0;
			// 
			// filterbtn
			// 
			this.filterbtn.Location = new System.Drawing.Point(689, 113);
			this.filterbtn.Name = "filterbtn";
			this.filterbtn.Size = new System.Drawing.Size(177, 23);
			this.filterbtn.TabIndex = 5;
			this.filterbtn.Text = "Filter";
			this.filterbtn.UseVisualStyleBackColor = true;
			this.filterbtn.Click += new System.EventHandler(this.filterbtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(689, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description";
			// 
			// descriptiontxtbox
			// 
			this.descriptiontxtbox.Location = new System.Drawing.Point(689, 84);
			this.descriptiontxtbox.Name = "descriptiontxtbox";
			this.descriptiontxtbox.Size = new System.Drawing.Size(177, 23);
			this.descriptiontxtbox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(689, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Metarial Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 483);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.databaseView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.metarialCodenmbbox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView databaseView;
		private Button button1;
		private GroupBox groupBox1;
		private Label label3;
		private TextBox descriptiontxtbox;
		private Label label2;
		private Button filterbtn;
		private NumericUpDown metarialCodenmbbox;
	}
}