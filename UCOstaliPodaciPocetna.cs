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
    public partial class UCOstaliPodaciPocetna : UserControl
    {
        OstaliPodaciForm form;

        public UCOstaliPodaciPocetna(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void nazadNaPocetnuBtn_Click(object sender, EventArgs e)
        {
            PocetnaForm f = new PocetnaForm();
            form.Hide();
            f.ShowDialog();
            form.Close();
        }

        private void gradoviBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCGradovi(form));
        }

        private void bankeBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCBanke(form));
        }

        private void obrUstBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCObrazovneUstanove(form));
        }

        private void poslJedBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCPoslovneJedinice(form));
        }

        private void odeljenjaBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCOdeljenja(form));
        }

        private void radMestBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCRadnaMesta(form));
        }

        private void ugovoriBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCUgovori(form));
        }

        private void zanimanjaBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCZanimanja(form));
        }

        private void organizacijaBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCOrganizacija(form));
        }
    }
}
