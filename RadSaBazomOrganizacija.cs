using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomOrganizacija : DbConnection
    {
        internal static List<Organizacija> PlanOrganizacije()
        {
            String query = "SELECT * FROM organizacija";
            List<Organizacija> plan = new List<Organizacija>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_organizacije"];
                    int idPoslJed = (int)rd["id_poslJed"];
                    int idOdeljenja = (int)rd["id_odeljenja"];
                    int idRadMesta = (int)rd["id_radMesta"];

                    Organizacija o = new Organizacija(id, idPoslJed, idOdeljenja, idRadMesta);
                    plan.Add(o);
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
            return plan;
        }

        internal static bool daLiPostoji(Organizacija organizacija)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM organizacija WHERE id_poslJed = '{0}' AND id_odeljenja = '{1}' AND id_radMesta = '{2}'", organizacija.idPoslJed, organizacija.idOdeljenja, organizacija.idRadMesta);

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


        internal static bool unesi(Organizacija organizacija)
        {
            String query = String.Format("INSERT INTO `organizacija` (`id_poslJed`, `id_odeljenja`, `id_radMesta`) VALUES ('{0}', '{1}', '{2}')", organizacija.idPoslJed, organizacija.idOdeljenja, organizacija.idRadMesta);

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

        public static bool nadjiOdeljenje(int idOdeljenja)
        {

            String query = String.Format("SELECT * FROM organizacija WHERE id_odeljenja='{0}'", idOdeljenja);
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


        public static bool nadjiID(int id)
        {

            String query = String.Format("SELECT * FROM organizacija WHERE id_organizacije='{0}'", id);
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

        public static bool nadjiParametre(int idPoslJed, int idOdeljenja, int idRadMesta)
        {

            String query = String.Format("SELECT * FROM organizacija WHERE id_poslJed='{0}' AND id_odeljenja = '{1}' AND id_radMesta = '{2}'", idPoslJed, idOdeljenja, idRadMesta);
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

        internal static Organizacija pretraziID(int id)
        {
            String query = String.Format("SELECT * FROM organizacija WHERE id_organizacije = '{0}'", id);
            Organizacija organizacija = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    organizacija = new Organizacija((int)rd["id_organizacije"], (int)rd["id_poslJed"], (int)rd["id_odeljenja"], (int)rd["id_radMesta"]);
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
            return organizacija;
        }

        internal static Organizacija pretraziParametre(int idPoslJed, int idOdeljenja, int idRadMesta)
        {
            String query = String.Format("SELECT * FROM organizacija WHERE id_poslJed = '{0}' AND id_odeljenja = '{1}' AND id_radMesta", idPoslJed, idOdeljenja, idRadMesta);
            Organizacija organizacija = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    organizacija = new Organizacija((int)rd["id_organizacije"], (int)rd["id_poslJed"], (int)rd["id_odeljenja"], (int)rd["id_radMesta"]);
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
            return organizacija;
        }

        internal static bool obrisi(Organizacija organizacija)
        {
            String query = String.Format("DELETE FROM organizacija WHERE id_organizacije='{0}'", organizacija.id);

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
