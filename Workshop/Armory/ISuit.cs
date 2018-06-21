using System.Collections.Generic;
using Workshop.Armor;
using Workshop.Component;

namespace Workshop.Armory
{
    interface ISuit
    {
        IArtificialIntelligence AI { get; set; }

        IHeadpiece Headpiece { get; set; }
        IChestpiece Chestpiece { get; set; }
        IBackpiece Backpiece { get; set; }
        IShoulderpiece LeftShoulderpiece { get; set; }
        IShoulderpiece RightShoulderpiece { get; set; }
        IArmpiece LeftArmpiece { get; set; }
        IArmpiece RightArmpiece { get; set; }
        ILegpiece LeftLegpiece { get; set; }
        ILegpiece RightLegpiece { get; set; }
    }
}
