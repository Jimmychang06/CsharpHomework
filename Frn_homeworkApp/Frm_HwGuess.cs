using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frn_homeworkApp
{
    public partial class Frm_HwGuess : Form
    {
        public Frm_HwGuess()
        {
            InitializeComponent();
        }

        int min = 0, max = 100; // 設定範圍最小值和最大值
        int randomNumber;                 

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( randomNumber.ToString("Answer :" + randomNumber));
            MessageBox.Show($"Answer: {randomNumber}");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {          
            Random ra = new Random();
            randomNumber = ra.Next(0, 100); // 生成介於 0 和 99 之間的隨機整數
            labShow.Text = $"請猜一個介於 {min} 和 {max} 之間的整數";

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            int guess;
            // MessageBox.Show("請輸入數值");

            do
            {
                guess = int.Parse(txtAns.Text);
                if (guess > randomNumber)
                {
                    MessageBox.Show("猜的數字太大了");

                    max = guess; // 更新最大值為目前猜的數字
                    return;
                    labShow.Text = $"請猜一個介於 {min} 和 {max} 之間的整數";
                    
                }
                else if (guess < randomNumber)
                {
                    MessageBox.Show("猜的數字太小了");

                    min = guess; // 更新最小值為目前猜的數字
                    labShow.Text = $"請猜一個介於 {min} 和 {max} 之間的整數";
                    return;
                }
                else
                {
                    MessageBox.Show("恭喜，猜中了");
                    labShow.Text = "你猜中了！";
                }
            } while (guess != randomNumber);
        }
    }
}
