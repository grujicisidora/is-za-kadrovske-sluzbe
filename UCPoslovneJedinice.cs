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
    public partial class UCPoslovneJedinice : UserControl
    {
        OstaliPodaciForm form;
        public UCPoslovneJedinice(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();

            List<PoslovnaJedinica> poslJedinice = RadSaBazomPoslovnaJedinica.SpisakPoslJed();
            List<Grad> gradovi = RadSaBazomGrad.SpisakGradova();

            if (gradovi.Count > 0)
            {
                foreach (Grad g in gradovi)
                {
                    gradComboBox.Items.Add(g.naziv);
                }
            }

            if (poslJedinice.Count > 0)
            {
                foreach (PoslovnaJedinica p in poslJedinice)
                {
                    obrisiComboBox.Items.Add(p.adresa);
                }
            }
        }

        private void ucitajSve()
        {
            List<PoslovnaJedinica> poslJedinice = RadSaBazomPoslovnaJedinica.SpisakPoslJed();

            if (poslJedLv.Visible == true)
                poslJedLv.Clear();

            if (poslJedinice.Count > 0)
            {
                poslJedLv.Show();
                foreach (PoslovnaJedinica p in poslJedinice)
                {
                    ListViewItem item = new ListViewItem(p.adresa.ToString() + ", " + RadSaBazomGrad.pretraziPoPtt(p.ptt));
                    item.Tag = p;
                    poslJedLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih poslovnih jedinica.");
            }
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCOstaliPodaciPocetna(form));
        }

        private void osveziBtn_Click(object sender, EventArgs e)
        {
            ucitajSve();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            String adresa = adresaTxt.Text.ToString();
            String nazivGrada = gradComboBox.Text.ToString();
            Grad grad = RadSaBazomGrad.pretrazi(nazivGrada);

            PoslovnaJedinica poslJed;
            if (adresaTxt.Text.Length > 0 && gradComboBox.Text.Length > 0)
            {
                poslJed = new PoslovnaJedinica(adresa, grad.ptt);
                if (RadSaBazomPoslovnaJedinica.daLiPostoji(poslJed))
                {
                    MessageBox.Show("Ova poslovna jedinica već postoji u bazi.");
                    adresaTxt.Clear();
                    gradComboBox.ResetText();
                }
                else
                {
                    if (RadSaBazomPoslovnaJedinica.unesi(poslJed))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        adresaTxt.Clear();
                        ucitajSve();
                        obrisiComboBox.Items.Add(poslJed.adresa);
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti sve podatke o poslovnoj jedinici.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            poslJedLv.Clear();
            String naziv;

            if (pretraziTxt.Text.Length > 0)
                naziv = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv grada.");
                return;
            }
            if (RadSaBazomObrazovnaUstanova.nadji(naziv))
            {
                List<PoslovnaJedinica> poslJedinice = RadSaBazomPoslovnaJedinica.SpisakPoslJed();
                foreach (PoslovnaJedinica p in poslJedinice)
                    if (p.ptt == RadSaBazomGrad.pretrazi(naziv).ptt)
                    {
                        ListViewItem item = new ListViewItem(p.adresa.ToString() + ", " + RadSaBazomGrad.pretraziPoPtt(p.ptt));
                        item.Tag = p;
                        poslJedLv.Items.Add(item);
                    }
                pretraziTxt.Clear();
            }
            else
                MessageBox.Show("Poslovne jedinice iz ovog grada ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String adresa;

            if (obrisiComboBox.Text.Length > 0)
                adresa = obrisiComboBox.Text.ToString();
            else
            {
                MessageBox.Show("Unesite adresu poslovne jedinice.");
                return;
            }
            if (RadSaBazomPoslovnaJedinica.nadji(adresa))
            {
                PoslovnaJedinica poslJed = new PoslovnaJedinica(adresa);
                if (RadSaBazomPoslovnaJedinica.obrisi(poslJed))
                {
                    MessageBox.Show("Uspešno obrisana poslovna jedinica.");
                    ucitajSve();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja poslovne jedinice iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željena poslovna jedinica ne postoji u bazi.");
        }
    }
}
