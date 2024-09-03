using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Tests
{
    [TestClass()]
    public class CoffeeTests
    {
        [TestMethod()]
        public void PriceTest_BlackCoffee()
        {
            Coffee c = new BlackCoffee(0);
            int price = c.Price();
            Assert.AreEqual(20, price);
        }
        [TestMethod()]
        public void PriceTest_Cortado()
        {
            Coffee c = new Cortado(0);
            int price = c.Price();
            Assert.AreEqual(25, price);
        }
        [TestMethod()]
        public void PriceTest_Latte()
        {
            Coffee c = new Latte(0);
            int price = c.Price();
            Assert.AreEqual(40, price);
        }
        [TestMethod()]
        public void PriceTest_DiscountAcceptable()
        {
            Coffee c = new BlackCoffee(5);
            int price = c.Price();
            Assert.AreEqual(15,price);
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void PriceTest_DiscountTooHigh()
        {
            Coffee c = new BlackCoffee(6);
            int price = c.Price();
            Assert.Fail();
        }

        [TestMethod()]
        public void StrengthTest_BlackCoffee()
        {
            Coffee coffee = new BlackCoffee(0);
            string strength = coffee.Strength();
            Assert.AreEqual("Strong", strength);
        }
        [TestMethod()]
        public void StrengthTest_Cortado()
        {
            Coffee coffee = new Cortado(0);
            string strength = coffee.Strength();
            Assert.AreEqual("Medium", strength);
        }
        [TestMethod()]
        public void StrengthTest_Latte()
        {
            Coffee coffee = new Latte(0);
            string strength = coffee.Strength();
            Assert.AreEqual("Weak", strength);
        }
    }
}