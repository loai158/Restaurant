using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Restaurant.Models
{
    public class Ingrediant
    {
        public int IngrediantId { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public List<ProductIngrediant>? ProductIngrediants { get; set; }

    }
}