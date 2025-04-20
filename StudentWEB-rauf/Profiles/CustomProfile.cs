using AutoMapper;
using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Course,CourseDTO>().ReverseMap();
            CreateMap<Teacher,TeacherDTO>().ReverseMap();
            CreateMap<Student,StudentDTO>().ReverseMap();
            CreateMap<CourseModule, CourseModuleDTO>().ReverseMap();
        }
    }
}
