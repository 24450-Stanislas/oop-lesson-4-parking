using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson4_parking.models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the CarPark()");
        }

        public override string ToString()
        {
            return "I am the CarPark()";
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                double calculatedCharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer : cost is {calculatedCharge}");
            }
        }
    }
}
