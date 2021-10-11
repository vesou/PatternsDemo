using System;
using NUnit.Framework;
using PatternsDemo.Api.Decorator;

namespace PatternsDemo.Tests.Api
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleDrink()
        {
            Coffee coffee = new Espresso();
            Console.WriteLine(coffee);
            Assert.AreEqual(_message1, coffee.ToString());
        }
        
        [Test]
        public void SimpleDrinkWithChocolate()
        {
            Coffee coffee = new Espresso();
            coffee = new Chocolate(coffee);
            Console.WriteLine(coffee);
            Assert.AreEqual(_message2, coffee.ToString());
        }
        
        [Test]
        public void SimpleDrinkWithExtras()
        {
            Coffee coffee = new Decaf();
            coffee = new Chocolate(coffee);
            coffee = new SoyMilk(coffee);
            Console.WriteLine(coffee);
            Assert.AreEqual(_message3, coffee.ToString());
        }
        
        [Test]
        public void DrinkWithTimer()
        {
            Coffee coffee = new Decaf();
            coffee = new Chocolate(coffee);
            coffee = new Timer(coffee);
            Console.WriteLine(coffee);
            Assert.AreEqual("", coffee.ToString());
        }
        
        [Test]
        public void DrinkWithTimer2()
        {
            Coffee coffee = new Decaf();
            coffee = new Chocolate(coffee);
            coffee = new Timer(coffee);
            coffee = new SoyMilk(coffee);
            coffee = new Timer(coffee);
            Console.WriteLine(coffee);
            Assert.AreEqual("", coffee.ToString());
        }
        
        
        
        
        
        
        
        
        
        
        private string _message1 = "Small but mighty drink costs 1.99";
        private string _message2 = "Small but mighty drink + Chocolate costs 2.29";
        private string _message3 = "Decaffeinated drink + Chocolate + SoyMilk costs 3.09";
    }
}