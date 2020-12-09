using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.Models
{
    [Table("tshirtorder")]
    public class Order
    {

            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(250), Unique]
            public string Name { get; set; }
            public string Gender { get; set; }
            public string TShirt_Size { get; set; }
            public string Date_of_Order { get; set; }
            public string TShirt_Color { get; set; }
            public string Shipping_Address { get; set; }




    }
}
