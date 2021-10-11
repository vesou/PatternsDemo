using System;

namespace PatternsDemo.Api.Decorator
{
    public class DecoratorMain
    {
        public void Start()
        {
            Drink drink = new Espresso();
            Console.WriteLine(drink);

            drink = new Chocolate(drink);
            drink = new Cream(drink);
            Console.WriteLine(drink);
        }
    }
}