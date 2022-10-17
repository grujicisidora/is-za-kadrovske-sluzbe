using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomRadnoMesto : DbConnection
    {
        internal static List<RadnoMesto> SpisakRadMesta()
        {
            String query = "SELECT * FROM radnomesto";
            List<RadnoMesto> radMesta = new List<RadnoMesto>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_radnogMesta"];
                    String naziv = rd["nazivRadMesta"].ToString();
                    String opis = rd["Opis"].ToString();

                    RadnoMesto r = new RadnoMesto(id, naziv, opis);
                    radMesta.Add(r);
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
            return radMesta;
        }


        internal static bool daLiPostoji(RadnoMesto radMesto)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM radnomesto WHERE nazivRadMesta = '{0}'", radMesto.naziv);

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

        internal static bool unesi(RadnoMesto radMesto)
        {
            String query = String.Format("INSERT INTO `radnomesto` (`nazivRadMesta`, `Opis`) VALUES ('{0}', '{1}')", radMesto.naziv, radMesto.opis);

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

            String query = String.Format("SELECT * FROM radnomesto WHERE nazivRadMesta='{0}'", naziv);
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

        internal static bool obrisi(String naziv)
        {
            String query = String.Format("DELETE FROM radnomesto WHERE nazivRadMesta='{0}'", naziv);

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

        internal static RadnoMesto pretrazi(String naziv)
        {
            String query = String.Format("SELECT * FROM radnomesto WHERE nazivRadMesta = '{0}' ", naziv);
            RadnoMesto radMesto = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    radMesto = new RadnoMesto((int)rd["id_radnogMesta"], rd["nazivRadMesta"].ToString(), rd["Opis"].ToString());
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
            return radMesto;
        }

        internal static RadnoMesto pretraziID(int id)
        {
            String query = String.Format("SELECT * FROM radnomesto WHERE id_radnogMesta = '{0}' ", id);
            RadnoMesto radMesto = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    radMesto = new RadnoMesto((int)rd["id_radnogMesta"], rd["nazivRadMesta"].ToString(), rd["Opis"].ToString());
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
            return radMesto;
        }
    }
}
