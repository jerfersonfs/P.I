using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Interfaces
{
    public partial class frmSplash: Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            prb_TelaSplash.Increment(1);
            if(prb_TelaSplash.Value > 100)
            {
                timerSplash.Stop();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double contador = 0.99; contador < 1; contador++)
            {
                this.Opacity = contador;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
        }

        private void prb_TelaSplash_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
