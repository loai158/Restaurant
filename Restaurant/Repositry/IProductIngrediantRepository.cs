using Restaurant.Models;

namespace Restaurant.Repositry
{

    public interface IProductIngrediantRepository
    {
        public List<ProductIngrediant> GetAll();
        public ProductIngrediant GetById(int id);
        public void AddNew(ProductIngrediant productIngrediant);

        public void Update(int id, ProductIngrediant productIngrediant);
        public void Delete(int id);
        public List<ProductIngrediant> GetProductByIngrediantId(int IngrediantId);

    }
}

