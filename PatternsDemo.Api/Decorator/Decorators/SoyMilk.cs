namespace PatternsDemo.Api.Decorator
{
    public class SoyMilk : Decorator
    {
        private readonly Drink _drink;

        public SoyMilk(Drink drink)
        {
            _drink = drink;
        }

        public override string GetDescription() => _drink.GetDescription() + ", SoyMilk";

        public override double Price() => _drink.Price() + 0.50;
    }
}