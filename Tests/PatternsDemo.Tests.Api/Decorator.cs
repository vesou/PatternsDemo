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
            Drink drink = new Espresso();
            Assert.AreEqual(_message1, drink.ToString());
        }
        
        [Test]
        public void SimpleDrinkWithChocolate()
        {
            Drink drink = new Espresso();
            drink = new Chocolate(drink);
            Assert.AreEqual(_message2, drink.ToString());
        }
        
        [Test]
        public void SimpleDrinkWithExtras()
        {
            Drink drink = new Decaf();
            drink = new Chocolate(drink);
            drink = new SoyMilk(drink);
            Assert.AreEqual(_message3, drink.ToString());
        }
        
        [Test]
        public void DrinkWithTimer()
        {
            Drink drink = new Decaf();
            drink = new Chocolate(drink);
            drink = new Timer(drink);
            // drink = new SoyMilk(drink);
            // drink = new Timer(drink);
            Assert.AreEqual("", drink.ToString());
        }
        
        
        
        
        
        
        
        
        
        
        
        
        private string _message1 = "Small but mighty drink costs 1.99";
        private string _message2 = "Small but mighty drink + Chocolate costs 2.29";
        private string _message3 = "Decaffeinated drink + Chocolate + SoyMilk costs 3.09";
    }
}