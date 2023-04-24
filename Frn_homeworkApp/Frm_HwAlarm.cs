using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Frn_homeworkApp
{
    public partial class Frm_HwAlarm : Form
    {
        public Frm_HwAlarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("hh:mm:ss");

            if (checkBox1.Checked &&
                txthh.Text == DateTime.Now.ToString("hh") &&
                txtmm.Text == DateTime.Now.ToString("mm") &&
                txtss.Text == DateTime.Now.ToString("ss")          
                )
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\Resources\尖叫牛仔.wav");
                player.Play();
            }


        }

        void time()
        {

            if(!(int.TryParse(txthh.Text,out int hh)))
            {
                MessageBox.Show("請輸入數值");
            }
            if (!(int.TryParse(txtmm.Text, out int mm)))
            {
                MessageBox.Show("請輸入數值");
            }
            if (!(int.TryParse(txtss.Text, out int ss)))
            {
                MessageBox.Show("請輸入數值");
            }
        }
        

    }
}
