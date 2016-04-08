using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sales
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            string connString = "Server=127.0.0.1;Port=3306;Database=sales;Uid=root;password=alpine12";

            MySqlConnection conn = new MySqlConnection(connString);

            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT ItemName FROM inventory where ItemID=1";


            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader["ItemName"].ToString());
            }

            Console.ReadLine();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }

}
