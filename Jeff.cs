using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Restaurant
{
    class Jeff
    {
        public string Name { get; } = "Jeff";

        public void Cook(Order order)
        {
            order.Started();

            Thread.Sleep(2000);

            order.Completed();
        }
    }
}
