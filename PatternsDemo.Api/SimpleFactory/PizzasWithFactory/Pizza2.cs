using System;

namespace PatternsDemo.Api.SimpleFactory.PizzasWithFactory
{
    public abstract class Pizza2 : IPizza2
    {
        public string PizzaType { get; set; }

        public virtual void Prep()
        {
            Console.WriteLine("preparing...");
        }

        public virtual void Cook()
        {
            Console.WriteLine("cooking...");
        }

        public virtual void Slice()
        {
            Console.WriteLine("slicing...");
        }

        public virtual void Pack()
        {
            Console.WriteLine("packing...");
        }
    }
}