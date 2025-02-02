using Restaurant.Models;

namespace Restaurant.Repositry
{
    public interface ICategoryRepositry
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void AddNew(Category category);

        public void Update(int id, Category category);
        public void Delete(int id);
    }
}
