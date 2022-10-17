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
    public partial class UCOdeljenja : UserControl
    {
        OstaliPodaciForm form;

        public UCOdeljenja(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<Odeljenje> odeljenja = RadSaBazomOdeljenje.SpisakOdeljenja();

            if (odeljenjaLv.Visible == true)
                odeljenjaLv.Clear();

            if (odeljenja.Count > 0)
            {
                odeljenjaLv.Show();
                foreach (Odeljenje o in odeljenja)
                {
                    ListViewItem item = new ListViewItem(o.nazivOdeljenja.ToString());
                    item.Tag = o;
                    odeljenjaLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih odeljenja.");
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
            String nazivOdeljenja = nazivOdeljenjaTxt.Text.ToString();
            Odeljenje odeljenje;
            if (nazivOdeljenjaTxt.Text.Length > 0)
            {
                odeljenje = new Odeljenje(nazivOdeljenja);
                if (RadSaBazomOdeljenje.daLiPostoji(odeljenje))
                {
                    MessageBox.Show("Ovo odeljenje već postoji u bazi.");
                    nazivOdeljenjaTxt.Clear();
                }
                else
                {
                    if (RadSaBazomOdeljenje.unesi(odeljenje))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        nazivOdeljenjaTxt.Clear();
                        ucitajSve();
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti naziv odeljenja.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            odeljenjaLv.Clear();
            String nazivOdeljenja;

            if (pretraziTxt.Text.Length > 0)
                nazivOdeljenja = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv odeljenja.");
                return;
            }
            if (RadSaBazomOdeljenje.nadji(nazivOdeljenja))
            {
                List<Odeljenje> odeljenja = RadSaBazomOdeljenje.SpisakOdeljenja();
                foreach (Odeljenje o in odeljenja)
                    if (o.nazivOdeljenja == nazivOdeljenja)
                    {
                        ListViewItem item = new ListViewItem(o.nazivOdeljenja);
                        item.Tag = o;
                        odeljenjaLv.Items.Add(item);
                        pretraziTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ovo odeljenje ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String nazivOdeljenja;

            if (obrisiTxt.Text.Length > 0)
                nazivOdeljenja = obrisiTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv odeljenja.");
                return;
            }
            if (RadSaBazomOdeljenje.nadji(nazivOdeljenja))
            {
                if (RadSaBazomOdeljenje.obrisi(nazivOdeljenja))
                {
                    MessageBox.Show("Uspešno obrisano odeljenje.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja odeljenja iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeno odeljenje ne postoji u bazi.");
        }
    }
}
