using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomUgovor : DbConnection
    {
        internal static List<Ugovor> SpisakUgovora()
        {
            String query = "SELECT * FROM ugovor";
            List<Ugovor> ugovori = new List<Ugovor>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_ugovora"];
                    String date = rd["Datum"].ToString();
                    int plata = (int)rd["Plata"];
                    String trajanje = rd["Trajanje"].ToString();
                    String tip = rd["tipUgovora"].ToString();

                    Ugovor u = new Ugovor(id, date, plata, trajanje, tip);
                    ugovori.Add(u);
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
            return ugovori;
        }

        internal static bool daLiPostoji(Ugovor ugovor)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM ugovor WHERE id_ugovora = '{0}'", ugovor.id);

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


        internal static bool unesi(Ugovor ugovor)
        {
            String query = String.Format("INSERT INTO `ugovor` (`id_ugovora`, `Datum`, `Plata`, `Trajanje`, `tipUgovora`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",ugovor.id, ugovor.date, ugovor.plata, ugovor.trajanje, ugovor.tip);

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

        public static bool nadjiDatum(String datum)
        {

            String query = String.Format("SELECT * FROM ugovor WHERE Datum='{0}'", datum);
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

        public static bool nadjiTip(String tip)
        {

            String query = String.Format("SELECT * FROM ugovor WHERE tipUgovora='{0}'", tip);
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

        public static bool nadjiId(int id)
        {

            String query = String.Format("SELECT * FROM ugovor WHERE id_ugovora='{0}'", id);
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

        internal static Ugovor pretraziPoId(int id)
        {
            String query = String.Format("SELECT * FROM ugovor WHERE id_ugovora = '{0}' ", id);
            
            sqlcon = new MySqlConnection(connectionString);
            Ugovor ugovor = null;
            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int idUgovora = (int)rd["id_ugovora"];
                    String date = rd["Datum"].ToString();
                    int plata = (int)rd["Plata"];
                    String trajanje = rd["Trajanje"].ToString();
                    String tip = rd["tipUgovora"].ToString();

                    ugovor = new Ugovor(idUgovora, date, plata, trajanje, tip);
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
            return ugovor;
        }

        internal static bool obrisi(int id)
        {
            String query = String.Format("DELETE FROM ugovor WHERE id_ugovora='{0}'", id);

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
    }
}
