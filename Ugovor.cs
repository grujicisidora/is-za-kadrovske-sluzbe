using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class Ugovor
    {
        public int id;
        public String date;
        public int plata;
        public String trajanje;
        public String tip;

        public Ugovor(String date, int plata, String trajanje, String tip)
        {
            this.date = date;
            this.plata = plata;
            this.trajanje = trajanje;
            this.tip = tip;
        }

        public Ugovor(int id, String date, int plata, String trajanje, String tip)
        {
            this.id = id;
            this.date = date;
            this.plata = plata;
            this.trajanje = trajanje;
            this.tip = tip;
        }
    }
}
