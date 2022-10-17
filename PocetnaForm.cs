using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
        }

        private void izadjiBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radniciBtn_Click(object sender, EventArgs e)
        {
            Form f = new ZaposleniForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void meniBtn_Click(object sender, EventArgs e)
        {
            Form f = new OstaliPodaciForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
