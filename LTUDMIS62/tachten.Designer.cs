namespace LTUDMIS62
{
    partial class TACHTEN
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
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lbhoten = new System.Windows.Forms.Label();
            this.btnhodem = new System.Windows.Forms.Button();
            this.lbKQ1 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtfname.Location = new System.Drawing.Point(38, 170);
            this.txtfname.Multiline = true;
            this.txtfname.Name = "txtfname";
            this.txtfname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfname.Size = new System.Drawing.Size(1078, 107);
            this.txtfname.TabIndex = 0;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // lbhoten
            // 
            this.lbhoten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbhoten.AutoSize = true;
            this.lbhoten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbhoten.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbhoten.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbhoten.Location = new System.Drawing.Point(452, 86);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(258, 42);
            this.lbhoten.TabIndex = 2;
            this.lbhoten.Text = "Nhập họ và tên";
            this.lbhoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbhoten.UseMnemonic = false;
            this.lbhoten.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnhodem
            // 
            this.btnhodem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhodem.ForeColor = System.Drawing.Color.Maroon;
            this.btnhodem.Location = new System.Drawing.Point(54, 328);
            this.btnhodem.Name = "btnhodem";
            this.btnhodem.Size = new System.Drawing.Size(236, 75);
            this.btnhodem.TabIndex = 5;
            this.btnhodem.Text = "Tách đệm";
            this.btnhodem.UseVisualStyleBackColor = true;
            this.btnhodem.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbKQ1
            // 
            this.lbKQ1.AutoSize = true;
            this.lbKQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKQ1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbKQ1.Location = new System.Drawing.Point(69, 550);
            this.lbKQ1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKQ1.Name = "lbKQ1";
            this.lbKQ1.Size = new System.Drawing.Size(154, 42);
            this.lbKQ1.TabIndex = 6;
            this.lbKQ1.Text = "Kết quả";
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtketqua.Location = new System.Drawing.Point(241, 524);
            this.txtketqua.Multiline = true;
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(875, 107);
            this.txtketqua.TabIndex = 0;
            this.txtketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtketqua.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(952, 737);
            this.btnexit.Margin = new System.Windows.Forms.Padding(6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 44);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Đóng";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(433, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tách đệm và tên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnten
            // 
            this.btnten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnten.ForeColor = System.Drawing.Color.Maroon;
            this.btnten.Location = new System.Drawing.Point(833, 331);
            this.btnten.Name = "btnten";
            this.btnten.Size = new System.Drawing.Size(236, 75);
            this.btnten.TabIndex = 9;
            this.btnten.Text = "Tách tên";
            this.btnten.UseVisualStyleBackColor = true;
            this.btnten.Click += new System.EventHandler(this.btnten_Click);
            // 
            // TACHTEN
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1148, 802);
            this.Controls.Add(this.btnten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbKQ1);
            this.Controls.Add(this.btnhodem);
            this.Controls.Add(this.lbhoten);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtfname);
            this.Name = "TACHTEN";
            this.Text = "Tách họ, đệm, tên";
            this.Load += new System.EventHandler(this.TACHTEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Button btnhodem;
        private System.Windows.Forms.Label lbKQ1;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnten;
    }
}