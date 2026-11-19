using System.ComponentModel.DataAnnotations;

namespace CoffeShop.Models.Entities
{
    public class Option
    {
        public int OptionId { get; set; }
        public int OptionGroupId { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public decimal ExtraPrice { get; set; }
        // ราคาเพิ่ม
        public bool IsActive { get; set; } = true;
        public OptionGroup OptionGroup { get; set; } = null!;
    }
}
