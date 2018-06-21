using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Component
{
    class ArcReactor : IPowerSource
    {
        public double Remaining { get; set; }
        public double Capacity { get; set; } = 500;


        public ArcReactor()
        {
            Remaining = Capacity;
        }

        public double Charge(double amount)
        {
            if (Remaining + amount > Capacity)
            {
                Remaining = Capacity;
                return Remaining;
            }

            Remaining += amount;
            return Remaining;
        }

        public double Draw(double amount)
        {
            if (Remaining - amount <= 0)
            {
                Remaining = 0;
                return Remaining;
            }

            Remaining -= amount;
            return Remaining;
        }
    }
}
