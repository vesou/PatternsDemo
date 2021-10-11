namespace PatternsDemo.Api.Decorator
{
    public abstract class Decorator : Coffee
    {
        protected readonly Coffee Coffee;

        protected Decorator(Coffee coffee)
        {
            Coffee = coffee;
        }
        
        public abstract override string GetDescription();
    }
}