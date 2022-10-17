﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    class RadSaBazomOdeljenje : DbConnection
    {
        internal static List<Odeljenje> SpisakOdeljenja()
        {
            String query = "SELECT * FROM odeljenje";
            List<Odeljenje> odeljenja = new List<Odeljenje>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int id = (int)rd["id_odeljenja"];
                    String nazivOdeljenja = rd["nazivOdeljenja"].ToString();

                    Odeljenje o = new Odeljenje(id, nazivOdeljenja);
                    odeljenja.Add(o);
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
            return odeljenja;
        }

        internal static bool daLiPostoji(Odeljenje odeljenje)
        {
            bool indikator = false;
            String query = String.Format("SELECT COUNT(*) FROM odeljenje WHERE nazivOdeljenja = '{0}'", odeljenje.nazivOdeljenja);

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

        internal static bool unesi(Odeljenje odeljenje)
        {
            String query = String.Format("INSERT INTO `odeljenje` (`nazivOdeljenja`) VALUES ('{0}')", odeljenje.nazivOdeljenja);
            //sqlcon = DbConnection.GetConnection();
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

        public static bool nadji(String nazivOdeljenja)
        {

            String query = String.Format("SELECT * FROM odeljenje WHERE nazivOdeljenja='{0}'", nazivOdeljenja);
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


        internal static bool obrisi(String nazivOdeljenja)
        {
            String query = String.Format("DELETE FROM odeljenje WHERE nazivOdeljenja='{0}'", nazivOdeljenja);

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

        internal static Odeljenje pretrazi(String naziv)
        {
            String query = String.Format("SELECT * FROM odeljenje WHERE nazivOdeljenja = '{0}' ", naziv);
            Odeljenje odeljenje = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    odeljenje = new Odeljenje((int)rd["id_odeljenja"], rd[1].ToString());
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
            return odeljenje;
        }

        internal static Odeljenje pretraziID(int id)
        {
            String query = String.Format("SELECT * FROM odeljenje WHERE id_odeljenja = '{0}' ", id);
            Odeljenje odeljenje = null;

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    odeljenje = new Odeljenje((int)rd["id_odeljenja"], rd[1].ToString());
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
            return odeljenje;
        }
    }
}
