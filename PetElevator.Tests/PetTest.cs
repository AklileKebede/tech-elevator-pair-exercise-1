using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;
using PetElevator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTest
    {
        [DataTestMethod]
        [DataRow((new string[] {"Rabies", "Distemper", "Parvo" }), "Rabies, Distemper, Parvo")]
        [DataRow((new string[] { }), "No Vaccinations Found",DisplayName ="EdgeCase: Vaccinations is an empty list")]
       // [DataRow((new string[] { "Rabies", "Distemper", "Parvo" }), "Rabies, Distemper, Parvo")]

        [TestMethod]
        public void ListVaccinationTest(string[] vacArray, string expectedVac)
        {
            //Arrang
            string petName = "papi";
            string species = "cat";

            Pet petvac = new Pet(petName, species); // create an object


            petvac.Vaccinations.AddRange(vacArray);//Add values to the list Vaccinations
            //petvac.Vaccinations.Add("Distemper");
            //petvac.Vaccinations.Add("Parvo");

            //List<string> inputdVac = new List<string>() { "Rabies", "Distemper", "Parvo" };
            
            //Act-invoke
            string actualVac = petvac.ListVaccinations();

            //Assert
            Assert.AreEqual(expectedVac, actualVac);
        }
    }
}
