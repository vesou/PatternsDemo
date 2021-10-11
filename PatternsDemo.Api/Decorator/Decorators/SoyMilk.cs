namespace PatternsDemo.Api.Decorator
{
    public class SoyMilk : Decorator
    {
        public SoyMilk(Drink drink) : base(drink)
        {
        }

        public override string GetDescription() => Drink.GetDescription() + " + SoyMilk";

        public override double Price() => Drink.Price() + 0.30;
    }
}