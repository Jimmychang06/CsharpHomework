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
    public partial class Frm_HwPicture_View : Form
    {
        public Frm_HwPicture_View()
        {
            InitializeComponent();
        }
        //void picshow()
        //{
        //    Frm_PictureShow pic = new Frm_PictureShow(); 
        //    pic.Show();
        //    pic.pictureBox1.Image = pictureBox1.Image;
        //    pic.pictureBox1.Image = pictureBox2.Image;
        //}

            
        Frm_PictureShow pic = new Frm_PictureShow();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox5.Image;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox6.Image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox7.Image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_PictureShow pic = new Frm_PictureShow();
            pic.Show();
            pic.pictureBox1.Image = pictureBox8.Image;
        }
    }
}
