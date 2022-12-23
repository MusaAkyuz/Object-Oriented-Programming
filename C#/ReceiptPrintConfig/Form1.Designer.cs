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
			this.reloadbtn = new System.Windows.Forms.Button();
			this.descriptionbtn = new System.Windows.Forms.Button();
			this.descriptiontxtbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.materialbtn = new System.Windows.Forms.Button();
			this.materialtxtbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.reloadbtn);
			this.groupBox1.Controls.Add(this.descriptionbtn);
			this.groupBox1.Controls.Add(this.descriptiontxtbox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.materialbtn);
			this.groupBox1.Controls.Add(this.materialtxtbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1004, 257);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock Database";
			// 
			// reloadbtn
			// 
			this.reloadbtn.Location = new System.Drawing.Point(762, 222);
			this.reloadbtn.Name = "reloadbtn";
			this.reloadbtn.Size = new System.Drawing.Size(232, 29);
			this.reloadbtn.TabIndex = 7;
			this.reloadbtn.Text = "Reload Database";
			this.reloadbtn.UseVisualStyleBackColor = true;
			// 
			// descriptionbtn
			// 
			this.descriptionbtn.Location = new System.Drawing.Point(766, 140);
			this.descriptionbtn.Name = "descriptionbtn";
			this.descriptionbtn.Size = new System.Drawing.Size(232, 29);
			this.descriptionbtn.TabIndex = 6;
			this.descriptionbtn.Text = "Filter";
			this.descriptionbtn.UseVisualStyleBackColor = true;
			// 
			// descriptiontxtbox
			// 
			this.descriptiontxtbox.Location = new System.Drawing.Point(766, 113);
			this.descriptiontxtbox.Name = "descriptiontxtbox";
			this.descriptiontxtbox.Size = new System.Drawing.Size(232, 20);
			this.descriptiontxtbox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(763, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description";
			// 
			// materialbtn
			// 
			this.materialbtn.Location = new System.Drawing.Point(766, 64);
			this.materialbtn.Name = "materialbtn";
			this.materialbtn.Size = new System.Drawing.Size(232, 29);
			this.materialbtn.TabIndex = 3;
			this.materialbtn.Text = "Filter";
			this.materialbtn.UseVisualStyleBackColor = true;
			this.materialbtn.Click += new System.EventHandler(this.materialbtn_Click);
			// 
			// materialtxtbox
			// 
			this.materialtxtbox.Location = new System.Drawing.Point(766, 37);
			this.materialtxtbox.Name = "materialtxtbox";
			this.materialtxtbox.Size = new System.Drawing.Size(232, 20);
			this.materialtxtbox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(763, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Material Code";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 20);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(749, 231);
			this.dataGridView1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 523);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "a";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button descriptionbtn;
		private System.Windows.Forms.TextBox descriptiontxtbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button materialbtn;
		private System.Windows.Forms.TextBox materialtxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button reloadbtn;
	}
}

