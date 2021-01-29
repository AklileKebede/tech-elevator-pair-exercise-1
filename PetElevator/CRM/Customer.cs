using PetElevator.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; }

        public Customer(string firstName,string lastName, string phoneNumber):base(firstName,lastName)
        {
            this.PhoneNumber = phoneNumber;
            this.Pets = new List<Pet>();
        }

        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {
            this.PhoneNumber = "";
            this.Pets= new List<Pet>();
        }
    }
}
