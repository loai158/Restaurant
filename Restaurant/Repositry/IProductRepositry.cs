using Restaurant.Models;

namespace Restaurant.Repositry
{
    public interface IProductRepositry
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void AddNew(Product product);

        public void Update(int id, Product product);
        public void Delete(int id);
        public List<Product> GetProductByIngrediantId(int ProductId);
    }
}
