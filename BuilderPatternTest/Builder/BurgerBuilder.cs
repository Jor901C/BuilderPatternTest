namespace BuilderPatternTest.Builder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private readonly Burger _burger;
        public BurgerBuilder(Burger burger)
        {
            _burger = burger;
        }
        public IBurgerBuilder BuildBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public IBurgerBuilder BuildCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public IBurgerBuilder BuildLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public IBurgerBuilder BuildPickles()

        {
            _burger.Pickles = true;
            return this;
        }

        public IBurgerBuilder BuildTomato()
        {
            _burger.Letuce = true;
            return this;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;
            return burger;
        }
    }
}
