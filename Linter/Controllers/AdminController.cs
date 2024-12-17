using Microsoft.AspNetCore.Mvc;

namespace Linter.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
