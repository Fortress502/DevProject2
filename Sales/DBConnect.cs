using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sales
{
    public class DBConnect
    {
        private MySqlConnection conn;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connString = "Server=110.22.83.243;Port=3306;Database=sales;Uid=root;password=alpine12";
            conn = new MySqlConnection(connString);
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
                    default:
                        Console.WriteLine("Unknown Error");
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


        public void Insert()
        {
            string query = "INSERT INTO INVENTORY (ItemID, Price, Quantity, ItemName) VALUES ('3', '50', '2', 'Screw Driver');";


            //Open Connection

            if (this.OpenConnection() == true)
            {
                // Create command and assign the query and conn from the constructor.
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Execute Query
                cmd.ExecuteNonQuery();
                //Close Connection
                this.CloseConnection();


            }
        }

        public void Update()
        {
            string query = "UPDATE INVENTORY SET Price='100', Quantity='3', ItemName='Super Driver' WHERE ItemID='3'";

            if (this.OpenConnection() == true)
            {
                // Create command and assign the query and conn from the constructor.
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Execute Query
                cmd.ExecuteNonQuery();
                //Close Connection
                this.CloseConnection();


            }
        }

        public void Delete()
        {
            string query = "DELETE FROM INVENTORY WHERE ItemName='Super Driver'";

            if (this.OpenConnection() == true)
            {
                // Create command and assign the query and conn from the constructor.
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Execute Query
                cmd.ExecuteNonQuery();
                //Close Connection
                this.CloseConnection();


            }
        }


    }
}
