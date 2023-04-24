namespace Frn_homeworkApp
{
    partial class Frm_HwGuess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAns = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(113, 255);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(169, 65);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAns
            // 
            this.btnShowAns.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAns.Location = new System.Drawing.Point(352, 255);
            this.btnShowAns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(200, 65);
            this.btnShowAns.TabIndex = 1;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // labShow
            // 
            this.labShow.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(57, 105);
            this.labShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(516, 105);
            this.labShow.TabIndex = 2;
            this.labShow.Text = "Please Select A Number Between 1 To 100";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(198, 351);
            this.txtAns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(309, 25);
            this.txtAns.TabIndex = 3;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(528, 342);
            this.btngo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(92, 34);
            this.btngo.TabIndex = 4;
            this.btngo.Text = "go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Frm_HwGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.btnGuess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_HwGuess";
            this.Text = "Frm_HwGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAns;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btngo;
    }
}