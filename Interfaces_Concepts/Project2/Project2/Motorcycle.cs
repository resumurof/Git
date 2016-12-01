using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{    
    class Motorcycle : InterfaceVehicle, Icargocapacity
    {
        public double cargocapacity { get; set; }

        public int wheels { get; set; }
        

        public string description { get; set; }


        public string horsePower { get; set; }


        public double PI = 3.1415;
        public Motorcycle(int radius, int height)
        {
            cargocapacity = (PI * (radius * radius) * height) * 2;
        }        
       
    }
}
