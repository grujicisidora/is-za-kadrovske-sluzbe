using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class RadnoMesto
    {
        public int id;
        public String naziv;
        public String opis;

        public RadnoMesto(String naziv)
        {
            this.naziv = naziv;
        }

        public RadnoMesto(String naziv, String opis)
        {
            this.naziv = naziv;
            this.opis = opis;
        }

        public RadnoMesto(int id, String naziv, String opis)
        {
            this.id = id;
            this.naziv = naziv;
            this.opis = opis;
        }
    }
}
