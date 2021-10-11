namespace PatternsDemo.Api.Decorator
{
    public class Cream : Decorator
    {
        public Cream(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription() => Coffee.GetDescription() + " + Cream";

        public override double Price() => Coffee.Price() + 0.30;
    }
}