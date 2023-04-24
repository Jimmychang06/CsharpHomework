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
    public partial class Frm_HwOXgame : Form
    {
        public Frm_HwOXgame()
        {
            InitializeComponent();
        }

        int currentPlayer = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button1.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button1.Text = "X";
                currentPlayer = 1;
            }
            button1.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button2.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button2.Text = "X";
                currentPlayer = 1;
            }
            button2.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button3.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button3.Text = "X";
                currentPlayer = 1;
            }
            button3.Enabled = false;

            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button4.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button4.Text = "X";
                currentPlayer = 1;
            }
            button4.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button5.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button5.Text = "X";
                currentPlayer = 1;
            }
            button5.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button6.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button6.Text = "X";
                currentPlayer = 1;
            }
            button6.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button7.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button7.Text = "X";
                currentPlayer = 1;
            }
            button7.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button8.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button8.Text = "X";
                currentPlayer = 1;
            }
            button8.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                button9.Text = "O";
                currentPlayer = 2;
            }
            else
            {
                button9.Text = "X";
                currentPlayer = 1;
            }
            button9.Enabled = false;
            if (CheckWin())
            {
                MessageBox.Show("遊戲結束，" + (currentPlayer == 1 ? "X" : "O") + "獲勝！");
                // 在此處添加任何您需要的結束遊戲的代碼
                ResetGame();
            }

        }
        public void  ResetGame()
        {
            button1.Text = ""; button1.Enabled = true;
            button2.Text = ""; button2.Enabled = true;
            button3.Text = ""; button3.Enabled = true;
            button4.Text = ""; button4.Enabled = true;
            button5.Text = ""; button5.Enabled = true;
            button6.Text = ""; button6.Enabled = true;
            button7.Text = ""; button7.Enabled = true;
            button8.Text = ""; button8.Enabled = true;
            button9.Text = ""; button9.Enabled = true;
        }
        private void EndGame(string message)
        {
            MessageBox.Show(message, "遊戲結束");
           ResetGame();
        }
        // 檢查符號是否連成一線
        private bool CheckWin()
        {
            // 檢查行
           
                if (button1.Text == button2.Text && button2.Text == button3.Text && !string.IsNullOrEmpty(button1.Text))
                {
                    return true;
                }
                if (button4.Text == button5.Text && button5.Text == button6.Text && !string.IsNullOrEmpty(button4.Text))
                {
                    return true;
                }
                if (button7.Text == button8.Text && button8.Text == button9.Text && !string.IsNullOrEmpty(button7.Text))
                {
                    return true;
                }
            

            // 檢查列
          
                if (button1.Text == button4.Text && button4.Text == button7.Text && !string.IsNullOrEmpty(button1.Text))
                {
                    return true;
                }
                if (button2.Text == button5.Text && button5.Text == button8.Text && !string.IsNullOrEmpty(button2.Text))
                {
                    return true;
                }
                if (button3.Text == button6.Text && button6.Text == button9.Text && !string.IsNullOrEmpty(button3.Text))
                {
                    return true;
                }
            

            // 檢查對角線
            if (button1.Text == button5.Text && button5.Text == button9.Text && !string.IsNullOrEmpty(button1.Text))
            {
                return true;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && !string.IsNullOrEmpty(button3.Text))
            {
                return true;
            }
            // 檢查是否還有空的按鈕
            foreach (Button button in Controls.OfType<Button>())
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    return false;                    
                }
            }
            // 如果所有按鈕都已經填滿，而且沒有人贏，則代表平手
            EndGame("平手！");
            return false;
         }

            private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
       
            
        
        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
