using System;
using NUnit.Framework;
using PatternsDemo.Api.Decorator;
using PatternsDemo.Api.SimpleFactory;
using PatternsDemo.Api.SimpleFactory.Pizzas;

namespace PatternsDemo.Tests.Api
{
    public class SimpleFactoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateNewPizza1()
        {
            IPizza pizza = new Margarita();
            pizza.Prep();
            pizza.Cook();
            pizza.Slice();
            pizza.Pack();
        }
        
        [Test]
        public void CreateNewPizzaWithSingleResponsibility()
        {
            IPizza pizza = PizzaOrder.OrderPizza("meat");
            pizza.Prep();
            pizza.Cook();
            pizza.Slice();
            pizza.Pack();
        }
        
        [Test]
        public void CreateNewPizzaWithFactory()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            var pizza = factory.OrderPizza("veggie");
            pizza.Prep();
            pizza.Cook();
            pizza.Slice();
            pizza.Pack();
        }
        
        [Test]
        public void CreateNewPizzaWithFactoryEmpty()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            var pizza = factory.OrderPizza("wrongName");
            // var pizza = factory.OrderPizza2("wrongName");
            pizza.Prep();
            pizza.Cook();
            pizza.Slice();
            pizza.Pack();
        }
        
        /// if you want to extend it with different types of pizzerias you would extend it into abstract factory pattern
        /// and have an italian Factory (that can do all the types), and an AmericanFactory that makes thicker dough
    }
}