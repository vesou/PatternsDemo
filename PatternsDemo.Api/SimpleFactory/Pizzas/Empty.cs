using System;

namespace PatternsDemo.Api.SimpleFactory.Pizzas
{
    public class Empty : Pizza
    {
        public override void Cook()
        {
            Console.WriteLine("no need to cook you get it frozen");
        }
    }
}