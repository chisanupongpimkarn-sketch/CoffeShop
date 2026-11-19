namespace CoffeShop.Models.Entities
{
    public class Recipe
    {
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public decimal Quantity { get; set; }
        // ปริมาณต่อ 1 แก้ว
        public Product Product { get; set; } = null!;
        public Ingredient Ingredient { get; set; } = null!;
    }
}
