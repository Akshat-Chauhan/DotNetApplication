using DotNetApplication.Data;
using DotNetApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
            ///1:50:00
        }
    }
}
