using GraduateProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraduateProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly GraduateProjectDbContext _context;

        public ProfileController(GraduateProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var profiles = await _context.Profile.ToListAsync();
            return View(profiles);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile.Where(p => p.Id == id).SingleOrDefaultAsync();

            if (profile == null) {
                return NotFound();
            }

            return View(profile);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Profile profile)
        {
            if (ModelState.IsValid) 
            {
                _context.Profile.Add(profile);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile.Where(p => p.Id == id).SingleOrDefaultAsync();

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Profile profile)
        {
            if (ModelState.IsValid) {
                _context.Profile.Update(profile);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.Profile.Where(p => p.Id == id).SingleOrDefaultAsync();

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Profile profile)
        {
            if (ModelState.IsValid)
            {
                _context.Profile.Remove(profile);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(profile);
        }
        public IActionResult ProfileViewIndex()
        {
            var profile = new ProfileViewModel();

            return View(profile);
        }
    }
}
