using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public class Organizacija
    {
        public int id;
        public int idPoslJed;
        public int idOdeljenja;
        public int idRadMesta;

        public Organizacija(int idPoslJed, int idOdeljenja, int idRadMesta)
        {
            this.idPoslJed = idPoslJed;
            this.idOdeljenja = idOdeljenja;
            this.idRadMesta = idRadMesta;
        }

        public Organizacija(int id, int idPoslJed, int idOdeljenja, int idRadMesta)
        {
            this.id = id;
            this.idPoslJed = idPoslJed;
            this.idOdeljenja = idOdeljenja;
            this.idRadMesta = idRadMesta;
        }
    }
}
