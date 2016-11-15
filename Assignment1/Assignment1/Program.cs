using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];

            customer[0] = new Customer() { FirstName = "Smith", LastName = "Joe",   order = new Order[3] { new Order { description = "Book", price = 3.00M, quantity = 3 }, new Order { description = "Book", price = 35000, quantity = 3 }, new Order { description = "Book", price = 250000, quantity = 3 } } };
            customer[1] = new Customer() { FirstName = "Jones", LastName = "Sally", order = new Order[3] { new Order { description = "Shoes", price = 45.00M, quantity = 2 }, new Order { description = "Dress", price = 60, quantity = 1 }, new Order { description = "Coat", price = 100, quantity = 1 } } };
            customer[2] = new Customer() { FirstName = "White", LastName = "Rick",  order = new Order[3] { new Order { description = "Jackets", price = 110, quantity = 1 }, new Order { description = "Pants", price = 25, quantity = 3 }, new Order { description = "Razor", price = 12.52M, quantity = 2 } } };

            PopulateCustomerDetails(customer);
        }

        public static void PopulateCustomerDetails(Customer[] customer)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < customer.Length; i++)
            {
                Console.WriteLine("                         ");
                Console.WriteLine(customer[i].LastName + " " + customer[0].LastName);
                Console.WriteLine("                         ");
                for (int j = 0; j < customer[i].order.Length; j++)
                {
                    result.Append(customer[i].order[j].description + " - " + String.Concat("$", customer[i].order[j].price) + " - " + customer[i].order[j].quantity + ", ");

                }
                int length = result.Length;
                string newstring = result.ToString();
                int lastIndex = newstring.LastIndexOf(',');

                Console.WriteLine(newstring.Remove(lastIndex));

                result.Clear();

            }
            Console.ReadLine();
        }
    }
}
