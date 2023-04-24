namespace Frn_homeworkApp
{
    partial class Frm_homework
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_homework));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btnhello = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnClac = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnpictureview = new System.Windows.Forms.Button();
            this.btnOXgame = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btndraw = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 614);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnMethod);
            this.splitContainer2.Panel1.Controls.Add(this.btndraw);
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnOXgame);
            this.splitContainer2.Panel1.Controls.Add(this.btnpictureview);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreen);
            this.splitContainer2.Panel1.Controls.Add(this.btnClac);
            this.splitContainer2.Panel1.Controls.Add(this.btnPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudents);
            this.splitContainer2.Panel1.Controls.Add(this.btnhello);
            this.splitContainer2.Panel1.Controls.Add(this.btnloan);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotePad);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(1101, 518);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnNotePad
            // 
            this.btnNotePad.Location = new System.Drawing.Point(12, 241);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(229, 28);
            this.btnNotePad.TabIndex = 0;
            this.btnNotePad.Text = "Note pad";
            this.btnNotePad.UseVisualStyleBackColor = true;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnloan
            // 
            this.btnloan.Location = new System.Drawing.Point(12, 71);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(229, 28);
            this.btnloan.TabIndex = 1;
            this.btnloan.Text = "Loan";
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(12, 3);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(229, 28);
            this.btnhello.TabIndex = 2;
            this.btnhello.Text = "hello form";
            this.btnhello.UseVisualStyleBackColor = true;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(12, 105);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(229, 28);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "Student Struct";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(12, 37);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(229, 28);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "Pos";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnClac
            // 
            this.btnClac.Location = new System.Drawing.Point(12, 139);
            this.btnClac.Name = "btnClac";
            this.btnClac.Size = new System.Drawing.Size(229, 28);
            this.btnClac.TabIndex = 5;
            this.btnClac.Text = "Clac";
            this.btnClac.UseVisualStyleBackColor = true;
            this.btnClac.Click += new System.EventHandler(this.btnClac_Click);
            // 
            // btnScreen
            // 
            this.btnScreen.Location = new System.Drawing.Point(12, 207);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(229, 28);
            this.btnScreen.TabIndex = 6;
            this.btnScreen.Text = "Screen Saver";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // btnpictureview
            // 
            this.btnpictureview.Location = new System.Drawing.Point(12, 173);
            this.btnpictureview.Name = "btnpictureview";
            this.btnpictureview.Size = new System.Drawing.Size(229, 28);
            this.btnpictureview.TabIndex = 7;
            this.btnpictureview.Text = "Picture view";
            this.btnpictureview.UseVisualStyleBackColor = true;
            this.btnpictureview.Click += new System.EventHandler(this.btnpictureview_Click);
            // 
            // btnOXgame
            // 
            this.btnOXgame.Location = new System.Drawing.Point(12, 275);
            this.btnOXgame.Name = "btnOXgame";
            this.btnOXgame.Size = new System.Drawing.Size(229, 28);
            this.btnOXgame.TabIndex = 8;
            this.btnOXgame.Text = "OX Game";
            this.btnOXgame.UseVisualStyleBackColor = true;
            this.btnOXgame.Click += new System.EventHandler(this.btnOXgame_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(12, 343);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(229, 28);
            this.btnAlarm.TabIndex = 9;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(12, 309);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(229, 28);
            this.btndraw.TabIndex = 10;
            this.btndraw.Text = "小畫家";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(12, 377);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(229, 28);
            this.btnMethod.TabIndex = 11;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(12, 411);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(229, 28);
            this.btnGuess.TabIndex = 12;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Frm_homework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1101, 614);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_homework";
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnNotePad;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnOXgame;
        private System.Windows.Forms.Button btnpictureview;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnClac;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnMethod;
    }
}

