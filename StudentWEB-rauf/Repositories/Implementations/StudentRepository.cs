using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.data;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Student> CreateStudentAsync(Student student)
        {
            await _appDbContext.Students.AddAsync(student);
            await _appDbContext.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var datas = await _appDbContext.Students.ToListAsync();
            return datas;
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var data = await _appDbContext.Students.FindAsync(id);
            return data;
        }

        public async void UpdateStudentAsync(Student student)
        {
            _appDbContext.Students.Update(student);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
