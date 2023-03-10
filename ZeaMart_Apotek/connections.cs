using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//koneksi ke database
namespace ZeaMart_Apotek
{
    internal class connections
    {

        public static MySqlConnection getConnection() 
        {
            MySqlConnection koneksi = null;

            try
            {
                string sConnstring = "server = localhost;database= drugstore;uid=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
