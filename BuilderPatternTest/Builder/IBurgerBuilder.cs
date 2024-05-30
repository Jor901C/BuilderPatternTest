namespace BuilderPatternTest.Builder
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder BuildCheese();
        IBurgerBuilder BuildBacon();
        IBurgerBuilder BuildPickles();
        IBurgerBuilder BuildLetuce();
        IBurgerBuilder BuildTomato();
        Burger GetBurger();

    }
}
