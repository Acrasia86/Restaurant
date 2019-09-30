using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Restaurant
    {
        public string Name { get; set; }
        public Queue<Order> OrderQueue { get; } = new Queue<Order>();

        
        public Restaurant(string name)
        {
            Name = name;
        }
        
        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }
    }
}
