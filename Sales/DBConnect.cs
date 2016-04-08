using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sales
{
    class DBConnect
    {
        //Constructor
        public DBConnect()
        {
            Initialize();
        }


        public MySqlConnection conn
        {
            get { return conn; }
        }



        //Initialize values
        private void Initialize()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=sales;Uid=root;password=alpine12";
            MySqlConnection conn = new MySqlConnection(connString);
        }



        //Open Connection
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Unable to connect to server");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid user/pass");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            } 
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }




    }
}
