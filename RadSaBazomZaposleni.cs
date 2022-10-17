using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomZaposleni : DbConnection
    {
        internal static bool daLiPostoji(Zaposleni zaposleni)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM zaposleni WHERE JMBG = '{0}'", zaposleni.JMBG);

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

        internal static bool daLiPostojiUgovor(Zaposleni zaposleni)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM zaposleni WHERE id_ugovora = '{0}'", zaposleni.brUgovora);

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

        internal static bool unesi(Zaposleni zaposleni)
        {
            String query = String.Format("INSERT INTO `zaposleni` (`JMBG`, `Ime`, `Prezime`, `imeRoditelja`, `devPrezime`, `adrPrebivalista`, `godRadnogStaza`, `LBO`, `brojZI`, `ptt`, `brRacuna`, `brBanke`, `id_ugovora`, `id_zanimanja`, `id_jedinice`, `id_odeljenja`, `id_radnogMesta`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')", zaposleni.JMBG, zaposleni.ime, zaposleni.prezime, zaposleni.imeRoditelja, zaposleni.devPrezime, zaposleni.adresa, zaposleni.staz, zaposleni.LBO, zaposleni.brojZI, zaposleni.ptt, zaposleni.brRacuna, zaposleni.idBanke, zaposleni.brUgovora, zaposleni.idZanimanja, zaposleni.idPoslJed, zaposleni.idOdeljenja, zaposleni.idRadMesto);

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

        internal static List<Zaposleni> SpisakZaposlenih()
        {
            String query = "SELECT * FROM zaposleni";
            List<Zaposleni> zaposleni = new List<Zaposleni>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    String JMBG = rd["JMBG"].ToString();
                    String ime = rd["Ime"].ToString();
                    String prezime = rd["Prezime"].ToString();
                    String imeRoditelja = rd["imeRoditelja"].ToString();
                    String devPrezime = rd["devPrezime"].ToString();
                    String adresa = rd["adrPrebivalista"].ToString();
                    int ptt = (int)rd["ptt"];
                    int idZanimanja = (int)rd["id_zanimanja"];
                    String LBO = rd["LBO"].ToString();
                    String brojZI = rd["brojZI"].ToString();
                    int staz = (int)rd["godRadnogStaza"];
                    int idPoslJed = (int)rd["id_jedinice"];
                    int idOdeljenja = (int)rd["id_odeljenja"];
                    int idRadMesto = (int)rd["id_radnogMesta"];
                    int brUgovora = (int)rd["id_ugovora"];
                    int idBanke = (int)rd["brBanke"];
                    String brRacuna = rd["brRacuna"].ToString();
                    
                    Zaposleni z = new Zaposleni(JMBG, ime, prezime, imeRoditelja, devPrezime, adresa, ptt, idZanimanja, LBO, brojZI, staz, idPoslJed, idOdeljenja, idRadMesto, brUgovora, idBanke, brRacuna);
                    zaposleni.Add(z);
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
            return zaposleni;
        }

        public static bool nadji(String JMBG)
        {

            String query = String.Format("SELECT * FROM zaposleni WHERE JMBG='{0}'", JMBG);
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

        internal static bool obrisi(String JMBG)
        {
            String query = String.Format("DELETE FROM zaposleni WHERE JMBG='{0}'", JMBG);

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
