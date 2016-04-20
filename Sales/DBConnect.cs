using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public void Insert(string price, string quantity, string itemname)
        {
            //Open Connection
            if (this.OpenConnection() == true)
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO INVENTORY(Price,Quantity,ItemName) VALUES(@price, @quantity, @itemname)";
                // Assign Values (used to prevent SQL injection)
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@itemname", itemname);
                //Execute Query
                cmd.ExecuteNonQuery();
                //Close Connection
                this.CloseConnection();
            }
        }


        //Open Connection
        public bool OpenConnection()
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


        public void InventoryInsert()
        {
            Console.WriteLine("Inserting into Inventory");

            string id;
            string price;
            string quantity;
            string name;

            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            price = Console.ReadLine();
            Console.WriteLine("Enter Quantity: ");
            quantity = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            string query = "INSERT INTO INVENTORY (ItemID, Price, Quantity, ItemName) VALUES ('" + id + "', '" + price + "', '" + quantity + "', '" + name + "');";

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


        public void InventoryUpdate()
        {
            Console.WriteLine("Updating Record in Inventory");

            string id;
            string price;
            string quantity;
            string name;

            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();

            string idselector = "Select * FROM INVENTORY WHERE ItemID ='" + id + "';";

           //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(idselector, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["ItemID"] + "");
                    list.Add(dataReader["Price"] + "");
                    list.Add(dataReader["Quantity"] + "");
                    list.Add(dataReader["ItemName"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }

            if (list.Count() == 0)
            {
                Console.WriteLine("ID Not Found");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Selecting for ItemID = " + id);
                Console.WriteLine("ItemId: " + list[0] + " Price: " + list[1] + " Quantity: " + list[2] + " ItemName: " + list[3]);


                Console.WriteLine("Enter Price: ");
                price = Console.ReadLine();
                Console.WriteLine("Enter Quantity In Stock: ");
                quantity = Console.ReadLine();
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                string query = "UPDATE INVENTORY SET Price='" + price + "', Quantity='" + quantity + "', ItemName='" + name + "' WHERE ItemID='" + id + "'";

                if (this.OpenConnection() == true)
                {
                    // Create command and assign the query and conn from the constructor.
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //Execute Query
                    cmd.ExecuteNonQuery();
                    //Close Connection
                    this.CloseConnection();
                }

                Console.WriteLine("Successfuly Updated");
                Console.ReadLine();
            }
        }

        public void InventoryDelete()
        {
            Console.WriteLine("Deleting Record");

            string id;

            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();

            string idselector = "Select * FROM INVENTORY WHERE ItemID ='" + id + "';";

            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(idselector, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["ItemID"] + "");
                    list.Add(dataReader["Price"] + "");
                    list.Add(dataReader["Quantity"] + "");
                    list.Add(dataReader["ItemName"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }

            if (list.Count() == 0)
            {
                Console.WriteLine("ID Not Found");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Deleting for ItemID = " + id);
                Console.WriteLine("ItemId: " + list[0] + " Price: " + list[1] + " Quantity: " + list[2] + " ItemName: " + list[3]);

                string confirm;

                Console.WriteLine("Confirm you want to delete Y/N");

                confirm = Console.ReadLine();

                if (confirm == "Y")
                {
                    string query = "DELETE FROM INVENTORY WHERE ItemID='" + id + "'";

                    if (this.OpenConnection() == true)
                    {
                        // Create command and assign the query and conn from the constructor.
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        //Execute Query
                        cmd.ExecuteNonQuery();
                        //Close Connection
                        this.CloseConnection();

                        Console.WriteLine("Succesfully Deleted");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Delete Failed");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
