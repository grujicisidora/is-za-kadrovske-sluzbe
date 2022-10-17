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
    public partial class UCOrganizacija : UserControl
    {
        OstaliPodaciForm form;

        public UCOrganizacija(OstaliPodaciForm form)
        {
            this.form = form;
            InitializeComponent();
            ucitajSve();

            List<PoslovnaJedinica> poslJedinice = RadSaBazomPoslovnaJedinica.SpisakPoslJed();

            if (poslJedinice.Count > 0)
            {
                foreach (PoslovnaJedinica p in poslJedinice)
                {
                    poslJedComboBox.Items.Add(p.adresa);
                }
            }

            List<Odeljenje> odeljenja = RadSaBazomOdeljenje.SpisakOdeljenja();

            if (odeljenja.Count > 0)
            {
                foreach (Odeljenje o in odeljenja)
                {
                    odeljenjeComboBox.Items.Add(o.nazivOdeljenja);
                    pretraziComboBox.Items.Add(o.nazivOdeljenja);
                }
            }

            List<RadnoMesto> radnaMesta = RadSaBazomRadnoMesto.SpisakRadMesta();

            if (radnaMesta.Count > 0)
            {
                foreach (RadnoMesto r in radnaMesta)
                {
                    radMestoComboBox.Items.Add(r.naziv);
                }
            }
        }

        private void ucitajSve()
        {
            List<Organizacija> plan = RadSaBazomOrganizacija.PlanOrganizacije();

            if (organizacijaLv.Visible == true)
                organizacijaLv.Clear();

            if (plan.Count > 0)
            {
                organizacijaLv.Show();
                foreach (Organizacija o in plan)
                {
                    ListViewItem item = new ListViewItem("ID: "+ o.id.ToString() + " - " + RadSaBazomPoslovnaJedinica.pretraziID(o.idPoslJed).adresa + ", " + RadSaBazomOdeljenje.pretraziID(o.idOdeljenja).nazivOdeljenja + ", " + RadSaBazomRadnoMesto.pretraziID(o.idRadMesta).naziv);
                    item.Tag = o;
                    organizacijaLv.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih organizacionih jedinica.");
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
            Organizacija organizacija;

            if (poslJedComboBox.Text.Length > 0 && odeljenjeComboBox.Text.Length > 0 && radMestoComboBox.Text.Length > 0)
            {
                String poslJedinica = poslJedComboBox.Text.ToString();
                String odeljenje = odeljenjeComboBox.Text.ToString();
                String radMesto = radMestoComboBox.Text.ToString();
                int idPoslJed = RadSaBazomPoslovnaJedinica.pretrazi(poslJedinica).id;
                int idOdeljenja = RadSaBazomOdeljenje.pretrazi(odeljenje).id;
                int idRadMesta = RadSaBazomRadnoMesto.pretrazi(radMesto).id;
                
                organizacija = new Organizacija(idPoslJed, idOdeljenja, idRadMesta);
                if (RadSaBazomOrganizacija.daLiPostoji(organizacija))
                {
                    MessageBox.Show("Ova organizaciona jedinica već postoji u bazi.");
                }
                else
                {
                    if (RadSaBazomOrganizacija.unesi(organizacija))
                    {
                        MessageBox.Show("Uspešno uneti podaci.");                        
                        ucitajSve();
                        pretraziComboBox.Items.Add("ID: " + organizacija.id.ToString() + " - " + RadSaBazomPoslovnaJedinica.pretraziID(organizacija.idPoslJed).adresa + ", " + RadSaBazomOdeljenje.pretraziID(organizacija.idOdeljenja).nazivOdeljenja + ", " + RadSaBazomRadnoMesto.pretraziID(organizacija.idRadMesta).naziv);
                    }
                    else
                        MessageBox.Show("Došlo je do greške.");
                }
            }
            else
                MessageBox.Show("Morate uneti sve podatke o organizacionoj jedinici.");
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            organizacijaLv.Clear();
            String odeljenje;
            int idOdeljenja;

            if (pretraziComboBox.Text.Length > 0)
            {
                odeljenje = pretraziComboBox.Text.ToString();
                idOdeljenja = RadSaBazomOdeljenje.pretrazi(odeljenje).id;
            }   
            else
            {
                MessageBox.Show("Unesite naziv odeljenja.");
                return;
            }
            if (RadSaBazomOrganizacija.nadjiOdeljenje(idOdeljenja))
            {
                List<Organizacija> plan = RadSaBazomOrganizacija.PlanOrganizacije();
                foreach (Organizacija o in plan)
                    if (o.idOdeljenja == idOdeljenja)
                    {
                        ListViewItem item = new ListViewItem("ID: " + o.id.ToString() + " - " + RadSaBazomPoslovnaJedinica.pretraziID(o.idPoslJed).adresa + ", " + RadSaBazomOdeljenje.pretraziID(o.idOdeljenja).nazivOdeljenja + ", " + RadSaBazomRadnoMesto.pretraziID(o.idRadMesta).naziv);
                        item.Tag = o;
                        organizacijaLv.Items.Add(item);
                    }
            }
            else
                MessageBox.Show("Ovo odeljenje nije dodeljeno ni jednoj organizacionoj jedinici.");
        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            int id;

            if (obrisiTxt.Text.Length > 0)
            {
                int.TryParse(obrisiTxt.Text.ToString(), out id);
            }
            else
            {
                MessageBox.Show("Unesite ID organizacione jedinice.");
                return;
            }
            if (RadSaBazomOrganizacija.nadjiID(id))
            {
                Organizacija organizacija = RadSaBazomOrganizacija.pretraziID(id);
                if (RadSaBazomOrganizacija.obrisi(organizacija))
                {
                    MessageBox.Show("Uspešno obrisana organizaciona jedinica.");
                    ucitajSve();
                    obrisiTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom brisanja organizacione jedinice iz baze.");
                    return;
                }
            }
            else
                MessageBox.Show("Željena organizaciona jedinica ne postoji u bazi.");
        }
    }
}
