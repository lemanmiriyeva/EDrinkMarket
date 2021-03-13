using EDrinkMarket.Entity.Abstract;

namespace EDrinkMarket.Entity.Concrete
{
    public class Drink:IEntity
    {
        public int DrinkId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
    }
}
