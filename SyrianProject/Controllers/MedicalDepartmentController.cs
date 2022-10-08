using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyrianProject.DAL;
using SyrianProject.ViewModels.MedicalDepartment;

namespace SyrianProject.Controllers
{
    public class MedicalDepartmentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public MedicalDepartmentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var departmentComponents = await _appDbContext.DepartmentComponents.ToListAsync();
            var model = new MedicalDepartmentIndexViewModel
            {
                DepartmentComponents = departmentComponents
            };
            return View(model);
        }
    }
}
