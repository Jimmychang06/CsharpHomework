namespace Frn_homeworkApp
{
    partial class Frm_Hwloan
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
            this.btncalculatemonth = new System.Windows.Forms.Button();
            this.txtTheAmount = new System.Windows.Forms.TextBox();
            this.txtInsterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtDonwPayment = new System.Windows.Forms.TextBox();
            this.btnreport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncalculatemonth
            // 
            this.btncalculatemonth.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncalculatemonth.Location = new System.Drawing.Point(168, 374);
            this.btncalculatemonth.Name = "btncalculatemonth";
            this.btncalculatemonth.Size = new System.Drawing.Size(102, 41);
            this.btncalculatemonth.TabIndex = 0;
            this.btncalculatemonth.Text = "月付額";
            this.btncalculatemonth.UseVisualStyleBackColor = true;
            this.btncalculatemonth.Click += new System.EventHandler(this.btncalculatemonth_Click);
            // 
            // txtTheAmount
            // 
            this.txtTheAmount.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTheAmount.Location = new System.Drawing.Point(376, 57);
            this.txtTheAmount.Name = "txtTheAmount";
            this.txtTheAmount.Size = new System.Drawing.Size(174, 33);
            this.txtTheAmount.TabIndex = 1;
            // 
            // txtInsterestRate
            // 
            this.txtInsterestRate.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInsterestRate.Location = new System.Drawing.Point(376, 114);
            this.txtInsterestRate.Name = "txtInsterestRate";
            this.txtInsterestRate.Size = new System.Drawing.Size(174, 33);
            this.txtInsterestRate.TabIndex = 2;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanTerm.Location = new System.Drawing.Point(376, 174);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(174, 33);
            this.txtLoanTerm.TabIndex = 3;
            // 
            // txtDonwPayment
            // 
            this.txtDonwPayment.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDonwPayment.Location = new System.Drawing.Point(376, 232);
            this.txtDonwPayment.Name = "txtDonwPayment";
            this.txtDonwPayment.Size = new System.Drawing.Size(174, 33);
            this.txtDonwPayment.TabIndex = 4;
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreport.Location = new System.Drawing.Point(473, 374);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(102, 41);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(126, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(126, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "年利率(%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(126, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "貸款期數(年):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(126, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "頭期款";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "本息平均攤還試算";
            // 
            // btntotal
            // 
            this.btntotal.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntotal.Location = new System.Drawing.Point(286, 374);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(102, 41);
            this.btntotal.TabIndex = 14;
            this.btntotal.Text = "總付款";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // Frm_Hwloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 465);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.txtDonwPayment);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtInsterestRate);
            this.Controls.Add(this.txtTheAmount);
            this.Controls.Add(this.btncalculatemonth);
            this.Name = "Frm_Hwloan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculatemonth;
        private System.Windows.Forms.TextBox txtTheAmount;
        private System.Windows.Forms.TextBox txtInsterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtDonwPayment;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntotal;
    }
}