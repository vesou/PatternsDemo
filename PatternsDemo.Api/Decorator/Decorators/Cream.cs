namespace PatternsDemo.Api.Decorator
{
    public class Cream : Decorator
    {
        private readonly Drink _drink;

        public Cream(Drink drink)
        {
            _drink = drink;
        }

        public override string GetDescription() => _drink.GetDescription() + ", Cream";

        public override double Price() => _drink.Price() + 0.20;
    }
}