using System.Diagnostics;

namespace PatternsDemo.Api.Decorator
{
    public class Timer : Decorator
    {
        public Timer(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var description = Coffee.GetDescription();
            sw.Stop();
            
            return $"{description}, takes {sw.ElapsedTicks} ticks";
        }

        public override double Price() => Coffee.Price();
    }
}