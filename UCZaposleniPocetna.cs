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
    public partial class UCZaposleniPocetna : UserControl
    {
        ZaposleniForm form;

        public UCZaposleniPocetna(ZaposleniForm form)
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

        private void dodajZaposlenogBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCNoviZaposleni(form));
        }

        private void spisakZaposlenihBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCSpisakZaposlenih(form));
        }
    }
}
