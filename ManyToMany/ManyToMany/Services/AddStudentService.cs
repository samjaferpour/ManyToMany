using ManyToMany.Dtos;
using ManyToMany.Entities;
using ManyToMany.Repositories;

namespace ManyToMany.Services
{
    public class AddStudentService
    {
        private readonly StudentRepository _studentRepository;
        private readonly UnitOfWork _unitOfWork;

        public AddStudentService(StudentRepository studentRepository, UnitOfWork unitOfWork)
        {
            this._studentRepository = studentRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Execute(AddStudentRequest request)
        {
            var student = new Student
            {
                Name = request.Name,
            };
            _studentRepository.Insert(student);
            _unitOfWork.CommitChanges();
        }
    }
}
