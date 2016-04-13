using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            Console.WriteLine("Test");

            DBConnect db = new DBConnect();

            string dbtable;
            string dboperation;

            Console.WriteLine("Select Table");
            dbtable = Console.ReadLine();

            Console.WriteLine("Select Database Operation");
            dboperation = Console.ReadLine();

            switch(dboperation)
            {
                case "Insert":
                    db.InventoryInsert();
                    break;
                case "Update":
                    db.InventoryUpdate();
                    break;
                case "Delete":
                    db.InventoryDelete();
                    break;
                default:
                    Console.WriteLine("Error Selecting Database Operation");
                    Console.ReadLine();
                    break;
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }

}
