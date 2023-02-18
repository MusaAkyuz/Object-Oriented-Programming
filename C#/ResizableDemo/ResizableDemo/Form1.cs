using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResizableDemo
{
	public partial class Form1 : Form
	{
		private const int cGrip = 16;
		private MakeMovable _move;

		//private Rectangle oriSelectMaterialPanel;

		//private Rectangle oriNewButton;
		//private Rectangle oriEditButton;
		//private Rectangle oriDeleteButton;
		//private Rectangle oriCancelButton;
		//private Rectangle oriSaveButton;
		public Form1()
		{
			InitializeComponent();
			_move = new MakeMovable(this);
			_move.SetMovable(menuPanel, menuLabel);
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
			ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
		}
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x84)
			{
				Point pos = new Point(m.LParam.ToInt32());
				pos = this.PointToScreen(pos);
				if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
				{
					m.Result = (IntPtr)17;
					return;
				}
			}
			base.WndProc(ref m);
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			this.selectMaterialPanel.Height = mainPanel.Height / 2;
			this.labelInfoPanel.Location = new Point(0, this.selectMaterialPanel.Height);

			//ResizeControl(button1, oriNewButton);
			//ResizeControl(button2, oriEditButton);
			//ResizeControl(button3, oriDeleteButton);
			//ResizeControl(button4, oriCancelButton);
			//ResizeControl(button5, oriSaveButton);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//oriSelectMaterialPanel = new Rectangle(selectMaterialPanel.Location, selectMaterialPanel.Size);

			//oriNewButton = new Rectangle(button1.Location, button1.Size);
			//oriEditButton = new Rectangle(button2.Location, button2.Size);
			//oriDeleteButton = new Rectangle(button3.Location, button3.Size);
			//oriCancelButton = new Rectangle(button4.Location, button4.Size);
			//oriSaveButton = new Rectangle(button5.Location, button5.Size);
		}

		//private void ResizeControl(Control control, Rectangle rect)
		//{
		//	float xRatio = (float)this.ClientRectangle.Width / (float)oriSelectMaterialPanel.Width;
		//	float yRatio = (float)this.ClientRectangle.Height / (float)oriSelectMaterialPanel.Height;

		//	float newX = rect.Location.X * xRatio;
		//	float newY = rect.Location.Y * yRatio;

		//	control.Location = new Point((int)newX, (int)newY);
		//	control.Width = (int)(rect.Width * xRatio);
		//	control.Height = (int)(rect.Height * yRatio);

		//	//float ratio = xRatio;
		//	//if (xRatio >= yRatio)
		//	//{
		//	//	ratio = yRatio;
		//	//}

		//	//float newFontSize = oFont * ratio;
		//	//Font newFont = new Font(control.Font.FontFamily, newFontSize);
		//	//control.Font = newFont; 
		//}
	}
}
