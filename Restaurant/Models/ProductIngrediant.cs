using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class ProductIngrediant
    {
        public int ProductId { get; set; }
        public Product? Product { set; get; }
        public int IngrediantId { get; set; }
        public Ingrediant? Ingrediant { set; get; } 
    }
}