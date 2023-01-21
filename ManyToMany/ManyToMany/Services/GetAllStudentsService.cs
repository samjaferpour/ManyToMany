using ManyToMany.Dtos;
using ManyToMany.Repositories;

namespace ManyToMany.Services
{
    public class GetAllStudentsService
    {
        private readonly StudentRepository _studentRepository;

        public GetAllStudentsService(StudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        public IEnumerable<GetAllStudentsRequest> Execute()
        {
            var students = _studentRepository.GetAll();
            var responses = new List<GetAllStudentsRequest>();
            foreach (var item in students)
            {
                responses.Add(new GetAllStudentsRequest {Id = item.Id, Name= item.Name });
            }
            return responses;
        }
    }
}
