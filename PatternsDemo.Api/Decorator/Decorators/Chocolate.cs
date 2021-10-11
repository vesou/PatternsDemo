namespace PatternsDemo.Api.Decorator
{
    public class Chocolate : Decorator
    {
        public Chocolate(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription() => Coffee.GetDescription() + " + Chocolate";

        public override double Price() => Coffee.Price() + 0.30;
    }
}