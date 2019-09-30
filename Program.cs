using System;
using System.Collections.Generic;
using System.Threading;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("McDonalds");
            bool shouldNotExit = true;

            Console.Clear();

            while (shouldNotExit)
            {
                Console.Clear();
                Console.WriteLine("1. Add order");
                Console.WriteLine("2. List orders");
                Console.WriteLine("3. Process orders");
                Console.WriteLine("4. Exit");

                int userInput = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (userInput)
                {
                    case 1:

                        Console.Write("Dish: ");
                        string dish = Console.ReadLine();

                        Console.Write("Table: ");
                        string table = Console.ReadLine();

                        Order order = new Order(dish, table);

                        restaurant.RegisterOrder(order);

                        Console.Clear();

                        Console.WriteLine("Order registered");
                        Thread.Sleep(2000);
                        

                        break;
                    case 2:

                        break;
                    case 3:
                        
                        break;
                    case 4:
                        shouldNotExit = false;
                        break;



                }

                Console.Clear();
            }

        }

        
    }

}
