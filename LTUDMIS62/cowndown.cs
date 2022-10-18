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

    public partial class cowndown : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        public cowndown()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void cowndown_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void cowndown_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
        }
        private void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
 
               if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));

            
        }
    }
}
