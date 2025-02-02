using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Repositry
{
    public class CategoryRepositry : ICategoryRepositry
    {
        private readonly ApplicationDbContext context;

        public CategoryRepositry(ApplicationDbContext context )
        {
            this.context = context;
        }

        public void AddNew(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }

        public Category GetById(int id)
        {
            Category category = context.Categories.FirstOrDefault(p => p.CategoryId == id);
            return category;
        }

        public void Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
