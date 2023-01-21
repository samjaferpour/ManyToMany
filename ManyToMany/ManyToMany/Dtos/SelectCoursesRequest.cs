using ManyToMany.Entities;

namespace ManyToMany.Dtos
{
    public class SelectCoursesRequest
    {
        public Student Student { get; set; }
        public List<Course> Courses { get; set; }
    }
}
