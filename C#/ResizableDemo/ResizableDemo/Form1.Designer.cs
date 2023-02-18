namespace ResizableDemo
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
			this.menuPanel = new System.Windows.Forms.Panel();
			this.menuLabel = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.labelInfoPanel = new System.Windows.Forms.Panel();
			this.selectMaterialPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.stockView = new System.Windows.Forms.DataGridView();
			this.selectMaterialLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.menuPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.selectMaterialPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stockView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuPanel.Controls.Add(this.menuLabel);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1098, 30);
			this.menuPanel.TabIndex = 0;
			// 
			// menuLabel
			// 
			this.menuLabel.AutoSize = true;
			this.menuLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuLabel.Location = new System.Drawing.Point(34, 4);
			this.menuLabel.Name = "menuLabel";
			this.menuLabel.Size = new System.Drawing.Size(74, 21);
			this.menuLabel.TabIndex = 0;
			this.menuLabel.Text = "PCI-MTK";
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.mainPanel.Controls.Add(this.labelInfoPanel);
			this.mainPanel.Controls.Add(this.selectMaterialPanel);
			this.mainPanel.Location = new System.Drawing.Point(0, 30);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1090, 620);
			this.mainPanel.TabIndex = 1;
			// 
			// labelInfoPanel
			// 
			this.labelInfoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.labelInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInfoPanel.ForeColor = System.Drawing.Color.Coral;
			this.labelInfoPanel.Location = new System.Drawing.Point(0, 310);
			this.labelInfoPanel.Name = "labelInfoPanel";
			this.labelInfoPanel.Size = new System.Drawing.Size(1090, 310);
			this.labelInfoPanel.TabIndex = 1;
			// 
			// selectMaterialPanel
			// 
			this.selectMaterialPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.selectMaterialPanel.Controls.Add(this.button5);
			this.selectMaterialPanel.Controls.Add(this.label2);
			this.selectMaterialPanel.Controls.Add(this.button4);
			this.selectMaterialPanel.Controls.Add(this.textBox1);
			this.selectMaterialPanel.Controls.Add(this.button3);
			this.selectMaterialPanel.Controls.Add(this.label1);
			this.selectMaterialPanel.Controls.Add(this.button2);
			this.selectMaterialPanel.Controls.Add(this.panel1);
			this.selectMaterialPanel.Controls.Add(this.button1);
			this.selectMaterialPanel.Controls.Add(this.selectMaterialLabel);
			this.selectMaterialPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.selectMaterialPanel.Location = new System.Drawing.Point(0, 0);
			this.selectMaterialPanel.Name = "selectMaterialPanel";
			this.selectMaterialPanel.Size = new System.Drawing.Size(1090, 310);
			this.selectMaterialPanel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.Controls.Add(this.stockView);
			this.panel1.Location = new System.Drawing.Point(15, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(820, 261);
			this.panel1.TabIndex = 2;
			// 
			// stockView
			// 
			this.stockView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stockView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stockView.Location = new System.Drawing.Point(0, 0);
			this.stockView.Name = "stockView";
			this.stockView.Size = new System.Drawing.Size(820, 261);
			this.stockView.TabIndex = 0;
			// 
			// selectMaterialLabel
			// 
			this.selectMaterialLabel.AutoSize = true;
			this.selectMaterialLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectMaterialLabel.Location = new System.Drawing.Point(11, 11);
			this.selectMaterialLabel.Name = "selectMaterialLabel";
			this.selectMaterialLabel.Size = new System.Drawing.Size(122, 19);
			this.selectMaterialLabel.TabIndex = 1;
			this.selectMaterialLabel.Text = "Select Material";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(846, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Filter with Material Code";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(850, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(236, 26);
			this.textBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(846, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Add, Edit, Delete Material";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(850, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(850, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(236, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(850, 182);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(236, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(850, 221);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(236, 34);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(850, 260);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(236, 34);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1098, 658);
			this.ControlBox = false;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.menuPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimumSize = new System.Drawing.Size(1100, 660);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuPanel.ResumeLayout(false);
			this.menuPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.selectMaterialPanel.ResumeLayout(false);
			this.selectMaterialPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.stockView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Label menuLabel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Panel labelInfoPanel;
		private System.Windows.Forms.Panel selectMaterialPanel;
		private System.Windows.Forms.Label selectMaterialLabel;
		private System.Windows.Forms.DataGridView stockView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

