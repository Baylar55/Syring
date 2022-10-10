using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyrianProject.DAL;
using SyrianProject.ViewModels.SidebarLeft;

namespace SyrianProject.Controllers
{
    public class SidebarLeftController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SidebarLeftController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _appDbContext.Categories.
                                                        Include(c=>c.CategoryComponents).
                                                        ToListAsync();
            var model = new SidebarLeftIndexViewModel
            {
                Categories=categories
            };
            return View(model);
        }
    }
}
