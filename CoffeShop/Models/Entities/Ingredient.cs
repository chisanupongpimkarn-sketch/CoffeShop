using System.ComponentModel.DataAnnotations;

namespace CoffeShop.Models.Entities
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Unit { get; set; } = string.Empty;
        // g, ml, ใบ
        public decimal CostPerUnit { get; set; } // ต้นทุนต่อหน่วย
        public decimal StockQty { get; set; }
        // คงเหลือ
        public decimal ReorderLevel { get; set; } // จุดสั่งซื้อ
        public bool IsActive { get; set; } = true;
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
