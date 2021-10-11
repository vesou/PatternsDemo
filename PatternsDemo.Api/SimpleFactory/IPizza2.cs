namespace PatternsDemo.Api.SimpleFactory
{
    public interface IPizza2
    {
        string PizzaType { get; set; }
        void Prep();
        void Cook();
        void Slice();
        void Pack();
    }
}