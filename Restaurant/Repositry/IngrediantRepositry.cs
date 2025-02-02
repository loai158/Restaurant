using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Repositry
{
    public class IngrediantRepositry : IIngrediantRepository
    {
        ApplicationDbContext context;

        public IngrediantRepositry(ApplicationDbContext Db  )
        {
            context = Db;
        }
        public void AddNew(Ingrediant ingrediant)
        {
            context.Ingrediants.Add(ingrediant);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Ingrediant ingrediant = GetById(id);
            context.Ingrediants.Remove(ingrediant);
            context.SaveChanges();
        }

        public List<Ingrediant> GetAll()
        {
            List<Ingrediant> Ingrediants= context.Ingrediants.ToList();
            return Ingrediants;
        }

        public Ingrediant GetById(int id)
        {
            //throw new NotImplementedException();
            var ingrediant = context.Ingrediants.Include(e=>e.ProductIngrediants).FirstOrDefault(i => i.IngrediantId == id);
            return ingrediant;
        }


        public List<Product> GetProductByIngrediantId(int IngrediantId)
        {
            
            List<ProductIngrediant> result = context.ProductIngrediants.Where(e=>e.ProductId == IngrediantId ).ToList();
            List<Product> products = new List<Product>();
            foreach(ProductIngrediant product in result)
            {
                int id= product.ProductId;
                products = context.Products.Where(p=>p.ProductId == id).ToList();
            }
            return products;
            //throw new NotImplementedException();
        }

        public void Update(int id, Ingrediant ingrediant)
        {
            Ingrediant old = GetById(id);
            old.Name = ingrediant.Name;
            context.SaveChanges();
        }

   
    }
}
