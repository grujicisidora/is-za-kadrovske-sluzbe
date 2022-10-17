using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public partial class ZaposleniProfilForm : Form
    {
        Zaposleni zaposleni;
        Zanimanje zanimanje;
        ObrazovnaUstanova obrUst;
        PoslovnaJedinica poslJed;

        public ZaposleniProfilForm(Zaposleni zaposleni)
        {
            this.zaposleni = zaposleni;
            InitializeComponent();
            imeLbl.Text = zaposleni.ime;
            prezimeLbl.Text = zaposleni.prezime;
            imeRoditeljaLbl.Text = zaposleni.imeRoditelja;
            JMBGLbl.Text = zaposleni.JMBG;
            devPrezimeLbl.Text = zaposleni.devPrezime;
            adresaLbl.Text = zaposleni.adresa;
            gradLbl.Text = RadSaBazomGrad.pretraziPoPtt(zaposleni.ptt);
            this.zanimanje = RadSaBazomZanimanje.pretraziID(zaposleni.idZanimanja);
            this.obrUst = RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.id);
            zanimanjeLbl.Text = zanimanje.naziv + ", " + obrUst.nazivOU + ", " + zanimanje.smer;
            LBOLbl.Text = zaposleni.LBO;
            brojZILbl.Text = zaposleni.brojZI;
            stazLbl.Text = zaposleni.staz.ToString();
            this.poslJed = RadSaBazomPoslovnaJedinica.pretraziID(zaposleni.idPoslJed);
            poslJedLbl.Text = poslJed.adresa + ", " +RadSaBazomGrad.pretraziPoPtt(poslJed.ptt);
            odeljenjeLbl.Text = RadSaBazomOdeljenje.pretraziID(zaposleni.idOdeljenja).nazivOdeljenja;
            radMestoLbl.Text = RadSaBazomRadnoMesto.pretraziID(zaposleni.idRadMesto).naziv;
            brUgovoraLbl.Text = zaposleni.brUgovora.ToString();
            bankaLbl.Text = RadSaBazomBanka.pretraziID(zaposleni.idBanke);
            brRacunaLbl.Text = zaposleni.brRacuna;
        }

        private void eksportBtn_Click(object sender, EventArgs e)
        {
            string filename = "Izveštaj o zaposlenom";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Izveštaj o zaposlenom";
            sfd.Filter = "CSV File (.csv) | *.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        sw.WriteLine("Ime:, " + imeLbl.Text);
                        sw.WriteLine("Prezime:, " + prezimeLbl.Text);
                        sw.WriteLine("Ime roditelja:, " + imeRoditeljaLbl.Text);
                        sw.WriteLine("JMBG:, " + JMBGLbl.Text.ToString());
                        sw.WriteLine("Devojacko prezime:, " + devPrezimeLbl.Text);
                        sw.WriteLine("Adresa prebivalista:, " + adresaLbl.Text);
                        sw.WriteLine("Grad:, " + gradLbl.Text);
                        sw.WriteLine("Zanimanje:, " + zanimanje.naziv);
                        sw.WriteLine("Stepen obrazovanja:, " + obrUst.stepenObr);
                        sw.WriteLine("Obrazovna ustanova:, " + obrUst.nazivOU + " " + RadSaBazomGrad.pretraziPoPtt(obrUst.ptt));
                        sw.WriteLine("Smer:, " + zanimanje.smer);
                        sw.WriteLine("LBO:, " + LBOLbl.Text);
                        sw.WriteLine("Broj ZI:, " + brojZILbl.Text);
                        sw.WriteLine("Godine radnog staza:, " + stazLbl.Text);
                        sw.WriteLine("Poslovna jedinica:, " + poslJed.adresa + " " + RadSaBazomGrad.pretraziPoPtt(poslJed.ptt));
                        sw.WriteLine("Odeljenje:, " + odeljenjeLbl.Text);
                        sw.WriteLine("Radno mesto:, " + radMestoLbl.Text);
                        sw.WriteLine("Godine radnog staza:, " + stazLbl.Text);
                        sw.WriteLine("Broj ugovora:, " + brUgovoraLbl.Text);
                        sw.WriteLine("Banka:, " + bankaLbl.Text);
                        sw.WriteLine("Broj racuna:, " + brRacunaLbl.Text);
                    }
                }
                MessageBox.Show("Uspešno ste sačuvali fajl.");
            }
            else MessageBox.Show("Došlo je do greške.");
        }
    }
}
