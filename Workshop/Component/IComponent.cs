using System.Collections.Generic;

namespace Workshop.Component
{
    interface IComponent
    {
        string Name { get; set; }
        IEnumerable<IComponent> GetComponents();
    }
}
