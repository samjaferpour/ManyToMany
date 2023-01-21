using ManyToMany.Dtos;
using ManyToMany.Entities;
using ManyToMany.Repositories;
using Microsoft.Identity.Client;

namespace ManyToMany.Services
{
    public class SelectUnitService
    {
        private readonly StudentRepository _studentRepository;
        private readonly CourseRepository _courseRepository;
        private readonly UnitOfWork _unitOfWork;

        public SelectUnitService(StudentRepository studentRepository, CourseRepository courseRepository, UnitOfWork unitOfWork) 
        {
            this._studentRepository = studentRepository;
            this._courseRepository = courseRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Execute(SelectCoursesRequest request)
        {
            var student = new Student
            {
                Name = request.Student.Name,
            };
            
            var stusentCourses = new List<StudentCourse>();
            foreach (var course in request.Courses)
            {
                //var c = new StudentCourse
                //{
                //    Student = student,
                //    CourseId = course.Id
                //};
                //stusentCourses.Add(c);
                stusentCourses.Add(new StudentCourse {Student = student, CourseId = course.Id });
            }
            student.StudentCourses = stusentCourses;

            _studentRepository.Insert(student);

            _unitOfWork.CommitChanges();
        }
    }
}
