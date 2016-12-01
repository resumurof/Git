using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Order
    {
        //public string description { get; set; }
        public InterfaceVehicle vehicle { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}
