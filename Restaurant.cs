using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Restaurant
    {
        public string Name { get; set; }
        private Queue<Order> orderQueue { get; } = new Queue<Order>();
        public Restaurant(string name)
        {
            Name = name;
        }
        
        public void RegisterOrder(Order order)
        {
            orderQueue.Enqueue(order);
        }
    }
}
