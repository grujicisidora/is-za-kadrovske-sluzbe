using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomPoslovnaJedinica : DbConnection
    {
        internal static List<PoslovnaJedinica> SpisakPoslJed()
        {
            String query = "SELECT * FROM poslovnajedinica";
            List<PoslovnaJedinica> poslJedinice = new List<PoslovnaJedinica>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_jedinice"];
                    String adresa = rd["adresa"].ToString();
                    int ptt = (int)rd["ptt"];

                    PoslovnaJedinica p = new PoslovnaJedinica(id, adresa, ptt);
                    poslJedinice.Add(p);
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
            return poslJedinice;
        }


        internal static bool daLiPostoji(PoslovnaJedinica poslJed)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM poslovnajedinica WHERE adresa = '{0}'", poslJed.adresa);

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


        internal static bool unesi(PoslovnaJedinica poslJed)
        {
            String query = String.Format("INSERT INTO `poslovnajedinica` (`adresa`, `ptt`) VALUES ('{0}', '{1}')", poslJed.adresa, poslJed.ptt);

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

        public static bool nadji(String adresa)
        {

            String query = String.Format("SELECT * FROM poslovnajedinica WHERE adresa='{0}'", adresa);
            sqlcon = new MySqlConnection(connectionString);
            bool exists = false;

            MySqlDataReader reader;
            try
            {
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

            return exists;
        }


        internal static bool obrisi(PoslovnaJedinica poslJed)
        {
            String query = String.Format("DELETE FROM poslovnajedinica WHERE adresa='{0}'", poslJed.adresa);

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

        internal static PoslovnaJedinica pretrazi(String adresa)
        {
            String query = String.Format("SELECT * FROM poslovnajedinica WHERE adresa = '{0}' ", adresa);
            PoslovnaJedinica poslJed = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    poslJed = new PoslovnaJedinica((int)rd["id_jedinice"], rd["adresa"].ToString(), (int)rd["ptt"]);
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
            return poslJed;
        }


        internal static PoslovnaJedinica pretraziID(int id)
        {
            String query = String.Format("SELECT * FROM poslovnajedinica WHERE id_jedinice = '{0}' ", id);
            PoslovnaJedinica poslJed = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    poslJed = new PoslovnaJedinica((int)rd["id_jedinice"], rd["adresa"].ToString(), (int)rd["ptt"]);
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
            return poslJed;
        }
    }
}
