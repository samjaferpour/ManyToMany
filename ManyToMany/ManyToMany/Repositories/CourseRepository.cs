using ManyToMany.Dtos;
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
        public IEnumerable<Course> GetAll()
        {
            var courses = _context.Courses.ToList();
            return courses;
        }
        public Course GetById(int id)
        {
            var courses = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return courses;
        }
    }
}
