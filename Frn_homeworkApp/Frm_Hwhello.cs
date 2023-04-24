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
    public partial class Frm_Hwhello : Form
    {
        public Frm_Hwhello()
        {
            InitializeComponent();
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name=txtName.Text;
            string EName = txtEName.Text; 
            string Male = txtMale.Text; 
            string Star = txtStar.Text;
            MessageBox.Show("Hi,\n你好,"+Name+"\n英文名字:"+EName+
                "\n性別:"+Male+"\n星座:"+Star);
        }

        private void btnhello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EName = txtEName.Text;
            string Male = txtMale.Text;
            string Star = txtStar.Text;
            MessageBox.Show("Hello,\n你好," + Name + "\n英文名字:" + EName +
                "\n性別:" + Male + "\n星座:" + Star);
        }
    }
}
