using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Repositry
{
    public class ProductIngrediantRepositry : IProductIngrediantRepository
    {
        private readonly ApplicationDbContext context;

        public ProductIngrediantRepositry(ApplicationDbContext Db )
        {
            context = Db;
        }
        public void AddNew(ProductIngrediant productIngrediant)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductIngrediant> GetAll()
        {
            List<ProductIngrediant> productIngrediants = context.ProductIngrediants.ToList();
            return productIngrediants;
        }

        public ProductIngrediant GetById(int id)
        {
            ProductIngrediant productIngrediant = context.ProductIngrediants.FirstOrDefault(e=>e.IngrediantId == id);
            return productIngrediant;

         }

        public List<ProductIngrediant> GetProductByIngrediantId(int IngrediantId)
        {


            var result = context.ProductIngrediants.Include(p=>p.Product).Where(e=>e.IngrediantId==IngrediantId).ToList();
            return result;
            //throw new NotImplementedException();
        }

        public void Update(int id, ProductIngrediant productIngrediant)
        {
            throw new NotImplementedException();
        }
    }
}
