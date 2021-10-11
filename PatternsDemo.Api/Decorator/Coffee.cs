namespace PatternsDemo.Api.Decorator
{
    /// <summary>
    /// Timing, Logging
    /// </summary>
    public abstract class Coffee
    {
        public virtual string GetDescription()
        {
            return Description;
        }
        
        public abstract double Price();
        
        protected string Description =  "Unknown drink.";

        public override string ToString()
        {
            return $"{GetDescription()} costs {Price()}";
        }
    }
}