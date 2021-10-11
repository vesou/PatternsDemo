namespace PatternsDemo.Api.Decorator
{
    public class Chocolate : Decorator
    {
        private readonly Drink _drink;

        public Chocolate(Drink drink)
        {
            _drink = drink;
        }

        public override string GetDescription() => _drink.GetDescription() + ", Chocolate";

        public override double Price() => _drink.Price() + 0.30;
    }
}