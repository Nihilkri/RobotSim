using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSim {
	public partial class Form1 : Form {
		#region Variables
		Graphics gf, gb; Bitmap gi; int fx, fy, fx2, fy2;
		Robot rob;
		Rectangle[] walls = new Rectangle[64];
		#endregion Variables
		#region Events
		public Form1() { InitializeComponent(); }
		private void Form1_Load(object sender, EventArgs e) {
			fx = ClientSize.Width; fy = ClientSize.Height;
			fx2 = fx / 2; fy2 = fy / 2; gi = new Bitmap(fx, fy);
			gb = Graphics.FromImage(gi); gf = CreateGraphics();



		}
		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			switch(e.KeyCode) {
				case Keys.Escape: Close(); break;

				default: break;
			}
		}
		private void Form1_Click(object sender, EventArgs e) {

		}
		private void tim_Tick(object sender, EventArgs e) {

		}

		#endregion Events
		#region Functions

		#endregion Functions

	}
}
