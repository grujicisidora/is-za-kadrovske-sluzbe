using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class Odeljenje
    {
        public int id;
        public String nazivOdeljenja;

        public Odeljenje(String nazivOdeljenja)
        {
            this.nazivOdeljenja = nazivOdeljenja;
        }

        public Odeljenje(int id, String nazivOdeljenja)
        {
            this.id = id;
            this.nazivOdeljenja = nazivOdeljenja;
        }
    }
}
