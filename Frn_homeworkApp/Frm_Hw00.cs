using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frn_homeworkApp
{
    public partial class Frm_homework : Form
    {
        public Frm_homework()
        {
            InitializeComponent();
        }


        private void btnNotePad_Click(object sender, EventArgs e)
        {
          Frm_HwNotepad Note = new Frm_HwNotepad();
            
            Note.Show();
        }

        private void btnhello_Click(object sender, EventArgs e)
        {
            Frm_Hwhello hello = new Frm_Hwhello ();            
            hello.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(hello);
            hello.Show();
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            Frm_Hwloan loan = new Frm_Hwloan();
            loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(loan);
            
            loan.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Frm_Hwpos Pos = new Frm_Hwpos();
            Pos.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(Pos);
            Pos.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Frm_HwStudentStruct students = new Frm_HwStudentStruct();
            students.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(students);
            students.Show();
        }

        private void btnClac_Click(object sender, EventArgs e)
        {
            Frm_HwClac clac = new Frm_HwClac();
            clac.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(clac);
            clac.Show();
        }

        private void btnpictureview_Click(object sender, EventArgs e)
        {
            Frm_HwPicture_View pic = new Frm_HwPicture_View();
            pic.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pic);
            pic.Show();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            Frm_HwScreenSaver screen= new Frm_HwScreenSaver();
            
            screen.Show();
        }

        private void btnOXgame_Click(object sender, EventArgs e)
        {
            Frm_HwOXgame game = new Frm_HwOXgame();
            game.TopLevel = false; 
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(game);
            game.Show();
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            Frm_Hw小畫家 draw = new Frm_Hw小畫家();
            draw.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(draw);
            draw.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Frm_HwAlarm alarm = new Frm_HwAlarm();
            alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();

            splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Frm_HwMethod method = new Frm_HwMethod();
            method.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();

            splitContainer2.Panel2.Controls.Add(method);
            method.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_HwGuess guess = new Frm_HwGuess();
            guess.TopLevel = false; 
            splitContainer2.Panel2.Controls.Clear();

            splitContainer2.Panel2.Controls.Add(guess);
            guess.Show();
        }
    }
    
}
