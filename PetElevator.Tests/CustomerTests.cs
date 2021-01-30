using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.CRM;



namespace PetElevator.Tests
{[TestClass]
    public class CustomerTests
    {
        [DataTestMethod]
        [DataRow(new double[] { 25.00, 15.00, 10.25 } , new string[] { "parvo", "vac2", "vac3" }, 50.25)]
        [DataRow(new double[] { }, new string[] { }, 0.00)]
       // [DataRow(new double[] { 10.00, 59.00, 11.35 }, 80.35)]
      

        public void GetBalanceDue_Test(double[] chargesArray,string[] serviceArray, double expectedBalance)
        {
            //arrange
            Customer customer = new Customer("Aklile", "K");
            Dictionary<string, double> dictionaryInvoices = new Dictionary<string, double>();
            
            for (int i=0; i < chargesArray.Length; i++)
            {
                dictionaryInvoices.Add(serviceArray[i], chargesArray[i]);
            }
            //act
            double actualBlance = customer.GetBalanceDue(dictionaryInvoices);

                //assert
            Assert.AreEqual(expectedBalance, actualBlance);




        }



        //[TestMethod]
        //public void ListVaccinationTest(string[] vacArray, string expectedVac)
        //{
        //    //Arrang
        //    string petName = "papi";
        //    string species = "cat";

        //    Pet petvac = new Pet(petName, species); // create an object


        //    petvac.Vaccinations.AddRange(vacArray);//Add values to the list Vaccinations
        //                                           //petvac.Vaccinations.Add("Distemper");
        //                                           //petvac.Vaccinations.Add("Parvo");

        //    //List<string> inputdVac = new List<string>() { "Rabies", "Distemper", "Parvo" };

        //    //Act-invoke
        //    string actualVac = petvac.ListVaccinations();

        //    //Assert
        //    Assert.AreEqual(expectedVac, actualVac);




        //}
    }
}
