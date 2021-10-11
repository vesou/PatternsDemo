using PatternsDemo.Api.SimpleFactory.Pizzas;

namespace PatternsDemo.Api.SimpleFactory
{
    public static class PizzaOrder
    {
        public static IPizza OrderPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "simple": return new Margarita();
                case "meat": return new Meat();
                case "veggie": return new Meat();
                default: return new Margarita();
            }
        }
    }
}