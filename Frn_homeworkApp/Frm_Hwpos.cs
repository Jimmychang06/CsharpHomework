using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frn_homeworkApp
{
    public partial class Frm_Hwpos : Form
    {
        public Frm_Hwpos()
        {
            InitializeComponent();
        }

        int Jet = 250;
        int Gogoro = 220;
        int Racing = 320;
        int Yamaha = 280;

        int JetCount = 0;
        int GogoroCount = 0;
        int RacingCount = 0;
        int YamahaCount = 0;
        int Payway = 0;

        public void TotalPrice()
        {
           int Total = (Jet* JetCount) + (Gogoro* GogoroCount) + (Racing* RacingCount) + (Yamaha*YamahaCount);
            labTotal.Text = "NT$" + Total;
        }
        public void ListText()
        {
            string list = "";
            Payway = JetCount + GogoroCount + RacingCount + YamahaCount;

            if(JetCount > 0)
            {
                list += "Jets *" + JetCount + "共NT$" + (JetCount * Jet) + "元\r\n";
            }
            if (GogoroCount > 0)
            {
                list += "Gogoro *" + GogoroCount + "共NT$" + (Gogoro * GogoroCount) + "元\r\n";
            }
            if (RacingCount > 0)
            {
                list += "Racing *" + RacingCount + "共NT$" + (Racing * RacingCount) + "元\r\n" ;
            }
            if (YamahaCount > 0)
            {
                list += "Yamaha *" + YamahaCount + "共NT$" + (Yamaha * YamahaCount) + "元\r\n";
            }
            if(Payway == 0)
            {
                list = "尚未點餐";
            }
            txtList.Text = list;
               
        }
        public void Pay()
        {
            Payway = JetCount + GogoroCount + RacingCount + YamahaCount;
            if (Payway > 0)
            {
                MessageBox.Show("總金額 :" + labTotal.Text, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("尚未點餐 ", "確認付款", MessageBoxButtons.OKCancel);
            }
        }
        public void Creditcard()
        {
            Payway = JetCount + GogoroCount + RacingCount + YamahaCount;
            double discount = ((Jet * JetCount) + (Gogoro * GogoroCount) + 
                (Racing * RacingCount) + (Yamaha * YamahaCount)) * 0.9;
            if(Payway > 0)
            {
                MessageBox.Show("總金額 :" + labTotal.Text + "\n折扣後金額 :" + discount ,
                    "確認付款",MessageBoxButtons.OKCancel );
            }
            else
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OKCancel);
            }
        }
        

        private void btnJet_Click(object sender, EventArgs e)
        {
            JetCount++;
            TotalPrice();
            ListText();
        }      
         private void btnGogoro_Click(object sender, EventArgs e)
        {
            GogoroCount++;
            TotalPrice();
            ListText();
        }

        private void btnRacing_Click(object sender, EventArgs e)
        {
            RacingCount++;
            TotalPrice();
            ListText();
        }

        private void btnYamaha_Click(object sender, EventArgs e)
        {
            YamahaCount++;
            TotalPrice();
            ListText();
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            Creditcard();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            JetCount = 0;
            GogoroCount = 0;
            RacingCount = 0;
            YamahaCount = 0;
            Payway = 0;

            ListText();
            TotalPrice();
        }
    }
}
