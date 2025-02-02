using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Repositry;

namespace Restaurant.Controllers
{
    public class IngrediantController : Controller
    {

        IIngrediantRepository _IngrediantRepo;

        public IProductRepositry ProductRepo { get; }

        private readonly IProductIngrediantRepository piRepo;

        public IngrediantController(IProductIngrediantRepository productIngrediantRepo, IIngrediantRepository IngrediantRepo, IProductRepositry ProductRepo)
        {
            this._IngrediantRepo = IngrediantRepo;
            this.ProductRepo = ProductRepo;
            this.piRepo = productIngrediantRepo;
        }
        public IActionResult Index()
        {
            return View(_IngrediantRepo.GetAll());
        }
        public IActionResult Details(int id)
        {
            //ViewBag.products  = piRepo.GetAll().Where(e => e.IngrediantId == id).ToList();
            return View (piRepo.GetProductByIngrediantId(id));
            //var Products = _IngrediantRepo.GetProductByIngrediantId(id);
            //return View(Products);
        }
        //Create 
        [HttpGet]
        public IActionResult Create() { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("IngrediantId,Name")] Ingrediant ingrediant)
        {
            if (ModelState.IsValid)
            {
                // Save user to database
                _IngrediantRepo.AddNew(ingrediant);
                return RedirectToAction("Index");
            }
            return View(ingrediant);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Ingrediant ingrediant = _IngrediantRepo.GetById(id);
            return View(ingrediant);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Edit(int id , Ingrediant ingrediant)
        {
            _IngrediantRepo.Update(id, ingrediant);
            return RedirectToAction("Index");
        }
        //Delete
        [HttpGet]
        public IActionResult Delete(int id) { 
            Ingrediant ingrediant = _IngrediantRepo.GetById(id);
            return View(ingrediant);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Delete(Ingrediant ingrediant )
        {
            _IngrediantRepo.Delete(ingrediant.IngrediantId);
            return RedirectToAction("Index");
        }


    }
}
