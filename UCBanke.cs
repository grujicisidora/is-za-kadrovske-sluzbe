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
    public partial class UCBanke : UserControl
    {
        OstaliPodaciForm form;

        public UCBanke(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<Banka> banke = RadSaBazomBanka.SpisakBanaka();

            if (bankeLv.Visible == true)
                bankeLv.Clear();

            if (banke.Count > 0)
            {
                bankeLv.Show();
                foreach (Banka b in banke)
                {
                    ListViewItem item = new ListViewItem(b.nazivBanke);
                    item.Tag = b;
                    bankeLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih banaka.");
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
            String nazivBanke = nazivTxt.Text.ToString();
            Banka banka;
            if (nazivTxt.Text.Length > 0)
            {
                banka = new Banka(nazivBanke);
                if (RadSaBazomBanka.daLiPostoji(banka))
                {
                    MessageBox.Show("Ova banka već postoji u bazi.");
                    nazivTxt.Clear();
                }
                else
                {
                    if (RadSaBazomBanka.unesi(banka))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");
                        nazivTxt.Clear();
                        ucitajSve();
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti naziv banke.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            bankeLv.Clear();
            String nazivBanke;

            if (pretraziTxt.Text.Length > 0)
                nazivBanke = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv banke.");
                return;
            }
            if (RadSaBazomBanka.nadji(nazivBanke))
            {
                List<Banka> banke = RadSaBazomBanka.SpisakBanaka();
                foreach (Banka b in banke)
                    if (b.nazivBanke == nazivBanke)
                    {
                        ListViewItem item = new ListViewItem(b.nazivBanke);
                        item.Tag = b;
                        bankeLv.Items.Add(item);
                        pretraziTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ova banka ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String nazivBanke;

            if (obrisiTxt.Text.Length > 0)
                nazivBanke = obrisiTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite naziv banke.");
                return;
            }
            if (RadSaBazomBanka.nadji(nazivBanke))
            {
                if (RadSaBazomBanka.obrisi(nazivBanke))
                {
                    MessageBox.Show("Uspešno obrisana banka.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja banke iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željena banka ne postoji u bazi.");
        }
    }
}
