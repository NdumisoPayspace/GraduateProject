using Microsoft.AspNetCore.Mvc;

namespace GraduateProject.Controllers
{
    public class NduController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
