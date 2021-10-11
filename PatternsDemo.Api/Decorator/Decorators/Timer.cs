using System.Diagnostics;

namespace PatternsDemo.Api.Decorator
{
    public class Timer : Decorator
    {
        public Timer(Drink drink) : base(drink)
        {
        }

        public override string GetDescription()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var description = Drink.GetDescription();
            sw.Stop();
            
            return $"{description}, takes {sw.ElapsedTicks} ticks";
        }

        public override double Price() => Drink.Price();
    }
}