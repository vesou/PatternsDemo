namespace PatternsDemo.Api.Decorator
{
    public class Special : Coffee
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