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
        public DateTime? StartedAt { get; private set; }
        public DateTime? CompletedAt { get; set; }

        public void Started()
        {
            if(StartedAt != null)
            {
                throw new Exception("Order already started");
            }

            StartedAt = DateTime.Now;
        }

        public void Completed()
        {
            if(StartedAt == null)
            {
                throw new Exception("Order not started");
            }
            if(CompletedAt != null)
            {
                throw new Exception("Order already completed");
            }

            CompletedAt = DateTime.Now;
        }

    }

    


}
