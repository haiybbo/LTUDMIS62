using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class TACHTEN : Form
    {
        public TACHTEN()
        {
            InitializeComponent();
        }
        string ht, kq;
        int vt1, vt2;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ht = txtfname.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            kq = ht.Substring(0, vt1);
            txtketqua.Text = kq;
        }

        private void TACHTEN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ht = txtfname.Text.Trim();
            vt1 = ht.IndexOf(" ");
            vt2 = ht.Length;
            kq = ht.Substring(vt1, vt2 - vt1);
            txtketqua.Text = kq;
        }
        private void btnten_Click(object sender, EventArgs e)
        {
            ht = txtfname.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            vt2 = ht.Length;
            kq = ht.Substring(vt1, vt2-vt1);
            txtketqua.Text = kq;
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   }
}
