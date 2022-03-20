using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreDeneme.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository cr = new CategoryRepository();
        public IActionResult Index()
        {
            return View(cr.ListCategory());
        }
    }
}
