using Restaurant.Models;

namespace Restaurant.Repositry
{

    public interface IIngrediantRepository
    {
        public List<Ingrediant> GetAll();
        public Ingrediant GetById(int id);
        public void AddNew(Ingrediant ingrediant);

        public void Update(int id, Ingrediant ingrediant);
        public void Delete(int id);
        public List<Product> GetProductByIngrediantId(int IngrediantId);

    }
}

