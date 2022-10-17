using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class ObrazovnaUstanova
    {
        int id;
        public int ptt;
        public String nazivOU;
        public String stepenObr;

        public ObrazovnaUstanova(String naziv, int ptt)
        {
            nazivOU = naziv;
            this.ptt = ptt;
        }

        public ObrazovnaUstanova(String naziv, String stepen, int ptt)
        {
            nazivOU = naziv;
            stepenObr = stepen;
            this.ptt = ptt;
        }

        public ObrazovnaUstanova(int id, String naziv, String stepen, int ptt)
        {
            this.id = id;
            nazivOU = naziv;
            stepenObr = stepen;
            this.ptt = ptt;
        }
    }
}
