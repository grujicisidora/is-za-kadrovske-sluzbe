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
    public partial class UCSpisakZaposlenih : UserControl
    {
        ZaposleniForm form;
        public UCSpisakZaposlenih(ZaposleniForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<Zaposleni> zaposleni = RadSaBazomZaposleni.SpisakZaposlenih();

            if (zaposleniLv.Visible == true)
                zaposleniLv.Clear();

            if (zaposleni.Count > 0)
            {
                zaposleniLv.Show();
                foreach (Zaposleni z in zaposleni)
                {
                    ListViewItem item = new ListViewItem(z.ime.ToString() + " " + z.prezime.ToString() + ", JMBG: " + z.JMBG);
                    item.Tag = z;
                    zaposleniLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih zaposlenih.");
            }
        }

        private void osveziBtn_Click(object sender, EventArgs e)
        {
            ucitajSve();
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            form.Controls.Remove(this);
            form.Controls.Add(new UCZaposleniPocetna(form));
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            zaposleniLv.Clear();
            String JMBG;

            if (pretraziTxt.Text.Length > 0)
                JMBG = pretraziTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite JMBG zaposlenog.");
                return;
            }
            if (RadSaBazomZaposleni.nadji(JMBG))
            {
                List<Zaposleni> zaposleni = RadSaBazomZaposleni.SpisakZaposlenih();
                foreach (Zaposleni z in zaposleni)
                    if (z.JMBG == JMBG)
                    {
                        ListViewItem item = new ListViewItem(z.ime.ToString() + " " + z.prezime.ToString() + ", JMBG: " + z.JMBG);
                        item.Tag = z;
                        zaposleniLv.Items.Add(item);
                        pretraziTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ovaj zaposleni ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            String JMBG;

            if (obrisiTxt.Text.Length > 0)
                JMBG = obrisiTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite JMBG zaposlenog.");
                return;
            }
            if (RadSaBazomZaposleni.nadji(JMBG))
            {
                if (RadSaBazomZaposleni.obrisi(JMBG))
                {
                    MessageBox.Show("Uspešno obrisan zaposleni.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja zaposlenog iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeni zaposleni ne postoji u bazi.");
        }

        private void zaposleniLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zaposleniLv.SelectedItems.Count == 0)
                return;

            ListViewItem item = zaposleniLv.SelectedItems[0];
            Zaposleni zaposleni = (Zaposleni)item.Tag;


            Form forma = new ZaposleniProfilForm(zaposleni);
            forma.ShowDialog();
        }
    }
}
