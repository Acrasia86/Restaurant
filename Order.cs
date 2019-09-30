using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Order
    {
        public Order(string dish, string table)
        {
            Dish = dish;
            Table = table;
           
        }

        public string Dish { get; set; }
        public string Table { get; set; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

    }

    


}
