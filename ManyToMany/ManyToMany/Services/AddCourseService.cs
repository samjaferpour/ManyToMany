using ManyToMany.Dtos;
using ManyToMany.Entities;
using ManyToMany.Repositories;

namespace ManyToMany.Services
{
    public class AddCourseService
    {
        private readonly CourseRepository _courseRepository;
        private readonly UnitOfWork _unitOfWork;

        public AddCourseService(CourseRepository courseRepository, UnitOfWork unitOfWork)
        {
            this._courseRepository = courseRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Execute(AddCourseRequest request)
        {
            var course = new Course
            {
                Name = request.Name,
            };
            _courseRepository.Insert(course);
            _unitOfWork.CommitChanges();
        }
    }
}
