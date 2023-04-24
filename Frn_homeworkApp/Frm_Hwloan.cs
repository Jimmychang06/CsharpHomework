using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Frn_homeworkApp.Utility;

namespace Frn_homeworkApp
{
    public partial class Frm_Hwloan : Form
    {
        public Frm_Hwloan()
        {
            InitializeComponent();
        }

        public void btncalculatemonth_Click(object sender, EventArgs e)
        {
            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text) * 12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = double.Parse(txtInsterestRate.Text) / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
            double MonthlyPayment = (TheAmount - DonwPayment) * MonthlyInstersetRate * AmortizationRate;
            int MonthlyPaymentInt = (int)Math.Round(MonthlyPayment);
            MessageBox.Show("月付額" + MonthlyPaymentInt + "元");
        }

        public void btntotal_Click(object sender, EventArgs e)
        {
            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text) * 12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = double.Parse(txtInsterestRate.Text) / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
            double MonthlyPayment = (TheAmount - DonwPayment) * MonthlyInstersetRate * AmortizationRate;
            int MonthlyPaymentInt = (int)Math.Round(MonthlyPayment);
            //總付額
            double total = MonthlyPayment * LoanTerm;
            total = Math.Round(total);
            MessageBox.Show("總付額" + total + "元");
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Frm_Hwloanreport report =  new Frm_Hwloanreport();
            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text) * 12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = double.Parse(txtInsterestRate.Text) / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
          
            double MonthlyPayment = (TheAmount - DonwPayment) * MonthlyInstersetRate * AmortizationRate;
            MonthlyPayment = Math.Round(MonthlyPayment);
            //總付額
            double total = MonthlyPayment * LoanTerm;
            total = Math.Round(total);
            report.labTheAmount2.Text = TheAmount.ToString();
            report.labLoanTerm2.Text = LoanTerm.ToString();
            report.labInstersetRate2.Text = InstersetRate.ToString();
            report.labMonthlyPayment2.Text = MonthlyPayment.ToString();
            report.labTotal2.Text = total.ToString();
            report.Show();
        }
    }
}
