using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Automobile : InterfaceVehicle, Icargocapacity
    {
        public double cargocapacity { get; set; }

        public int wheels { get; set; }


        public string description { get; set; }
       

        public string horsePower { get; set; }
        
        public Automobile(int length, int width, int height)
        {
            cargocapacity = (length * width * height);
        }
    }
}
