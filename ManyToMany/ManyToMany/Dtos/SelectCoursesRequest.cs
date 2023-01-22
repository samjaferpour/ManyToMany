using ManyToMany.Entities;

namespace ManyToMany.Dtos
{
    public class SelectCoursesRequest
    {
        public StudentDto Student { get; set; }
        public List<CourseDto> Courses { get; set; }
    }
    public class StudentDto
    {
        public string Name { get; set; }
    }
    public class CourseDto
    {
        public int Id { get; set; }
    }
}
