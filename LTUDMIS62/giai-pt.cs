using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class GPTB2 : Form
    {
        public GPTB2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,c,d,x,x1,x2;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            d = b * b - 4 * a * c;
            if(d<0)
            {
                textKQ.Text = "Phương trình vô nghiệm!";
            }
            else if (d==0)
            {
                x = -b/(2*a);
                textKQ.Text = "Phương trình có nghiệm kép x =" + x;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 + a);
                x2 = (-b - Math.Sqrt(d)) / (2 + a);
                textKQ.Text = "x1=" + Convert.ToString(x1) + "\t  x2= " + Convert.ToString(x2);
            }
      
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbKQ_Click(object sender, EventArgs e)
        {

        }
    }
}
