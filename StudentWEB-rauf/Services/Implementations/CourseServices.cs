using AutoMapper;
using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using StudentWEB_rauf.Services.Interfaces;

namespace StudentWEB_rauf.Services.Implementations
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseServices(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CourseDTO> CreateCourseAsync(CourseDTO courseDto)
        {
            var inputEntity = _mapper.Map<Course>(courseDto);
            var outputEntity = await _courseRepository.CreateCourseAsync(inputEntity);
            var dto = _mapper.Map<CourseDTO>(outputEntity);
            return dto;
        }

        public async Task<List<CourseDTO>> GetAllCourseAsync()
        {
            var items = await _courseRepository.GetAllCourseAsync();
            var dtos = _mapper.Map<List<CourseDTO>>(items);
            return dtos;
        }

        public async Task<CourseDTO> GetCourseByIdAsync(int id)
        {
            var item = await _courseRepository.GetCourseByIdAsync(id);
            var dto = _mapper.Map<CourseDTO>(item);
            return dto;
        }

        public async Task UpdateCourseAsync(CourseDTO courseDto, int id)
        {
            var item = await _courseRepository.GetCourseByIdAsync(id);

            if (item is not null)
            {
                var entity = _mapper.Map<Course>(courseDto);
                _courseRepository.UpdateCourseAsync(entity);

            }
           
        }
    }
}
