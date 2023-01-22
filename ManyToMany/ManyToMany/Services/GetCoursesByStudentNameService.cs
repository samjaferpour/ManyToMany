using ManyToMany.Dtos;
using ManyToMany.Entities;
using ManyToMany.Repositories;

namespace ManyToMany.Services
{
    public class GetCoursesByStudentNameService
    {
        private readonly StudentRepository _studentRepository;
        private readonly CourseRepository _courseRepository;
        private readonly StudentCourseRepository _studentCourseRepository;

        public GetCoursesByStudentNameService(StudentRepository studentRepository, CourseRepository courseRepository, StudentCourseRepository studentCourseRepository)
        {
            this._studentRepository = studentRepository;
            this._courseRepository = courseRepository;
            this._studentCourseRepository = studentCourseRepository;
        }
        public List<GetCoursesByStudentNameResponse> Execute(GetCoursesByStudentNameRequest request)
        {
            //گرفتن یک دانشجو
            var student = _studentRepository.FindByName(request.Name);

            //گرفتن لیست آیدی کورس های دانشجو
            var courseIds = _studentCourseRepository.CourseIds(student.Id);

            //گرفتن تمام کورس ها با آیدی های آنها
            var courses = new List<Course>();
            foreach (var item in courseIds)
            {
                courses.Add(_courseRepository.GetById(item));
            }
            var responses = new List<GetCoursesByStudentNameResponse>();
            foreach (var course in courses)
            {
                responses.Add(new GetCoursesByStudentNameResponse { Id = course.Id, CourseName = course.Name });
            }
            return responses;
        }
    }
}
