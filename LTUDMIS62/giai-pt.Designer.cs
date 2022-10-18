namespace LTUDMIS62
{
    partial class GPTB2
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
            this.lbl_gptb2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lb_c = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lb_b = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lb_a = new System.Windows.Forms.Label();
            this.btnsolve = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.textKQ = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_gptb2
            // 
            this.lbl_gptb2.AutoSize = true;
            this.lbl_gptb2.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_gptb2.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_gptb2.Location = new System.Drawing.Point(538, 23);
            this.lbl_gptb2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gptb2.Name = "lbl_gptb2";
            this.lbl_gptb2.Size = new System.Drawing.Size(469, 49);
            this.lbl_gptb2.TabIndex = 0;
            this.lbl_gptb2.Text = "Giải phương trình bậc 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.lb_c);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.lb_b);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.lb_a);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(32, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(658, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tham số a, b,c trong phương trình y = a*x^2 +b*x +c";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(113, 154);
            this.txtC.Margin = new System.Windows.Forms.Padding(6);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(196, 35);
            this.txtC.TabIndex = 5;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(61, 154);
            this.lb_c.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(45, 29);
            this.lb_c.TabIndex = 4;
            this.lb_c.Text = "c =";
            this.lb_c.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(113, 104);
            this.txtB.Margin = new System.Windows.Forms.Padding(6);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(196, 35);
            this.txtB.TabIndex = 5;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(61, 104);
            this.lb_b.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(47, 29);
            this.lb_b.TabIndex = 4;
            this.lb_b.Text = "b =";
            this.lb_b.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(113, 54);
            this.txtA.Margin = new System.Windows.Forms.Padding(6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(196, 35);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lb_a
            // 
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(61, 54);
            this.lb_a.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(46, 29);
            this.lb_a.TabIndex = 2;
            this.lb_a.Text = "a =";
            this.lb_a.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnsolve
            // 
            this.btnsolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsolve.Location = new System.Drawing.Point(726, 182);
            this.btnsolve.Margin = new System.Windows.Forms.Padding(6);
            this.btnsolve.Name = "btnsolve";
            this.btnsolve.Size = new System.Drawing.Size(252, 79);
            this.btnsolve.TabIndex = 2;
            this.btnsolve.Text = "SOLVE";
            this.btnsolve.UseVisualStyleBackColor = true;
            this.btnsolve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(1426, 798);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(6);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(150, 44);
            this.btnEXIT.TabIndex = 3;
            this.btnEXIT.Text = "Đóng";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // textKQ
            // 
            this.textKQ.Location = new System.Drawing.Point(271, 456);
            this.textKQ.Name = "textKQ";
            this.textKQ.Size = new System.Drawing.Size(990, 31);
            this.textKQ.TabIndex = 5;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKQ.ForeColor = System.Drawing.Color.Coral;
            this.lbKQ.Location = new System.Drawing.Point(91, 444);
            this.lbKQ.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(154, 42);
            this.lbKQ.TabIndex = 4;
            this.lbKQ.Text = "Kết quả";
            this.lbKQ.Click += new System.EventHandler(this.lbKQ_Click);
            // 
            // GPTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.textKQ);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnsolve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_gptb2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GPTB2";
            this.Text = "Giải phương trình bậc 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gptb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.Button btnsolve;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox textKQ;
        private System.Windows.Forms.Label lbKQ;
    }
}

