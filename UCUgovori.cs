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
    public partial class UCUgovori : UserControl
    {
        OstaliPodaciForm form;
        Ugovor izabraniUgovor;

        public UCUgovori(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();
        }

        private void ucitajSve()
        {
            List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();

            if (ugovoriLv.Visible == true)
                ugovoriLv.Clear();

            if (ugovori.Count > 0)
            {
                ugovoriLv.Show();
                foreach (Ugovor u in ugovori)
                {
                    ListViewItem item = new ListViewItem("ID: " + u.id.ToString() + " - " + u.tip.ToString() + ", " + u.trajanje);
                    item.Tag = u;
                    ugovoriLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih ugovora.");
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
            DateTime date = datumDTP.Value;
            String datum = date.Year + "-" + date.Month + "-" + date.Day;
            int id;
            int plata;
            String trajanje = trajanjeTxt.Text.ToString();
            String tip = tipUgovoraComboBox.Text.ToString();
            Ugovor ugovor;

            if (int.TryParse(plataTxt.Text.ToString(), out plata) && int.TryParse(idTxt.Text.ToString(), out id) && datumDTP.Text.Length > 0 && trajanjeTxt.Text.Length > 0 && tipUgovoraComboBox.Text.Length > 0)
            { 
                if(idTxt.Text.Length == 5)
                {
                    ugovor = new Ugovor(id, datum, plata, trajanje, tip);
                    if (RadSaBazomUgovor.daLiPostoji(ugovor))
                    {
                        MessageBox.Show("Ovaj ugovor već postoji u bazi.");
                        datumDTP.ResetText();
                        plataTxt.Clear();
                        trajanjeTxt.Clear();
                        tipUgovoraComboBox.ResetText();
                    }
                    else
                    {
                        if (RadSaBazomUgovor.unesi(ugovor))
                        {
                            MessageBox.Show("Uspešno uneti podaci.");
                            idTxt.Clear();
                            plataTxt.Clear();
                            trajanjeTxt.Clear();
                            ucitajSve();
                        }
                        else
                            MessageBox.Show("Došlo je do greške.");
                    }
                }
                else
                    MessageBox.Show("Broj ugovora se mora sastojati od tačno pet cifara.");
            }
            else
                MessageBox.Show("Morate uneti sve podatke o ugovoru.");
        }

        private void pretraziDatumBtn_Click(object sender, EventArgs e)
        {
            ugovoriLv.Clear();
            DateTime date;
            String datum;

            if (pretraziDTP.Text.Length > 0)
            {
                date = pretraziDTP.Value;
                datum = date.Year + "-" + date.Month + "-" + date.Day;
            }
            else
            {
                MessageBox.Show("Unesite datum.");
                return;
            }
            if (RadSaBazomUgovor.nadjiDatum(datum))
            {
                List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();
                ugovoriLv.Show();
                foreach (Ugovor u in ugovori)
                {
                    DateTime result;
                    DateTime.TryParse(u.date, out result);
                    if (result == date)
                    {
                        ListViewItem item = new ListViewItem("ID: " + u.id.ToString() + " - " + u.tip.ToString() + ", " + u.trajanje);
                        item.Tag = u;
                        ugovoriLv.Items.Add(item);
                    }
                }      
            }
            else
                MessageBox.Show("Nema zaključenih ugovora za ovaj datum.");
        }

        private void pretraziTipBtn_Click(object sender, EventArgs e)
        {
            ugovoriLv.Clear();
            String tip;
            if (pretraziTipComboBox.Text.Length > 0 && pretraziDTP.Text.Length > 0)
                tip = pretraziTipComboBox.Text.ToString();            
            else
            {
                MessageBox.Show("Unesite tip ugovora.");
                return;
            }
            if (RadSaBazomUgovor.nadjiTip(tip))
            {
                List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();
                foreach (Ugovor u in ugovori)
                    if (u.tip == tip)
                    {
                        ListViewItem item = new ListViewItem("ID: " + u.id.ToString() + " - " + u.tip.ToString() + ", " + u.trajanje);
                        item.Tag = u;
                        ugovoriLv.Items.Add(item);
                    }
                pretraziTipComboBox.ResetText();
            }
            else
                MessageBox.Show("Ugovori ovog tipa ne postoje u bazi.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            ugovoriLv.Clear();
            String tip;
            DateTime date;
            String datum;

            if (pretraziTipComboBox.Text.Length > 0)
            {
                tip = pretraziTipComboBox.Text.ToString();
                date = pretraziDTP.Value;
                datum = date.Year + "-" + date.Month + "-" + date.Day;
            }
            else
            {
                MessageBox.Show("Unesite tip ugovora.");
                return;
            }
            if (RadSaBazomUgovor.nadjiTip(tip) && RadSaBazomUgovor.nadjiDatum(datum))
            {
                List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();
                foreach (Ugovor u in ugovori)
                {
                    DateTime result;
                    DateTime.TryParse(u.date, out result);
                    if (u.tip == tip && result == date)
                    {
                        ListViewItem item = new ListViewItem("ID: " + u.id.ToString() + " - " + u.tip.ToString() + ", " + u.trajanje);
                        item.Tag = u;
                        ugovoriLv.Items.Add(item);
                    }
                }     
                pretraziTipComboBox.ResetText();
            }
            else
                MessageBox.Show("Ovakvi ugovori ne postoje u bazi.");
        }

        private void pretraziIdBtn_Click(object sender, EventArgs e)
        {
            ugovoriLv.Clear();
            int id;

            if (pretraziIdTxt.Text.Length > 0)
                int.TryParse(pretraziIdTxt.Text.ToString(), out id);
            else
            {
                MessageBox.Show("Unesite broj ugovora.");
                return;
            }
            if (RadSaBazomUgovor.nadjiId(id))
            {
                List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();
                foreach (Ugovor u in ugovori)
                    if (u.id == id)
                    {
                        ListViewItem item = new ListViewItem("ID: " + u.id.ToString() + " - " + u.tip.ToString() + ", " + u.trajanje);
                        item.Tag = u;
                        ugovoriLv.Items.Add(item);
                        pretraziIdTxt.Clear();
                        break;
                    }
            }
            else
                MessageBox.Show("Ovaj ugovor ne postoji u bazi.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            int id;

            if (obrisiTxt.Text.Length > 0)
                int.TryParse(obrisiTxt.Text.ToString(), out id); 
            else
            {
                MessageBox.Show("Unesite broj ugovora.");
                return;
            }
            if (RadSaBazomUgovor.nadjiId(id)) 
            {
                if (RadSaBazomUgovor.obrisi(id))
                {
                    MessageBox.Show("Uspešno obrisan ugovor.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja ugovora iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željeni ugovor ne postoji u bazi.");
        }

        private void ugovoriLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ugovoriLv.SelectedItems.Count == 0)
                return;

            ListViewItem item = ugovoriLv.SelectedItems[0];
            izabraniUgovor = (Ugovor)item.Tag;


            Form forma = new UgovorForm(form, this, izabraniUgovor);
            forma.ShowDialog();
        }
    }
}
