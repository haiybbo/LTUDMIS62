using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TACHTEN f = new TACHTEN();
            f.Show();
        }

        private void giảiPtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPTB2 f = new GPTB2();
            f.Show();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator f = new calculator();
            f.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cowndown f = new cowndown();
            f.Show();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giảiPhươngTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPTB2 f = new GPTB2();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GPTB2 f = new GPTB2();
            f.ShowDialog();
        }

        private void stt3_Click(object sender, EventArgs e)
        {
            stt3.Text = "thời gian hệ thống: " + System.DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stt3.Text = "thời gian hệ thống: " + System.DateTime.Now.ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmdanhmuchanghoa f = new frmdanhmuchanghoa();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDataa_Click(object sender, EventArgs e)
        {
            frmdanhmuchanghoa f = new frmdanhmuchanghoa();
            f.Show();
        }
    }
    
}
