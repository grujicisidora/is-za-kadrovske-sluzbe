using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomObrazovnaUstanova : DbConnection
    {
        internal static List<ObrazovnaUstanova> SpisakObrUst()
        {
            String query = "SELECT * FROM obrustanova";
            List<ObrazovnaUstanova> obrUstanove = new List<ObrazovnaUstanova>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_obrUst"];
                    String naziv = rd["nazivObrUst"].ToString();
                    String stepen = rd["stepenObrazovanja"].ToString();
                    int ptt = (int)rd["ptt"];

                    ObrazovnaUstanova o = new ObrazovnaUstanova(id, naziv, stepen, ptt);
                    obrUstanove.Add(o);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return obrUstanove;
        }

        internal static bool daLiPostoji(ObrazovnaUstanova obrUst)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM obrustanova WHERE nazivObrUst = '{0}' AND stepenObrazovanja = '{1}'", obrUst.nazivOU, obrUst.stepenObr);

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                var broj = Convert.ToInt32(cmd.ExecuteScalar());
                if (broj > 0)
                    indikator = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return indikator;
        }

        internal static bool unesi(ObrazovnaUstanova obrUst)
        {
            String query = String.Format("INSERT INTO `obrustanova` (`nazivObrUst`, `stepenObrazovanja`, `ptt`) VALUES ('{0}', '{1}', '{2}')", obrUst.nazivOU, obrUst.stepenObr, obrUst.ptt);
            
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                cmd.ExecuteNonQuery();

                ok = true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return ok;
        }

        public static bool nadji(String nazivGrada)
        {
            bool exists = false;
            if (RadSaBazomGrad.nadji(nazivGrada))
            {
                String query = String.Format("SELECT * FROM obrustanova WHERE ptt='{0}'", RadSaBazomGrad.pretrazi(nazivGrada).ptt);
                sqlcon = new MySqlConnection(connectionString);

                try
                {
                    MySqlDataReader reader;
                    sqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        exists = true;
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Inner Exception: " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("Query Executed: " + query);
                    Console.WriteLine();
                }
                finally
                {
                    sqlcon.Close();
                }
            }
            
            return exists;
        }

        public static bool nadjiNazivIGrad(String nazivObrUst, String nazivGrada)
        {
            bool exists = false;
            if (RadSaBazomGrad.nadji(nazivGrada))
            {
                String query = String.Format("SELECT * FROM obrustanova WHERE ptt='{0}' AND nazivObrUst='{1}'", RadSaBazomGrad.pretrazi(nazivGrada).ptt, nazivObrUst);
                sqlcon = new MySqlConnection(connectionString);

                try
                {
                    MySqlDataReader reader;
                    sqlcon.Open();
                    MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        exists = true;
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Inner Exception: " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("Query Executed: " + query);
                    Console.WriteLine();
                }
                finally
                {
                    sqlcon.Close();
                }
            }

            return exists;
        }

        internal static bool obrisi(ObrazovnaUstanova obrUst)
        {
            String query = String.Format("DELETE FROM obrustanova WHERE nazivObrUst='{0}' AND ptt='{1}'", obrUst.nazivOU, obrUst.ptt);

            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                cmd.ExecuteNonQuery();
                ok = true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return ok;
        }

        internal static ObrazovnaUstanova pretraziPoId(int id)
        {
            String query = String.Format("SELECT * FROM obrustanova WHERE id_obrUst = '{0}' ", id);
            ObrazovnaUstanova obrUst = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int idObrUst = (int)rd["id_obrUst"];
                    String naziv = rd["nazivObrUst"].ToString();
                    String stepen = rd["stepenObrazovanja"].ToString();
                    int ptt = (int)rd["ptt"];

                    obrUst = new ObrazovnaUstanova(idObrUst, naziv, stepen, ptt);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return obrUst;
        }

        internal static int pretraziPoNazivIGrad(String naziv, int ptt)
        {
            String query = String.Format("SELECT `id_obrUst` FROM obrustanova WHERE nazivObrUst = '{0}' AND ptt = '{1}'", naziv, ptt);
            int id = 0;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    id = (int)rd["id_obrUst"];
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return id;
        }
    }
}
