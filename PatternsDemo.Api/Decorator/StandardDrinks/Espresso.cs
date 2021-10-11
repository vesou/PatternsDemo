namespace PatternsDemo.Api.Decorator
{
    public class Espresso : Drink
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