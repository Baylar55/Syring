using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyrianProject.DAL;
using SyrianProject.ViewModels.FindADoctor;

namespace SyrianProject.Controllers
{
    public class FindADoctorController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public FindADoctorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var doctorComponents = await _appDbContext.DoctorComponents.ToListAsync();
            var model = new FindADoctorIndexViewModel
            {
                DoctorComponents = doctorComponents
            };
            return View(model);
        }
    }
}
