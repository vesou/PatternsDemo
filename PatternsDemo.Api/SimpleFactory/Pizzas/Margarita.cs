using System;

namespace PatternsDemo.Api.SimpleFactory.Pizzas
{
    public class Margarita : Pizza
    {
        public override void Cook()
        {
            Console.WriteLine("cooking Margarita");
        }
    }
}