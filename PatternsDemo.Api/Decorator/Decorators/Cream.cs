namespace PatternsDemo.Api.Decorator
{
    public class Cream : Decorator
    {
        public Cream(Drink drink) : base(drink)
        {
        }

        public override string GetDescription() => Drink.GetDescription() + ", Cream";

        public override double Price() => Drink.Price() + 0.30;
    }
}