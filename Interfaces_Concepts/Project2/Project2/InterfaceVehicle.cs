using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    interface InterfaceVehicle : Icargocapacity
    { 
        int wheels { get; set; }
        string description { get; set; }
        string horsePower { get; set; }

    }

    interface Icargocapacity
    {
        double cargocapacity { get; set; }
    }
}
