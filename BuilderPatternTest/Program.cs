using BuilderPatternTest.Builder;

namespace BuilderPatternTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burger order = new Burger();
            BurgerBuilder builder = new BurgerBuilder(order);
            Cook cook = new Cook(builder);
            cook.CookBigMac();
            var report = builder.GetBurger();
            Console.WriteLine(report);
            cook.CookCheeseBurger();
            report = builder.GetBurger();
            Console.WriteLine(report);

        }
    }
}
