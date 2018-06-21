using System.Collections.Generic;
using Workshop.Component;

namespace Workshop.Armor
{
    interface IArmorComponent : IComponent
    {
        string Material { get; set; }

        IEnumerable<IWeapon> GetWeaponLoadout();
        IEnumerable<IPowerSource> GetPowerSources();

    }
}
