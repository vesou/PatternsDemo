using System;

namespace PatternsDemo.Api.SimpleFactory.Pizzas
{
    public abstract class Pizza : IPizza
    {
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