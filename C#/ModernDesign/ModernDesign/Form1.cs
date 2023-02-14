namespace ModernDesign
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void window1_Click(object sender, EventArgs e)
		{
			panelMain1.BringToFront();
			panelMain1.Dock = DockStyle.Fill;
		}

		private void window2_Click(object sender, EventArgs e)
		{
			panelMain2.BringToFront();
			panelMain2.Dock = DockStyle.Fill;
		}

		private void window3_Click(object sender, EventArgs e)
		{
			panelMain3.BringToFront();
			panelMain3.Dock = DockStyle.Fill;
		}
	}
}