using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.model.entity;
using Project.model.logic;


namespace ProjectUnitTest
{
    [TestClass]
    public class Sheff_CookerUnitTets
    {
        private Sheff_Cooker sheffCooker;
        [TestInitialize]
        public void Init()
        {
            sheffCooker = Sheff_Cooker.GetInstance();
        }

        [TestMethod]
        public void TestCaltulateWeightOfSaladPositive()
        {
            Salad salad = new Salad();
            Cucumber cucumber1 = new Cucumber(10.5, true, 12.2, 0.5);
            Cucumber cucumber2 = new Cucumber(25.3, false, 35.7, 0.7);

            Tomato tomato1 = new Tomato("red", "Simple", 130.2, 1.3);
            Tomato tomato2 = new Tomato("black", "Little-Ptince", 40.8, 0.2);

            salad.Add(cucumber1);
            salad.Add(cucumber2);
            salad.Add(tomato1);
            salad.Add(tomato2);

            double expected = 2.7;

            double actual = sheffCooker.CaltulateWeightOfSalad(salad);

            Assert.AreEqual(expected, actual, 0);              
        }

        [TestMethod]
        public void TestCaltulateWeightOfSaladNull()
        {           
            double expected = 0;

            double actual = sheffCooker.CaltulateWeightOfSalad(null);

            Assert.AreEqual(expected, actual, 0);
        }

        [TestMethod]
        public void TestCaltulateWeightOfSaladWithEmptySalad()
        {
            Salad salad = new Salad();
            double expected = 0;

            double actual = sheffCooker.CaltulateWeightOfSalad(salad);

            Assert.AreEqual(expected, actual, 0);
        }
    }
}
