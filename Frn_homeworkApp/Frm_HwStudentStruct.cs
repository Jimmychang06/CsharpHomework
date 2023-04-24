using Frn_homeworkApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Frn_homeworkApp
{
    public partial class Frm_HwStudentStruct : Form
    {
        public Frm_HwStudentStruct()
        {
            InitializeComponent();
        }

        Dictionary<string, List<int>> scores = new Dictionary<string, List<int>>();  // 用字典來存儲每個人的成績

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int score1 = int.Parse(txtScore1.Text);
            int score2 = int.Parse(txtScore2.Text);
            int score3 = int.Parse(txtScore3.Text);

            if (scores.ContainsKey(name))
            {
                scores[name][0] = score1;
                scores[name][1] = score2;
                scores[name][2] = score3;
            }
            else
            {
                scores[name] = new List<int> { score1, score2, score3 };
            }

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (scores.ContainsKey(name))
            {
                int score1 = scores[name][0];
                int score2 = scores[name][1];
                int score3 = scores[name][2];

                txtScores.Text = string.Format("{0} 的成績：\r\n國文: {1}\r\n數學: {2}\r\n英文: {3}", name, score1, score2, score3);
            }
            else
            {
                MessageBox.Show("未找到該姓名的成績");
            }
        }

        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (scores.ContainsKey(name))
            {
                int max = int.MinValue;
                int min = int.MaxValue;

                foreach (int score in scores[name])
                {
                    if (score > max)
                    {
                        max = score;
                    }

                    if (score < min)
                    {
                        min = score;
                    }
                }
                txtHighandLow.Text = string.Format("{0} 的最高分為 {1}，最低分為 {2}", name, max, min);
                //MessageBox.Show(string.Format("{0} 的最高分為 {1}，最低分為 {2}", name, max, min));
            }
            else
            {
                MessageBox.Show("未找到該姓名的成績");
            }
        }








    }
}
