using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Frn_homeworkApp
{
    public partial class Frm_HwMethod : Form
    {
        public Frm_HwMethod()
        {
            InitializeComponent();
        }

        private void btnOddorEven_Click(object sender, EventArgs e)
        {
            int oddoreven = int.Parse(txtOddorEven.Text);
            if (!(int.TryParse(txtOddorEven.Text, out oddoreven)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }           
            if (oddoreven % 2 == 0)
            {
                label1.Text = ($"{oddoreven} 是偶數");
            }
            else
            {
                label1.Text=($"{oddoreven} 是奇數");
            }
        }

        private void btncleanlab1_Click(object sender, EventArgs e)
        {
            label1.Text = "結果";
        }

        private void btnArrayminmax_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr.Max();
            int min = arr.Min();
            
            label1.Text ="{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }"+
            "\nMax: " + max.ToString() + "  Min: " + min.ToString();
            
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };            
            int sum = arr.Sum();
           
            label1.Text = "{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }" + "\nSum: " + sum.ToString();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr.Max();
          
            label1.Text = "{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }" +
            "\nMax: " + max.ToString();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr.Min();

            label1.Text = "{ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 }" +
            " \nMin: " + min.ToString();
        }
        
        private void btnoddeven_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int evenCount = arr.Count(x => x % 2 == 0);
            int oddCount = arr.Count(x => x % 2 == 1);

            label1.Text = "偶數: " + evenCount.ToString() + "\n奇數: " + oddCount.ToString();
        }
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }

        private void btnswap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            string message1 = ($"a: {a} , b: {b}");
            Swap(ref a, ref b);
            string message2 = ($"a: {a} , b: {b}");

            label1.Text = message1 + "\n" + message2;
        }

        private void btn1010out1_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            // 初始化矩陣
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label1.Text += matrix[i, j].ToString() + " ";
                }
                label1.Text += Environment.NewLine;
            }
        }

        private void btn1010out0_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            // 初始化矩陣
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label1.Text += matrix[i, j].ToString() + " ";
                }
                label1.Text += Environment.NewLine;
            }           
        }

        private void btn10101_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            //// 初始化矩陣
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = (i + j) % 2 == 0 ? 1 : 0;
                }
            }
            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label1.Text += matrix[i, j].ToString() + " ";
                }
                label1.Text += Environment.NewLine;
            }
        }
        private void btnLongname_Click(object sender, EventArgs e)
        {
            string[] str = { "mother張", "emma", "蕭迪克", "J40", "Candy", "Cindy", "Coconat", "motherfacker" };
            string Longname = str.OrderByDescending(s=>s.Length).First();
            label1.Text = $" mother張, emma, 蕭迪克, J40, Candy, Cindy, Coconat, motherfacker \n陣列中名字最長的是:{Longname}" ;
        }

        private void btnCorc_Click(object sender, EventArgs e)
        {
            string[] str = { "mother張", "emma", "蕭迪克", "J40", "Candy", "Cindy", "Coconat", "motherfacker" };
            int Cc = str.Count(s => s.Contains("c") || s.Contains("C"));
            label1.Text = $" mother張, emma, 蕭迪克, J40, Candy, Cindy, Coconat, motherfacker \n陣列中有C與c有{Cc}個";
        }
        private void btn99_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[9,9];
            string result = "";
            for ( int i = 1; i < 9; i++)
            
                {
                    for (int x = 2; x <= 9; x++)
                    {
                        result += x + " x " + i + " = " + x * i + " || ";
                    }
                    result += "\n";
                }
                label1.Text = result;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[6];
            string result = "樂透號碼 : \n";
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 49);
                result += arr[i] + "   ";
            }
            label1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 100;
            int[] arr = new int[8];
            string result = "結果 : \n";
            int i = 1;
            while (number > 0)
            {
                arr[i] = number % 2;
                number /= 2;
                i++;
            }
            for (int x = arr.Length - 1; x >= 1; x--)
            {
                result += arr[x];
            }
          label1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtRow.Text, out int Length)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            string[] arr = new string[Length];

            for (int i = 0; i < Length; i++)
            {
                arr[i] = new string('*', i + 1);
            }
            label1.Text = string.Join(Environment.NewLine, arr);
        }
    }
}
