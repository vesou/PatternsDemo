using System;

namespace PatternsDemo.Api.SimpleFactory.PizzasWithFactory
{
    public class Veggie2 : Pizza2
    {
        public Veggie2()
        {
            PizzaType = "veggie";
        }
        
        public override void Cook()
        {
            Console.WriteLine("cooking veggie pizza.");
        }
    }
}