namespace PatternsDemo.Api.Decorator
{
    public class SoyMilk : Decorator
    {
        public SoyMilk(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription() => Coffee.GetDescription() + " + SoyMilk";

        public override double Price() => Coffee.Price() + 0.30;
    }
}