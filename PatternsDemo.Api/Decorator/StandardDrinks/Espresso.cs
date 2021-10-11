namespace PatternsDemo.Api.Decorator
{
    public class Espresso : Coffee
    {
        public Espresso()
        {
            Description = "Small but mighty drink";
        }

        public override double Price()
        {
            return 1.99;
        }
    }
}