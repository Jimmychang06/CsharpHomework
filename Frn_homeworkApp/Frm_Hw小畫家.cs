using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frn_homeworkApp
{
    public partial class Frm_Hw小畫家 : Form
    {
        public Frm_Hw小畫家()
        {
            InitializeComponent();
        }

        private void Frm_Hw小畫家_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800 , 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        int X0, Y0;    //繪圖起點座標

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X0 = e.X;
            Y0 = e.Y;       //滑鼠目前位置座標
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.BackColor = colorDialog1.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color,trackBar1.Value );
                g.DrawLine(p, X0, Y0, e.X, e.Y);
                X0 = e.X;
                Y0 = e.Y;
                pictureBox1.Refresh();
            }
        }
    }
}
