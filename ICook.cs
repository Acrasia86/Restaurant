using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    interface ICook
    {
        string Name { get; }
        void Cook(Order order);
    }
}
