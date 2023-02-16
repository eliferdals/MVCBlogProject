using Microsoft.AspNetCore.Mvc;

namespace MVCBlogProject.Controllers
{
    public class WritesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
