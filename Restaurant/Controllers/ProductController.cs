using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Repositry;

namespace Restaurant.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepositry productRepo;
        private readonly ICategoryRepositry catRepo;
        private readonly IIngrediantRepository ingRepo;

        public ProductController( IProductRepositry productRepo , ICategoryRepositry catRepo , IIngrediantRepository ingRepo )
        {
            this.productRepo = productRepo;
            this.catRepo = catRepo;
            this.ingRepo = ingRepo;
        }
        public IActionResult Index()
        {
            List<Product> products = productRepo.GetAll();
            return View(products);
        }
        public IActionResult AddNew()
        {
            ViewBag.Categories = catRepo.GetAll();
            ViewBag.Ingredients = ingRepo.GetAll();
            return View(new Product());
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult SaveNew(Product product) 
        {
            if (ModelState.IsValid) {
                try
                {
                    productRepo.AddNew(product);
                    return RedirectToAction("Index");
                }catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message.ToString());
                }
            }
            return View("AddNew", product);
        }
        public IActionResult Edit(int id) {
            ViewBag.Categories = catRepo.GetAll();
            ViewBag.Ingredients = ingRepo.GetAll();
            Product product = productRepo.GetById(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id,Product product) {
          
                    productRepo.Update(id, product);
                    return RedirectToAction("Index");
         
            
        }
    }
    
}
