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
    public partial class UCZanimanja : UserControl
    {
        OstaliPodaciForm form;

        public UCZanimanja(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();

            List<ObrazovnaUstanova> obrUstanove = RadSaBazomObrazovnaUstanova.SpisakObrUst();

            if (obrUstanove.Count > 0)
            {
                foreach (ObrazovnaUstanova o in obrUstanove)
                {
                    obrUstanovaComboBox.Items.Add(o.nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(o.ptt));
                }
            }
        }

        private void ucitajSve()
        {
            List<Zanimanje> zanimanja = RadSaBazomZanimanje.SpisakZanimanja();

            if (zanimanjaLv.Visible == true)
                zanimanjaLv.Clear();

            if (zanimanja.Count > 0)
            {
                zanimanjaLv.Show();
                foreach (Zanimanje z in zanimanja)
                {
                    ListViewItem item = new ListViewItem(z.naziv.ToString() + ", " + RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).nazivOU + ", " + z.smer.ToString());
                    item.Tag = z;
                    zanimanjaLv.Items.Add(item);
                    obrisiComboBox.Items.Add(z.naziv + ", " + RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).ptt) + ", " + z.smer.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nema unetih zanimanja.");
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
            Zanimanje zanimanje;

            if (nazivZanimanjaTxt.Text.Length > 0 && obrUstanovaComboBox.Text.Length > 0 && smerTxt.Text.Length > 0)
            {
                String naziv = nazivZanimanjaTxt.Text.ToString();
                String unosObrUst = obrUstanovaComboBox.Text.ToString();
                String[] razdvojeno = unosObrUst.Split(", ");
                String nazivObrUst = razdvojeno[0];
                Grad grad = RadSaBazomGrad.pretrazi(razdvojeno[1]);
                int ptt = grad.ptt;
                int obrUstanova = RadSaBazomObrazovnaUstanova.pretraziPoNazivIGrad(nazivObrUst, ptt);
                String smer = smerTxt.Text.ToString();
                zanimanje = new Zanimanje(naziv, obrUstanova, smer);
                if (RadSaBazomZanimanje.daLiPostoji(zanimanje))
                {
                    MessageBox.Show("Ovo zanimanje već postoji u bazi.");
                    nazivZanimanjaTxt.Clear();
                    obrUstanovaComboBox.ResetText();
                    smerTxt.Clear();
                }
                else
                {
                    if (RadSaBazomZanimanje.unesi(zanimanje))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        nazivZanimanjaTxt.Clear();
                        smerTxt.Clear();
                        obrUstanovaComboBox.ResetText();
                        ucitajSve();
                        obrisiComboBox.Items.Add(zanimanje.naziv + ", " + RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.obrUstanova).nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.obrUstanova).ptt) + ", " + zanimanje.smer.ToString());
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti sve podatke o zanimanju.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            zanimanjaLv.Clear();
            String naziv;

            if (pretraziTxt.Text.Length > 0)
                naziv = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv zanimanja.");
                return;
            }
            if (RadSaBazomZanimanje.nadji(naziv))
            {
                List<Zanimanje> zanimanja = RadSaBazomZanimanje.SpisakZanimanja();
                foreach (Zanimanje z in zanimanja)
                    if (z.naziv == naziv)
                    {
                        ListViewItem item = new ListViewItem(z.naziv.ToString() + ", " + RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).nazivOU + ", " + z.smer.ToString());
                        item.Tag = z;
                        zanimanjaLv.Items.Add(item);
                    }
                pretraziTxt.Clear();
            }
            else
                MessageBox.Show("Ovo zanimanje ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String ulaz;
            String[] razdvojeno;
            String nazivZanimanja;
            String nazivObrUst;
            String smer;
            String grad;
            int idObrUst;
            int ptt;

            if (obrisiComboBox.Text.Length > 0)
            {
                ulaz = obrisiComboBox.Text.ToString();
                razdvojeno = ulaz.Split(", ");
                nazivZanimanja = razdvojeno[0];
                nazivObrUst = razdvojeno[1];
                grad = razdvojeno[2];
                smer = razdvojeno[3];
                ptt = RadSaBazomGrad.pretrazi(grad).ptt;
                idObrUst = RadSaBazomObrazovnaUstanova.pretraziPoNazivIGrad(nazivObrUst, ptt);
            }
            else
            {
                MessageBox.Show("Unesite zanimanje.");
                return;
            }
            if (RadSaBazomZanimanje.nadji(nazivZanimanja, idObrUst, smer))
            {
                Zanimanje zanimanje = new Zanimanje(nazivZanimanja, idObrUst, smer);
                if (RadSaBazomZanimanje.obrisi(zanimanje))
                {
                    MessageBox.Show("Uspešno obrisano zanimanje.");
                    ucitajSve();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja zanimanja iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeno zanimanje ne postoji u bazi.");
        }

        private void zanimanjaLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zanimanjaLv.SelectedItems.Count == 0)
                return;

            ListViewItem item = zanimanjaLv.SelectedItems[0];
            Zanimanje izabranoZanimanje = (Zanimanje)item.Tag;


            Form forma = new ZanimanjeForm(form, this, izabranoZanimanje);
            forma.ShowDialog();
        }
    }
}
