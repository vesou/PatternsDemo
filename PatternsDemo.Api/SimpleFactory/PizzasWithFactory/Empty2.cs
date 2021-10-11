using System;

namespace PatternsDemo.Api.SimpleFactory.PizzasWithFactory
{
    public class Empty2 : Pizza2
    {
        public Empty2()
        {
            PizzaType = "";
        }
        
        public override void Cook()
        {
            Console.WriteLine("no need to cook you get it frozen");
        }
    }
}