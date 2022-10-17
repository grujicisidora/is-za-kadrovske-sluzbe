using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class Banka
    {
        public int brBanke;
        public String nazivBanke;

        public Banka(String naziv)
        {
            nazivBanke = naziv;
        }

        public Banka(int id, String naziv)
        {
            brBanke = id;
            nazivBanke = naziv;
        }
    }
}
