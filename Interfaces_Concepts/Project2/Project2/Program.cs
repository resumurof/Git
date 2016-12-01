using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];

            customer[0] = new Customer() { FirstName = "Smith", LastName = "Joe", order = new Order[3] {    new Order { vehicle = new Motorcycle(100, 100) {description = "MotorCycle", horsePower = "15BHP", wheels = 2 } , price = 3.00M, quantity = 3 },
                                                                                                            new Order { vehicle = new Motorcycle(100, 100) { description = "MotorCycle", horsePower = "25BHP", wheels = 2 }, price = 3.00M, quantity = 3 },
                                                                                                            new Order { vehicle = new Automobile(20, 20, 20) { description = "Automobile", horsePower = "100BHP", wheels = 4 } , price = 250000, quantity = 3 } } };

            customer[1] = new Customer() { FirstName = "Jones", LastName = "Sally", order = new Order[3] {  new Order { vehicle = new Motorcycle(50, 50) {description = "MotorCycle", horsePower = "95BHP", wheels = 2 }, price = 45.00M, quantity = 2 },
                                                                                                            new Order { vehicle = new Automobile(150, 150, 200) {description = "AutoMobile", horsePower = "195BHP", wheels = 4 }, price = 60, quantity = 1 },
                                                                                                            new Order { vehicle = new Motorcycle(50, 50) {description = "MotorCycle", horsePower = "200BHP", wheels = 6 }, price = 100, quantity = 1 } } };

            customer[2] = new Customer() { FirstName = "White", LastName = "Rick", order = new Order[3] {   new Order { vehicle = new Motorcycle(50, 50) {description = "MotorCycle", horsePower = "95BHP", wheels = 2 }, price = 110, quantity = 1 },
                                                                                                            new Order { vehicle = new Motorcycle(50, 50) {description = "MotorCycle", horsePower = "100BHP", wheels = 2 }, price = 25, quantity = 3 },
                                                                                                            new Order { vehicle = new Motorcycle(50, 50) {description = "MotorCycle", horsePower = "135BHP", wheels = 2 }, price = 12.52M, quantity = 2 } } };

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
                    result.Append(customer[i].order[j].vehicle.description + " - " + String.Concat("$", customer[i].order[j].price) + " - " + customer[i].order[j].quantity + " - " + customer[i].order[j].vehicle.cargocapacity + ", ");

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
