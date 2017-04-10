using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Customer
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public Order[] order = new Order[3];
    }
}
