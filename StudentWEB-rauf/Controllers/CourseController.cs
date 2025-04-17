using Microsoft.AspNetCore.Mvc;
using StudentWEB_rauf.Services.Interfaces;

namespace StudentWEB_rauf.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseServices _courseServices;

        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _courseServices.GetAllCourseAsync();
            return View(items);
        }
    }
}
