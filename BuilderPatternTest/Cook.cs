using BuilderPatternTest.Builder;

namespace BuilderPatternTest
{
    public class Cook
    {
        private readonly BurgerBuilder _burgerBuilder;
        public Cook(BurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void CookCheeseBurger()
        {
            _burgerBuilder
                .BuildCheese()
                .BuildTomato()
                .BuildLetuce();
        }
        public void CookBigMac()
        {
            _burgerBuilder
                .BuildBacon()
                .BuildTomato()
                .BuildCheese()
                .BuildLetuce()
                .BuildPickles();
        }
    }
}
