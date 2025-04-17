using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.data;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Repositories.Implementations
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeacherRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Teacher> CreateTeacherAsync(Teacher teacher)
        {
           await _appDbContext.Teachers.AddAsync(teacher);
           await _appDbContext.SaveChangesAsync();
            return teacher;
        }

        public async Task<List<Teacher>> GetAllTeacherAsync()
        {
            var datas = await _appDbContext.Teachers.ToListAsync();
            return datas;
        }

        public async Task<Teacher> GetTeacherByIdAsync(int id)
        {
            var data = await _appDbContext.Teachers.FindAsync(id);
            return data;
        }

        public  async void UpdateTeacherAsync(Teacher teacher)
        {
            _appDbContext.Teachers.Update(teacher);
             _appDbContext.SaveChangesAsync();
        }
    }
}
