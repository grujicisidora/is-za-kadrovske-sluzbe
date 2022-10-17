using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class DbConnection
    {
        protected static MySqlConnection sqlcon;
        protected static String connectionString = "datasource=localhost; username=root; password=; database=prijem_radnika; SslMode=None";
    }
}
