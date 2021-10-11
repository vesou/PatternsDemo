namespace PatternsDemo.Api.Decorator
{
    public class Chocolate : Decorator
    {
        public Chocolate(Drink drink) : base(drink)
        {
        }

        public override string GetDescription() => Drink.GetDescription() + ", Chocolate";

        public override double Price() => Drink.Price() + 0.30;
    }
}