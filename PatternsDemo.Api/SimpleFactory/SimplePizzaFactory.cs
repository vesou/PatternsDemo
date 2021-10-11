using System.Collections.Generic;
using System.Linq;
using PatternsDemo.Api.SimpleFactory.Pizzas;
using PatternsDemo.Api.SimpleFactory.PizzasWithFactory;

namespace PatternsDemo.Api.SimpleFactory
{
    public class SimplePizzaFactory
    {
        private readonly List<IPizza2> _pizzas = new()
        {
            new Margarita2(),
            new Meat2(),
            new Veggie2(),
            new Empty2()
        };
        
        public IPizza2 OrderPizza(string pizzaType)
        {
            return _pizzas.First(p => p.PizzaType == pizzaType);
        }
        
        public IPizza2 OrderPizza2(string pizzaType)
        {
            var pizza = _pizzas.FirstOrDefault(p => p.PizzaType == pizzaType);
            return pizza ?? new Empty2();
        }
    }
}