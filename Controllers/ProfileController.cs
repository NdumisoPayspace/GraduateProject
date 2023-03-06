using GraduateProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduateProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ProfileViewModel();

            return View(profile);
        }
    }
}
