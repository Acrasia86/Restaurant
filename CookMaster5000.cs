using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Restaurant
{
    class CookMaster5000 : ICook
    {
        public string Name => "Cook master 5000";

        public void Cook(Order order)
        {
            order.Started();

            Thread.Sleep(1000);

            order.Completed();
        }
    }
}
