namespace PatternsDemo.Api.Decorator
{
    public class Special : Drink
    {
        public Special()
        {
            Description = "House Special";
        }

        public override double Price()
        {
            return 2.99;
        }
    }
}