using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {


            bool shouldNotExit = true;

            Console.Clear();

            while (shouldNotExit)
            {
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        shouldNotExit = false;
                        break;



                }

                Console.Clear();
            }
        }
    }
}
