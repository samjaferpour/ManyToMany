using ManyToMany.Entities;

namespace ManyToMany.Repositories
{
    public class StudentCourseRepository
    {
        private readonly ManyToManyDbContext _context;

        public StudentCourseRepository(ManyToManyDbContext context)
        {
            this._context = context;
        }
        public void Insert(StudentCourse studentCourse)
        {
            _context.Studentourses.Add(studentCourse);
        }
    }
}
