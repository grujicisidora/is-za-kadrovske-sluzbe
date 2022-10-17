using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{ 
    public class Zaposleni
    {
        public String JMBG;
        public String ime;
        public String prezime;
        public String imeRoditelja;
        public String devPrezime;
        public String adresa;
        public int ptt;
        public int idZanimanja;
        public String LBO;
        public String brojZI;
        public int staz;
        public int idPoslJed;
        public int idOdeljenja;
        public int idRadMesto;
        public int brUgovora;
        public int idBanke;
        public String brRacuna;

        public Zaposleni(String JMBG, String ime, String prezime, String imeRoditelja, String devPrezime, String adresa, int ptt, int idZanimanja, String LBO, String brojZI, int staz, int idPoslJed, int idOdeljenja, int idRadMesto, int brUgovora, int idBanke, String brRacuna)
        {
            this.JMBG = JMBG;
            this.ime = ime;
            this.prezime = prezime;
            this.imeRoditelja = imeRoditelja;
            this.devPrezime = devPrezime;
            this.adresa = adresa;
            this.ptt = ptt;
            this.idZanimanja = idZanimanja;
            this.LBO = LBO;
            this.brojZI = brojZI;
            this.staz = staz;
            this.idPoslJed = idPoslJed;
            this.idOdeljenja = idOdeljenja;
            this.idRadMesto = idRadMesto;
            this.brUgovora = brUgovora;
            this.idBanke = idBanke;
            this.brRacuna = brRacuna;
        }
    }
}
