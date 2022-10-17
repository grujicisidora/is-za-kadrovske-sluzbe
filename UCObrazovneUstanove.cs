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
    public partial class UCObrazovneUstanove : UserControl
    {
        OstaliPodaciForm form;

        public UCObrazovneUstanove(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
            List<ObrazovnaUstanova> obrUstanove = RadSaBazomObrazovnaUstanova.SpisakObrUst();
            List<Grad> gradovi = RadSaBazomGrad.SpisakGradova();

            if (gradovi.Count > 0)
            {
                foreach (Grad g in gradovi)
                {
                    gradComboBox.Items.Add(g.naziv);
                }
            }

            if (obrUstanove.Count > 0)
            {
                foreach (ObrazovnaUstanova o in obrUstanove)
                {
                    obrisiComboBox.Items.Add(o.nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(o.ptt));
                }
            }
        }

        private void ucitajSve()
        {
            List<ObrazovnaUstanova> obrUstanove = RadSaBazomObrazovnaUstanova.SpisakObrUst();
            
            if (obrUstLv.Visible == true)
                obrUstLv.Clear();

            if (obrUstanove.Count > 0)
            {
                obrUstLv.Show();
                foreach (ObrazovnaUstanova o in obrUstanove)
                {
                    ListViewItem item = new ListViewItem(o.nazivOU.ToString() + ", " + RadSaBazomGrad.pretraziPoPtt(o.ptt));
                    item.Tag = o;
                    obrUstLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih obrazovnih ustanova.");
            }  
        }

        private void osveziBtn_Click(object sender, EventArgs e)
        {
            ucitajSve();
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCOstaliPodaciPocetna(form));
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            String naziv = nazivObrUstTxt.Text.ToString();
            String stepen = stepenObrComboBox.Text.ToString();
            String nazivGrada = gradComboBox.Text.ToString();
            Grad grad = RadSaBazomGrad.pretrazi(nazivGrada);

            ObrazovnaUstanova obrUst;
            if (nazivObrUstTxt.Text.Length > 0 && stepenObrComboBox.Text.Length > 0 && gradComboBox.Text.Length > 0)
            {
                obrUst = new ObrazovnaUstanova(naziv, stepen, grad.ptt);
                if (RadSaBazomObrazovnaUstanova.daLiPostoji(obrUst))
                {
                    MessageBox.Show("Ova obrazovna ustanova već postoji u bazi.");
                    nazivObrUstTxt.Clear();
                    stepenObrComboBox.ResetText();
                    gradComboBox.ResetText();
                }
                else
                {
                    if (RadSaBazomObrazovnaUstanova.unesi(obrUst))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        nazivObrUstTxt.Clear();
                        ucitajSve();
                        obrisiComboBox.Items.Add(obrUst.nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(obrUst.ptt));
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti sve podatke o obrazovnoj ustanovi.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            obrUstLv.Clear();
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
                List<ObrazovnaUstanova> obrUstanove = RadSaBazomObrazovnaUstanova.SpisakObrUst();
                foreach (ObrazovnaUstanova o in obrUstanove)
                    if (o.ptt == RadSaBazomGrad.pretrazi(naziv).ptt)
                    {
                        ListViewItem item = new ListViewItem(o.nazivOU.ToString() + ", " + RadSaBazomGrad.pretraziPoPtt(o.ptt));
                        item.Tag = o;
                        obrUstLv.Items.Add(item);
                    }
                pretraziTxt.Clear();
            }
            else
                MessageBox.Show("Obrazovne ustanove iz ovog grada ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String ulaz;
            String[] razdvojeno;
            String nazivObrUst;
            String grad;

            if (obrisiComboBox.Text.Length > 0)
            {
                ulaz = obrisiComboBox.Text.ToString();
                razdvojeno = ulaz.Split(", ");
                nazivObrUst = razdvojeno[0];
                grad = razdvojeno[1];
            }
            else
            {
                MessageBox.Show("Unesite naziv obrazovne ustanove.");
                return;
            }
            if (RadSaBazomObrazovnaUstanova.nadjiNazivIGrad(nazivObrUst, grad))
            {
                ObrazovnaUstanova obrUst = new ObrazovnaUstanova(nazivObrUst, RadSaBazomGrad.pretrazi(grad).ptt);
                if (RadSaBazomObrazovnaUstanova.obrisi(obrUst))
                {
                    MessageBox.Show("Uspešno obrisana obrazovna ustanova.");
                    ucitajSve();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja obrazovne ustanove iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željena obrazovna ustanova ne postoji u bazi.");
        }
    }
}
