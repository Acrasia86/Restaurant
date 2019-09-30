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

        private ICook Chef { get; }
        
        public Restaurant(string name, ICook chef)
        {
            Name = name;
            Chef = chef;
        }
        
        public void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }

        public List<Order> ProcessOrders()
        {
            Console.WriteLine($"{Chef.Name} is processing the orders");
            List<Order> completedOrders = new List<Order>();

            while (OrderQueue.Any())
            {
                Order currentOrder = OrderQueue.Dequeue();

                Chef.Cook(currentOrder);

                completedOrders.Add(currentOrder);
            }
            return completedOrders;
        }
    }
}
