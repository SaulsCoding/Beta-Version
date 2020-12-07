using System;
using System.Collections.Generic;
using System.Linq;
using People.Models;
using SQLite;

namespace People
{
    public class OrderRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteConnection conn;
        public OrderRepository(string dbPath)
        {
            //  Initialize a new SQLiteConnection
            //  Create the Person table
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Order>();
        }

        public void AddNewOrder(string name, string gender, string tshirt_size,string date_of_order, string tshirt_color, string shipping_address)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                // insert a new table
                    result = conn.Insert(new Order { Name = name, Gender = gender, TShirt_Size = tshirt_size, Date_of_Order = date_of_order, TShirt_Color = tshirt_color, Shipping_Address = shipping_address });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public List<Order> GetAllOrder()
        {
            //  return a list of orders saved to the table in the database
            try
            {
                return conn.Table<Order>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Order>();
        }
    }
}