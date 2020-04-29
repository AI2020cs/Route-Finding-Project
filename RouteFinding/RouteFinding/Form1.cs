using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteFinding
{
	public partial class RouteFinding : Form
	{
		public RouteFinding()
		{
			InitializeComponent();
		}

		private void RouteFinding_Load(object sender, EventArgs e)
		{

		}

		private void PB_Click(object sender, EventArgs e)
		{

		}

		private void btnCost_Click(object sender, EventArgs e)
		{
			MessageBox.Show(",A_B-->05 \t,A_D-->08 \t,B_C-->15 \n,B_D-->10 \t,B_E-->06 \t\t,C_D-->05 \n,D_E-->03 \t\t,E_G-->10 \t\t," +
				"D_F-->09 \n,F_G-->05 \t\t,F_H-->05 \t,F_J-->08 \n,H_J-->05 \t\t,G_I-->06 \t\t,I_J-->07");
		}

		private void HA_Start_Click(object sender, EventArgs e)
		{
			Point a = new Point(86, 25);
			Point b = new Point(12, 156);
			Point d = new Point(243, 172);

			Point[] A = { a, b, a, d };
			this.CreateGraphics().DrawLines(Pens.Blue, A);
		}

		private void HB_Click(object sender, EventArgs e)
		{
			Point pb = new Point(12, 156);
			Point pa = new Point(86, 25);
			Point pc = new Point(309, 27);
			Point pd = new Point(243, 172);
			Point pe = new Point(145, 263);

			Point[] B = { pb, pa, pb, pc, pb, pd, pb, pe };
			this.CreateGraphics().DrawLines(Pens.Blue, B);
		}

		private void HC_Click(object sender, EventArgs e)
		{
			Point c = new Point(309, 27);
			Point b = new Point(12, 156);
			Point d = new Point(243, 172);

			Point[] C = { c, b, c, d };
			this.CreateGraphics().DrawLines(Pens.Blue, C);
		}

		private void HD_Click(object sender, EventArgs e)
		{
			Point d = new Point(243, 172);
			Point pe = new Point(145, 263);
			Point b = new Point(12, 156);
			Point a = new Point(86, 25);
			Point c = new Point(309, 27);
			Point f = new Point(452, 121);

			Point[] D = { d, pe, d, b, d, a, d, c, d, f };
			this.CreateGraphics().DrawLines(Pens.Blue, D);
		}

		private void HE_Click(object sender, EventArgs e)
		{
			Point pe = new Point(145, 263);
			Point b = new Point(12, 156);
			Point d = new Point(243, 172);
			Point g = new Point(380, 248);

			Point[] E = { pe, b, pe, d, pe, g };
			this.CreateGraphics().DrawLines(Pens.Blue, E);
		}

		private void HF_Click(object sender, EventArgs e)
		{
			Point f = new Point(452, 121);
			Point d = new Point(243, 172);
			Point g = new Point(380, 248);
			Point j = new Point(678, 137);
			Point h = new Point(564, 54);

			Point[] F = { f, d, f, g, f, j, f, h };
			this.CreateGraphics().DrawLines(Pens.Blue, F);
		}

		private void HG_Click(object sender, EventArgs e)
		{
			Point g = new Point(380, 248);
			Point pe = new Point(145, 263);
			Point f = new Point(452, 121);
			Point i = new Point(554, 263);

			Point[] G = { g, pe, g, f, g, i };
			this.CreateGraphics().DrawLines(Pens.Blue, G);
		}

		private void HH_Click(object sender, EventArgs e)
		{
			Point h = new Point(564, 54);
			Point f = new Point(452, 121);
			Point j = new Point(678, 137);

			Point[] H = { h, f, h, j };
			this.CreateGraphics().DrawLines(Pens.Blue, H);
		}

		private void HI_Click(object sender, EventArgs e)
		{
			Point i = new Point(554, 263);
			Point g = new Point(380, 248);
			Point j = new Point(678, 137);

			Point[] I = { i, g, i, j };
			this.CreateGraphics().DrawLines(Pens.Blue, I);
		}

		private void HJ_Goal_Click(object sender, EventArgs e)
		{
			Point j = new Point(678, 137);
			Point i = new Point(554, 263);
			Point f = new Point(452, 121);
			Point h = new Point(564, 54);

			Point[] J = { j, i, j, f, j, h };
			this.CreateGraphics().DrawLines(Pens.Blue, J);
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			Point a = new Point(86, 25);
			Point b = new Point(12, 156);
			Point c = new Point(309, 27);
			Point d = new Point(243, 172);
			Point pe = new Point(145, 263);
			Point f = new Point(452, 121);
			Point g = new Point(380, 248);
			Point h = new Point(564, 54);
			Point i = new Point(554, 263);
			Point j = new Point(678, 137);

			Point[] R = { a, b, a, d , b,a, b, c, b, d, b, pe , c, b, c, d , d, pe, d, b, d, a, d, c, d, f ,
			pe, b, pe, d, pe, g,f, d, f, g, f, j, f, h,g, pe, g, f, g, i,j, i, j, f, j, h};
			this.CreateGraphics().DrawLines(Pens.WhiteSmoke, R);
		}
	}
}
