namespace PatternsDemo.Api.Decorator
{
    public class Decaf : Coffee
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