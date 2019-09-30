using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Order
    {
        public Order(string orders, string table)
        {
            Orders = orders;
            Table = table;
           
        }

        public string Orders { get; set; }
        public string Table { get; set; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

    }

    


}
