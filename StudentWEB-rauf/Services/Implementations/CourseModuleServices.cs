using AutoMapper;
using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Services.Implementations
{
    public class CourseModuleServices : ICourseModuleServices
    {
        private readonly ICourseModuleRepository _courseModuleRepository;
        private readonly IMapper _mapper;

        public CourseModuleServices(ICourseModuleRepository courseModuleRepository, IMapper mapper)
        {
            _courseModuleRepository = courseModuleRepository;
            _mapper = mapper;
        }

        public async Task<CourseModuleDTO> CreateModuleAsync(CourseModuleDTO courseModuleDTO)
        {
            var inputData = _mapper.Map<CourseModule>(courseModuleDTO);
            var outputInput = await _courseModuleRepository.CreateModuleAsync(inputData);
            var dto = _mapper.Map<CourseModuleDTO>(outputInput);
            return dto;
        }

        public async Task<List<CourseModuleDTO>> GetAllModulesAsync()
        {
            var datas = await _courseModuleRepository.GetAllModulesAsync();
            var dto = _mapper.Map<List<CourseModuleDTO>>(datas);
            return dto;
        }

        public async Task<CourseModuleDTO> GetModuleByIdAync(int id)
        {
            var data = await _courseModuleRepository.GetModuleByIdAync(id);
            var dto = _mapper.Map<CourseModuleDTO>(data);
            return dto;
        }

        public async void UpdateModuleAync(CourseModuleDTO courseModuleDTO,int id)
        {
            var data = await _courseModuleRepository.GetModuleByIdAync(id);
            if (data is not null)
            {
               var item = _mapper.Map<CourseModule>(courseModuleDTO);
                _courseModuleRepository.UpdateModuleAync(item);

            }
        }
    }
}
