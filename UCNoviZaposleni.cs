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
    public partial class UCNoviZaposleni : UserControl
    {
        ZaposleniForm form;

        public UCNoviZaposleni(ZaposleniForm form)
        {
            this.form = form;
            InitializeComponent();
            form.Text = "Dodaj podatke o novom zaposlenom";
            ucitajZanimanja();
            ucitajPoslJedinice();
            ucitajOdeljenja();
            ucitajRadMesta();
            ucitajUgovore();
            ucitajBanke();
            ucitajGradove();
        }

        private void ucitajZanimanja()
        {
            List<Zanimanje> zanimanja = RadSaBazomZanimanje.SpisakZanimanja();

            if (zanimanja.Count > 0)
            {
                foreach (Zanimanje z in zanimanja)
                {
                    zanimanjeComboBox.Items.Add(z.naziv + ", " + RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(RadSaBazomObrazovnaUstanova.pretraziPoId(z.obrUstanova).ptt) + ", " + z.smer.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nema unetih zanimanja.");
            }
        }

        private void ucitajPoslJedinice()
        {
            List<PoslovnaJedinica> poslJedinice = RadSaBazomPoslovnaJedinica.SpisakPoslJed();

            if (poslJedinice.Count > 0)
            {
                foreach (PoslovnaJedinica p in poslJedinice)
                {
                    poslJedComboBox.Items.Add(p.adresa + ", " + RadSaBazomGrad.pretraziPoPtt(p.ptt));
                }
            }
            else
            {
                MessageBox.Show("Nema unetih poslovnih jedinica.");
            }
        }

        private void ucitajOdeljenja()
        {
            List<Odeljenje> odeljenja = RadSaBazomOdeljenje.SpisakOdeljenja();

            if (odeljenja.Count > 0)
            {
                foreach (Odeljenje o in odeljenja)
                {
                    odeljenjeComboBox.Items.Add(o.nazivOdeljenja);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih odeljenja.");
            }
        }

        private void ucitajRadMesta()
        {
            List<RadnoMesto> radnaMesta = RadSaBazomRadnoMesto.SpisakRadMesta();

            if (radnaMesta.Count > 0)
            {
                foreach (RadnoMesto r in radnaMesta)
                {
                    radMestoComboBox.Items.Add(r.naziv);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih radnih mesta.");
            }
        }

        private void ucitajUgovore()
        {
            List<Ugovor> ugovori = RadSaBazomUgovor.SpisakUgovora();

            if (ugovori.Count > 0)
            {
                foreach (Ugovor u in ugovori)
                {
                    brUgovoraComboBox.Items.Add(u.id);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih ugovora.");
            }
        }

        private void ucitajBanke()
        {
            List<Banka> banke = RadSaBazomBanka.SpisakBanaka();

            if (banke.Count > 0)
            {
                foreach (Banka b in banke)
                {
                    bankaComboBox.Items.Add(b.nazivBanke);
                }
            }
            else
            {
                MessageBox.Show("Nema unetih banaka.");
            }
        }

        private void ucitajGradove()
        {
            List<Grad> gradovi = RadSaBazomGrad.SpisakGradova();

            if (gradovi.Count > 0)
            {
                foreach (Grad g in gradovi)
                {
                    gradComboBox.Items.Add(g.naziv);
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
            form.Controls.Add(new UCZaposleniPocetna(form));
        }

        private void zanimanjeBtn_Click(object sender, EventArgs e)
        {
            if (zanimanjeComboBox.Text.Length > 0)
            {
                String ulaz = zanimanjeComboBox.Text.ToString();
                String[] razdvojeno = ulaz.Split(", ");
                String nazivZanimanja = razdvojeno[0];
                String nazivObrUst = razdvojeno[1];
                String grad = razdvojeno[2];
                String smer = razdvojeno[3];
                int ptt = RadSaBazomGrad.pretrazi(grad).ptt;
                int idObrUst = RadSaBazomObrazovnaUstanova.pretraziPoNazivIGrad(nazivObrUst, ptt);
                if (RadSaBazomZanimanje.nadji(nazivZanimanja, idObrUst, smer))
                {
                    Zanimanje zanimanje = new Zanimanje(nazivZanimanja, idObrUst, smer);
                    Form forma = new ZanimanjeForm(form, this, zanimanje);
                    forma.ShowDialog();
                }
                else
                    MessageBox.Show("Željeno zanimanje ne postoji u bazi.");   
            }
            else
                MessageBox.Show("Unesite zanimanje.");
        }


        private void radMestoBtn_Click(object sender, EventArgs e)
        {
            if (radMestoComboBox.Text.Length > 0 && odeljenjeComboBox.Text.Length > 0 && poslJedComboBox.Text.Length > 0)
            {
                String RadMesto = radMestoComboBox.Text.ToString();
                int idRadMesto = RadSaBazomRadnoMesto.pretrazi(RadMesto).id;
                String odeljenje = odeljenjeComboBox.Text.ToString();
                int idOdeljenja = RadSaBazomOdeljenje.pretrazi(odeljenje).id;
                String poslJedUnos = poslJedComboBox.Text.ToString();
                String[] poslJedRazdvojeno = poslJedUnos.Split(", ");
                int idPoslJed = RadSaBazomPoslovnaJedinica.pretrazi(poslJedRazdvojeno[0]).id;
                if (RadSaBazomOrganizacija.nadjiParametre(idPoslJed, idOdeljenja, idRadMesto))
                {
                    Organizacija organizacija = RadSaBazomOrganizacija.pretraziParametre(idPoslJed, idOdeljenja, idRadMesto);
                    Form forma = new RadnoMestoForm(form, this, organizacija);
                    forma.ShowDialog();
                }
                else
                    MessageBox.Show("Željeno radno mesto ne postoji u bazi.");
            }
            else
                MessageBox.Show("Unesite poslovnu jedinicu, odeljenje i radno mesto.");    
        }

        private void ugovorBtn_Click(object sender, EventArgs e)
        {
            if (brUgovoraComboBox.Text.Length > 0)
            {
                int id;
                int.TryParse(brUgovoraComboBox.Text.ToString(), out id);
                if (RadSaBazomUgovor.nadjiId(id))
                {
                    Ugovor ugovor = RadSaBazomUgovor.pretraziPoId(id);
                    Form forma = new UgovorForm(form, this, ugovor);
                    forma.ShowDialog();
                }
                else
                    MessageBox.Show("Željeni ugovor ne postoji u bazi.");
            }
            else
                MessageBox.Show("Unesite broj ugovora.");        
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            form.Hide();
            OstaliPodaciForm forma = new OstaliPodaciForm();
            forma.ShowDialog();
            form.Close();
        }

        private void unesiBtn_Click(object sender, EventArgs e)
        {
            String JMBG;
            String ime;
            String prezime;
            String imeRoditelja;
            String devPrezime;
            String adresa;
            String nazivGrada;
            Grad grad;
            String zanimanjeUnos;
            String[] zanimanjeRazdvojeno;
            int idZanimanja;
            String LBO;
            String brojZI;
            int staz;
            String poslJedUnos;
            String[] poslJedRazdvojeno;
            int idPoslJed;
            String odeljenje;
            int idOdeljenja;
            String RadMesto;
            int idRadMesto;
            int brUgovora;
            String banka;
            int idBanke;
            String brRacuna;
            

            Zaposleni zaposleni;
            if (imeTxt.Text.Length > 0 && prezimeTxt.Text.Length > 0 && imeRoditeljaTxt.Text.Length > 0 && jmbgTxt.Text.Length > 0 && adresaTxt.Text.Length > 0 && gradComboBox.Text.Length > 0 && zanimanjeComboBox.Text.Length > 0 && lboTxt.Text.Length > 0 && brojZITxt.Text.Length > 0 && poslJedComboBox.Text.Length > 0 && odeljenjeComboBox.Text.Length > 0 && radMestoComboBox.Text.Length > 0 && brUgovoraComboBox.Text.Length > 0 && bankaComboBox.Text.Length > 0 && brojRacunaTxt.Text.Length > 0)
            {
                if(lboTxt.Text.Length != 11 || brojZITxt.Text.Length != 11)
                {
                    MessageBox.Show("Neispravan LBO ili broj ZI.");
                    return;
                }
                ime = imeTxt.Text.ToString();
                prezime = prezimeTxt.Text.ToString();
                imeRoditelja = imeRoditeljaTxt.Text.ToString();
                JMBG = jmbgTxt.Text.ToString();
                devPrezime = devPrezimeTxt.Text.ToString();
                adresa = adresaTxt.Text.ToString();
                nazivGrada = gradComboBox.Text.ToString();
                grad = RadSaBazomGrad.pretrazi(nazivGrada);
                zanimanjeUnos = zanimanjeComboBox.Text.ToString();
                zanimanjeRazdvojeno = zanimanjeUnos.Split(", ");
                idZanimanja = RadSaBazomZanimanje.pretrazi(zanimanjeRazdvojeno[0], RadSaBazomObrazovnaUstanova.pretraziPoNazivIGrad(zanimanjeRazdvojeno[1], RadSaBazomGrad.pretrazi(zanimanjeRazdvojeno[2]).ptt), zanimanjeRazdvojeno[3]).id;
                LBO = lboTxt.Text.ToString();
                brojZI = brojZITxt.Text.ToString();
                int.TryParse(radniStazTxt.Text.ToString(), out staz);
                poslJedUnos = poslJedComboBox.Text.ToString();
                poslJedRazdvojeno = poslJedUnos.Split(", ");
                idPoslJed = RadSaBazomPoslovnaJedinica.pretrazi(poslJedRazdvojeno[0]).id;
                odeljenje = odeljenjeComboBox.Text.ToString();
                idOdeljenja = RadSaBazomOdeljenje.pretrazi(odeljenje).id;
                RadMesto = radMestoComboBox.Text.ToString();
                idRadMesto = RadSaBazomRadnoMesto.pretrazi(RadMesto).id;
                int.TryParse(brUgovoraComboBox.Text.ToString(), out brUgovora);
                banka = bankaComboBox.Text.ToString();
                idBanke = RadSaBazomBanka.pretrazi(banka).brBanke;
                brRacuna = brojRacunaTxt.Text.ToString();
                
                zaposleni = new Zaposleni(JMBG, ime, prezime, imeRoditelja, devPrezime, adresa, grad.ptt, idZanimanja, LBO, brojZI, staz, idPoslJed, idOdeljenja, idRadMesto, brUgovora, idBanke, brRacuna);
                if (RadSaBazomZaposleni.daLiPostojiUgovor(zaposleni))
                {
                    MessageBox.Show("Greška u broju ugovora. Već postoji zaposleni sa ovim brojem ugovora.");
                    return;
                }
                else
                {
                    if(RadSaBazomOrganizacija.nadjiParametre(idPoslJed, idOdeljenja, idRadMesto))
                    {
                        if (RadSaBazomZaposleni.daLiPostoji(zaposleni))
                        {
                            MessageBox.Show("Ovaj zaposleni već postoji u bazi.");
                            form.Controls.Remove(this);
                            form.Controls.Add(new UCNoviZaposleni(form));
                        }
                        else
                        {
                            if (RadSaBazomZaposleni.unesi(zaposleni))
                            {
                                MessageBox.Show("Uspešno uneti podaci.");
                                form.Controls.Remove(this);
                                form.Controls.Add(new UCNoviZaposleni(form));
                            }
                            else
                                MessageBox.Show("Došlo je do greške.");
                        }
                    }
                    else
                        MessageBox.Show("Izbor radnog mesta, odeljenja i poslovne jedinice nije u skladu sa organizacionom šemom.");
                }  
            }
            else
                MessageBox.Show("Morate uneti sve podatke o zaposlenom.");
        }
    }
}
