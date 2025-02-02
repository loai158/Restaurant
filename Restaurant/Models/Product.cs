using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int Stock { set; get; }
        public int CatgoryId { set; get; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [ValidateNever]
        public Category? Category { get; set; }
        [ValidateNever]
        public List<OrderItem>? OrderItem { get; set; }
        [ValidateNever]
        public List<ProductIngrediant>? ProductIngrediants { get; set; }
    }
}