namespace PatternsDemo.Api.SimpleFactory
{
    public interface IPizza
    {
        void Prep();
        void Cook();
        void Slice();
        void Pack();
    }
}