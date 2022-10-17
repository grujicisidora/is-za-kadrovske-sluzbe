using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class PoslovnaJedinica
    {
        public int id;
        public String adresa;
        public int ptt;

        public PoslovnaJedinica(String adresa)
        {
            this.adresa = adresa;      
        }

        public PoslovnaJedinica(String adresa, int ptt)
        {
            this.adresa = adresa;
            this.ptt = ptt;
        }

        public PoslovnaJedinica(int id, String adresa, int ptt)
        {
            this.id = id;
            this.adresa = adresa;
            this.ptt = ptt;
        }
    }
}
