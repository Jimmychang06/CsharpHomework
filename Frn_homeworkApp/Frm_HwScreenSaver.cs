using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frn_homeworkApp
{
    public partial class Frm_HwScreenSaver : Form
    {
        public Frm_HwScreenSaver()
        {
            InitializeComponent();
        }

        private void Frm_HwScreenSaver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point original;
        private void Frm_HwScreenSaver_Load(object sender, EventArgs e)
        {
            original = Cursor.Position;                       //滑鼠的位置
        }

        private void Frm_HwScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            Point current = Cursor.Position;
            if (original != current)
            {
                Close();
            }
        }

        
            int ImageX = 20, ImageY = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
          pictureBox1.Location = new  Point(pictureBox1.Location.X + ImageX ,  pictureBox1.Location.Y + ImageY); 

            if(pictureBox1.Location.X + pictureBox1.Width > ClientSize.Width || pictureBox1.Location.X <0)
            {
                ImageX = -ImageX;
            }
            if(pictureBox1.Location.Y + pictureBox1.Height> ClientSize.Height || pictureBox1.Location.Y <0)
            {
                ImageY = -ImageY;
            }
        }
    }
}

