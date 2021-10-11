namespace PatternsDemo.Api.Decorator
{
    public abstract class Decorator : Drink
    {
        protected readonly Drink Drink;

        protected Decorator(Drink drink)
        {
            Drink = drink;
        }
        
        public abstract override string GetDescription();
    }
}