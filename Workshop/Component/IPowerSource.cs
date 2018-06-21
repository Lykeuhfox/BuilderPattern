using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Component
{
    interface IPowerSource
    {
        double Capacity { get; set; }

        double Draw(double amount);
        double Charge(double amount);
    }
}
