using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> CreateStudentAsync(Student student);
        void UpdateStudentAsync(Student student);
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);

    }
}
