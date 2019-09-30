using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Restaurant
    {
        public string Name { get; set; }
        public Queue<Order> OrderQueue { get; } = new Queue<Order>();

        private Jeff Jeff { get; } = new Jeff();
        
        public Restaurant(string name)
        {
            Name = name;
        }
        
        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }

        public List<Order> ProcessOrders()
        {
            List<Order> completedOrders = new List<Order>();

            while (OrderQueue.Any())
            {
                Order currentOrder = OrderQueue.Dequeue();

                Jeff.Cook(currentOrder);

                completedOrders.Add(currentOrder);
            }
            return completedOrders;
        }
    }
}
