using ManyToMany.Entities;

namespace ManyToMany.Repositories
{
    public class CourseRepository
    {
        private readonly ManyToManyDbContext _context;

        public CourseRepository(ManyToManyDbContext context)
        {
            this._context = context;
        }
        public void Insert(Course course)
        {
            _context.Courses.Add(course);
        }
    }
}
