using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomZanimanje : DbConnection
    {
        internal static List<Zanimanje> SpisakZanimanja()
        {
            String query = "SELECT * FROM zanimanje";
            List<Zanimanje> zanimanja = new List<Zanimanje>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_zanimanja"];
                    String naziv = rd["nazivZanimanja"].ToString();
                    int obrUstanova = (int)rd["id_obrUst"];
                    String smer = rd["Smer"].ToString();
                    
                    Zanimanje z = new Zanimanje(id, naziv, obrUstanova, smer);
                    zanimanja.Add(z);
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
            return zanimanja;
        }

        internal static bool daLiPostoji(Zanimanje zanimanje)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM zanimanje WHERE id_obrUst = '{0}' AND Smer = '{1}'", zanimanje.obrUstanova, zanimanje.smer);

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

        internal static bool unesi(Zanimanje zanimanje)
        {
            String query = String.Format("INSERT INTO `zanimanje` (`nazivZanimanja`, `id_obrUst`, `Smer`) VALUES ('{0}', '{1}', '{2}')", zanimanje.naziv, zanimanje.obrUstanova, zanimanje.smer);

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

        public static bool nadji(String naziv)
        {

            String query = String.Format("SELECT * FROM zanimanje WHERE nazivZanimanja='{0}'", naziv);
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

        public static bool nadji(String naziv, int idObrUst, String smer)
        {
            bool exists = false;
            String query = String.Format("SELECT * FROM zanimanje WHERE nazivZanimanja='{0}' AND id_obrUst='{1}' AND Smer='{2}'", naziv, idObrUst, smer);
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

            return exists;
        }

        internal static bool obrisi(Zanimanje zanimanje)
        {
            String query = String.Format("DELETE FROM zanimanje WHERE nazivZanimanja='{0}' AND id_obrUst='{1}' AND Smer='{2}'", zanimanje.naziv, zanimanje.obrUstanova, zanimanje.smer);

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

        internal static Zanimanje pretrazi(String naziv, int idObrUst, String smer)
        {
            String query = String.Format("SELECT * FROM zanimanje WHERE nazivZanimanja = '{0}' AND id_obrUst = '{1}' AND Smer = '{2}'", naziv, idObrUst, smer);
            Zanimanje zanimanje = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    zanimanje = new Zanimanje((int)rd["id_zanimanja"], rd["nazivZanimanja"].ToString(), (int)rd["id_obrUst"], rd["Smer"].ToString());
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
            return zanimanje;
        }

        internal static Zanimanje pretraziID(int id)
        {
            String query = String.Format("SELECT * FROM zanimanje WHERE id_zanimanja = '{0}'", id);
            Zanimanje zanimanje = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    zanimanje = new Zanimanje((int)rd["id_zanimanja"], rd["nazivZanimanja"].ToString(), (int)rd["id_obrUst"], rd["Smer"].ToString());
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
            return zanimanje;
        }
    }
}
