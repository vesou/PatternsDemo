using System;

namespace PatternsDemo.Api.SimpleFactory.PizzasWithFactory
{
    public class Margarita2 : Pizza2
    {
        public Margarita2()
        {
            PizzaType = "simple";
        }
        
        public override void Cook()
        {
            Console.WriteLine("cooking Margarita");
        }
    }
}