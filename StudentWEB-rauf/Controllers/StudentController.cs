using Microsoft.AspNetCore.Mvc;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _studentServices.GetAllStudentsAsync();
            return View(data);
        }
    }
}
