using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class Zanimanje
    {
        public int id;
        public String naziv;
        public int obrUstanova;
        public String smer;

        public Zanimanje(String naziv, int obrUstanova, String smer)
        {
            this.naziv = naziv;
            this.obrUstanova = obrUstanova;
            this.smer = smer;
        }

        public Zanimanje(int id, String naziv, int obrUstanova, String smer)
        {
            this.id = id;
            this.naziv = naziv;
            this.obrUstanova = obrUstanova;
            this.smer = smer;
        }
    }
}
