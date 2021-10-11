namespace PatternsDemo.Api.Decorator
{
    public class Decaf : Drink
    {
        public Decaf()
        {
            Description = "Decaffeinated drink";
        }

        public override double Price()
        {
            return 2.49;
        }
    }
}