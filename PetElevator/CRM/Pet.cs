using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Pet
    {
        public string PetName { get; set; }

        public string Species { get; set; }

        public List<string> Vaccinations { get; set; }

        public Pet(string petName, string species)
        {
            this.PetName = petName;
            this.Species = species;
            this.Vaccinations = new List<string>();

        }

        public string ListVaccinations()
        {
            //The ListVaccinations method returns the elements of Vaccinations as a comma - delimited string.
            //For example, if the List contains["Rabies", "Distemper", "Parvo"], the output must be "Rabies, Distemper, Parvo".
           
            if (Vaccinations.Count == 0)
            {
                return "No Vaccinations Found";
            }

            return string.Join(", ", Vaccinations);
          
            


        }






    }
}
