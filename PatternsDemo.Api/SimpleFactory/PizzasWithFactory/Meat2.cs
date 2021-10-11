using System;

namespace PatternsDemo.Api.SimpleFactory.PizzasWithFactory
{
    public class Meat2 : Pizza2
    {
        public Meat2()
        {
            PizzaType = "meat";
        }
        
        public override void Cook()
        {
            Console.WriteLine("cooking pizza with lots of meat.");
        }
    }
}