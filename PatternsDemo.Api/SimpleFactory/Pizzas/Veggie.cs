using System;

namespace PatternsDemo.Api.SimpleFactory.Pizzas
{
    public class Veggie : Pizza
    {
        public override void Cook()
        {
            Console.WriteLine("cooking veggie pizza.");
        }
    }
}