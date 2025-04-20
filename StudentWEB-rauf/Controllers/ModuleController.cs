using Microsoft.AspNetCore.Mvc;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Controllers
{
    public class ModuleController : Controller
    {
        private readonly ICourseModuleServices _courseModuleServices;

        public ModuleController(ICourseModuleServices courseModuleServices)
        {
            _courseModuleServices = courseModuleServices;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _courseModuleServices.GetAllModulesAsync();
            return View(item);
        }
    }
}
