using AutoMapper;
using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Services.Implementations
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherServices(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<TeacherDTO> CreateTeacherAsync(TeacherDTO teacherDTO)
        {
            var inputData = _mapper.Map<Teacher>(teacherDTO);
            var outputData = await _teacherRepository.CreateTeacherAsync(inputData);
            var dto = _mapper.Map<TeacherDTO>(outputData);
            return dto;
        }

        public async Task<List<TeacherDTO>> GetAllTeacherAsync()
        {
            var datas = await _teacherRepository.GetAllTeacherAsync();
            var dto = _mapper.Map<List<TeacherDTO>>(datas);
            return dto;
        }

        public async Task<TeacherDTO> GetTeacherByIdAsync(int id)
        {
            var data = await _teacherRepository.GetTeacherByIdAsync(id);
            var dto = _mapper.Map<TeacherDTO>(data);
            return dto;
        }

        public async void UpdateTeacherAsync(TeacherDTO teacherDTO , int id)
        {
            var update = await _teacherRepository.GetTeacherByIdAsync(id);
            if (update != null)
            {
                var entity = _mapper.Map<Teacher>(teacherDTO);
                _teacherRepository.UpdateTeacherAsync(entity);
            }
        }
    }
}
