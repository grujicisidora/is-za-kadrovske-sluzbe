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
    public partial class UCGradovi : UserControl
    {
        OstaliPodaciForm form;

        public UCGradovi(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<Grad> gradovi = RadSaBazomGrad.SpisakGradova();

            if (gradoviLv.Visible == true)
                gradoviLv.Clear();

            if (gradovi.Count > 0)
            {
                gradoviLv.Show();
                foreach (Grad g in gradovi)
                {
                    ListViewItem item = new ListViewItem(g.ptt.ToString() + " " + g.naziv);
                    item.Tag = g;
                    gradoviLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih gradova.");
            }
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCOstaliPodaciPocetna(form));
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            int ptt;
            String naziv = gradTxt.Text.ToString();
            Grad grad;
            if (int.TryParse(pttTxt.Text.ToString(), out ptt) && gradTxt.Text.Length > 0)
            {
                grad = new Grad(ptt, naziv);
                if (RadSaBazomGrad.daLiPostoji(grad))
                {
                    MessageBox.Show("Ovaj grad već postoji u bazi.");
                    pttTxt.Clear();
                    gradTxt.Clear();
                }    
                else
                {
                    if (RadSaBazomGrad.unesi(grad))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        pttTxt.Clear();
                        gradTxt.Clear();
                        ucitajSve();
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }   
            }     
            else
                MessageBox.Show("Morate uneti sve podatke o gradu.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            gradoviLv.Clear();
            String naziv;

            if (pretraziTxt.Text.Length > 0)
                naziv = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv grada.");
                return;
            }
            if (RadSaBazomGrad.nadji(naziv))
            {
                List<Grad> gradovi = RadSaBazomGrad.SpisakGradova();
                foreach (Grad g in gradovi)
                    if (g.naziv == naziv)
                    {
                        ListViewItem item = new ListViewItem(g.ptt.ToString() + " " + g.naziv);
                        item.Tag = g;
                        gradoviLv.Items.Add(item);
                        pretraziTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ovaj grad ne postoji u bazi.");
        }

        private void osveziBtn_Click(object sender, EventArgs e)
        {
            ucitajSve();
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String naziv;

            if (obrisiTxt.Text.Length > 0)
                naziv = obrisiTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv grada.");
                return;
            }
            if (RadSaBazomGrad.nadji(naziv))
            {
                if (RadSaBazomGrad.obrisi(naziv))
                {
                    MessageBox.Show("Uspešno obrisan grad.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja grada iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeni grad ne postoji u bazi.");
        }
    }
}
