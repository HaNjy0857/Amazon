using Amazon.DataAccess.Data;
using Amazon.DataAccess.Repository.IRepository;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public IActionResult Index()
        {
            List<Category> obj = _categoryRepo.GetAll().ToList();
            return View(obj);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if(ModelState.IsValid)
            {
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            var result = _categoryRepo.Get(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        } 
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Update(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
		}
		public IActionResult Delete(int? id)
		{
			var result = _categoryRepo.Get(x => x.Id == id);
			if (result == null)
			{
				return NotFound();
			}
			return View(result);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePost(int? id)
		{
            Category? obj = _categoryRepo.Get(x => x.Id == id);
            if(obj == null)
            {
                return NotFound();
            }
            _categoryRepo.Remove(obj);
            _categoryRepo.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
		}
	}
}
