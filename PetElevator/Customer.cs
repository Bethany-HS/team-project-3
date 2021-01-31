using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;
using PetElevator.HR;

namespace PetElevator
{
    public class Customer : Person, IBillable
    {
        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }
        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public string PhoneNumber { get; set; } = "";
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public double GetBalanceDue(Dictionary<string, double> services)
        {
            double totalPrice = 0.0;
            foreach (string service in services.Keys)
            {
                totalPrice += services[service];
            }
            return totalPrice;
        }

    }
}
