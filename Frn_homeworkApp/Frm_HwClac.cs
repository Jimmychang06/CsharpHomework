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
    public partial class Frm_HwClac : Form
    {
        public Frm_HwClac()
        {
            InitializeComponent();
        }



        private void btnPlus_Click(object sender, EventArgs e)
        {

           if(!(double.TryParse(txtNum1.Text , out double num1)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(double.TryParse(txtNum2.Text, out double num2)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }


            txtAns.Text = (num1+ num2).ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNum1.Text, out double num1)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(double.TryParse(txtNum2.Text, out double num2)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }


            txtAns.Text = (num1 - num2).ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNum1.Text, out double num1)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(double.TryParse(txtNum2.Text, out double num2)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }


            txtAns.Text = (num1 * num2).ToString();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNum1.Text, out double num1)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(double.TryParse(txtNum2.Text, out double num2)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            double zero = 0;
            if(zero==double.Parse(txtNum2.Text ))
            {
                MessageBox.Show("重新輸入數值");
                txtNum2.Clear();
                txtNum2.Focus();
                return;
            }
            else
            {
                txtAns.Text = (num1 / num2).ToString();
            }
            
        }
    }
}
