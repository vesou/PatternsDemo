using System;

namespace PatternsDemo.Api.SimpleFactory.Pizzas
{
    public class Meat : Pizza
    {
        public override void Cook()
        {
            Console.WriteLine("cooking pizza with lots of meat.");
        }
    }
}