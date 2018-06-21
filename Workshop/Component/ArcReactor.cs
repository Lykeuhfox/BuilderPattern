using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Component
{
    class ArcReactor : IComponent, IPowerSource
    {
        public string Name { get; set; } = "Arc Reactor";
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

        public IEnumerable<IComponent> GetComponents()
        {
            return new List<IComponent>();
        }
    }
}
