using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Component
{
    class Repulsor : IComponent, IMobilityOption, IWeapon
    {
        public string Name { get; set; } = "Repulsor";

        public IEnumerable<IComponent> GetComponents()
        {
            return new List<IComponent>();
        }

        public string Use()
        {
            return $"Fire {Name}!";
        }
    }
}
