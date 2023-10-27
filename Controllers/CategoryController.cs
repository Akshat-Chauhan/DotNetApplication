    using Microsoft.AspNetCore.Mvc;

namespace DotNetApplication.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
