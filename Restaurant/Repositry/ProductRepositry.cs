using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Repositry
{
    public class ProductRepositry : IProductRepositry
    {
        ApplicationDbContext context;

        public ProductRepositry(ApplicationDbContext Db)
        {
            context = Db;
        }

        public void AddNew(Product product)
        {

            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }

        public Product GetById(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }

        public List<Product> GetProductByIngrediantId(int ProductId)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product product)
        {
            Product old = GetById(id);
            old.Name = product.Name;
            old.Description = product.Description;
            old.Price = product.Price;
            old.Stock = product.Stock;
            old.ImageUrl = product.ImageUrl;
            context.SaveChanges();
        }
    }
}
