using Microsoft.AspNetCore.Mvc;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacherServices;

        public TeacherController(ITeacherServices teacherServices)
        {
            _teacherServices = teacherServices;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _teacherServices.GetAllTeacherAsync();
            return View(item);
        }
    }
}
