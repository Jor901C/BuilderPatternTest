namespace BuilderPatternTest
{
    public class Burger
    {
        public bool Cheese { get; set; }
        public bool Bacon { get; set; }
        public bool Pickles { get; set; }
        public bool Letuce { get; set; }
        public bool Tomato { get; set; }
        public override string ToString()
        {
            return $"<<<Burger composition:\n\nCheese:{Cheese}\nBacon:{Bacon}\nPickles:{Pickles}\nLetuce:{Letuce}\nTomato:{Tomato}\n\n\n";
        }



    }
}
