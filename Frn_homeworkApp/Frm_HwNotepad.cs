using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frn_homeworkApp
{
    public partial class Frm_HwNotepad : Form
    {
        public Frm_HwNotepad()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,textBox1.Text, Encoding.Default);
            }

        }
        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }
        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }
private void 顏色OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是記事本第一版", "關於");
        }

        private void tOLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.SelectedText.ToLower();
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.SelectedText.ToUpper();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = true;
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是記事本第一版", "關於");
        }
    }
}
