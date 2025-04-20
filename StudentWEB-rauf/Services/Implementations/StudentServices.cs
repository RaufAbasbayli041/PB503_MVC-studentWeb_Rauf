using AutoMapper;
using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;
using StudentWEB_rauf.Services.Interfaces;
using System.Threading.Tasks;

namespace StudentWEB_rauf.Services.Implementations
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentServices(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDTO> CreateStudentAsync(StudentDTO studentDTO)
        {
            var inputData = _mapper.Map<Student>(studentDTO);
            var outputData = await _studentRepository.CreateStudentAsync(inputData);
            var dto = _mapper.Map<StudentDTO>(outputData);
            return dto;
        }

        public async Task<List<StudentDTO>> GetAllStudentsAsync()
        {
            var datas = await _studentRepository.GetAllStudentsAsync();
            var dto = _mapper.Map<List<StudentDTO>>(datas);
            return dto;

        }

        public async Task<StudentDTO> GetStudentByIdAsync(int id)
        {
            var data = await _studentRepository.GetStudentByIdAsync(id);
            var dto = _mapper.Map<StudentDTO>(data);
            return dto;

        }

        public async void UpdateStudentAsync(StudentDTO studentDTO, int id)
        {
            var item = await _studentRepository.GetStudentByIdAsync(id);
            if (item is not null)
            {
               var data = _mapper.Map<Student>(studentDTO);
                _studentRepository.UpdateStudentAsync(data);


            }
        }

       
    }
}
