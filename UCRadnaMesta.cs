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
    public partial class UCRadnaMesta : UserControl
    {
        OstaliPodaciForm form;

        public UCRadnaMesta(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<RadnoMesto> radMesta = RadSaBazomRadnoMesto.SpisakRadMesta();

            if (radMestaLv.Visible == true)
                radMestaLv.Clear();

            if (radMesta.Count > 0)
            {
                radMestaLv.Show();
                foreach (RadnoMesto r in radMesta)
                {
                    ListViewItem item = new ListViewItem(r.naziv);
                    item.Tag = r;
                    radMestaLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih radnih mesta.");
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
            String naziv = nazivRadMestaTxt.Text.ToString();
            String opis = opisTxt.Text.ToString();
            RadnoMesto radMesto;
            if (nazivRadMestaTxt.Text.Length > 0 && opisTxt.Text.Length > 0)
            {
                radMesto = new RadnoMesto(naziv, opis);
                if (RadSaBazomRadnoMesto.daLiPostoji(radMesto))
                {
                    MessageBox.Show("Ovo radno mesto već postoji u bazi.");
                    nazivRadMestaTxt.Clear();
                    opisTxt.Clear();
                }
                else
                {
                    if (RadSaBazomRadnoMesto.unesi(radMesto))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        nazivRadMestaTxt.Clear();
                        opisTxt.Clear();
                        ucitajSve();
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti sve podatke o radnom mestu.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            radMestaLv.Clear();
            String naziv;

            if (pretraziTxt.Text.Length > 0)
                naziv = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv radnog mesta.");
                return;
            }
            if (RadSaBazomRadnoMesto.nadji(naziv))
            {
                List<RadnoMesto> radMesta = RadSaBazomRadnoMesto.SpisakRadMesta();
                foreach (RadnoMesto r in radMesta)
                    if (r.naziv == naziv)
                    {
                        ListViewItem item = new ListViewItem(r.naziv);
                        item.Tag = r;
                        radMestaLv.Items.Add(item);
                        pretraziTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ovo radno mesto ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String naziv;

            if (obrisiTxt.Text.Length > 0)
                naziv = obrisiTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv radnog mesta.");
                return;
            }
            if (RadSaBazomRadnoMesto.nadji(naziv))
            {
                if (RadSaBazomRadnoMesto.obrisi(naziv))
                {
                    MessageBox.Show("Uspešno obrisano radno mesto.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja radnog mesta iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeno radno mesto ne postoji u bazi.");
        }

        private void radMestaLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMestaLv.SelectedItems.Count == 0)
                return;

            ListViewItem item = radMestaLv.SelectedItems[0];
            RadnoMesto izabranoRadMesto = (RadnoMesto)item.Tag;


            Form forma = new RadnoMestoForm(form, this, izabranoRadMesto);
            forma.ShowDialog();
        }
    }
}
