using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.data;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Repositories.Implementations
{
    public class CourseModuleRepository : ICourseModuleRepository
    {
        private readonly AppDbContext _appDbContext;

        public CourseModuleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CourseModule> CreateModuleAsync(CourseModule courseModule)
        {
            await _appDbContext.Modules.AddAsync(courseModule);
            return courseModule;
        }

        public async Task<List<CourseModule>> GetAllModulesAsync()
        {
            var datas = await _appDbContext.Modules.ToListAsync();
            return datas;
        }

        public async Task<CourseModule> GetModuleByIdAync(int id)
        {
            return await _appDbContext.Modules.FindAsync(id);
         }

        public async void UpdateModuleAync(CourseModule courseModule)
        {
             _appDbContext.Modules.Update(courseModule);
            _appDbContext.SaveChangesAsync();
        }
    }
}
