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
        public List<int> CourseIds(int studentId)
        {
            var studentCourses = _context.Studentourses.Where(x => x.StudentId == studentId).ToList();
            var responses = new List<int>();
            foreach (var item in studentCourses)
            {
                responses.Add(item.CourseId);
            }
            return responses;
        }
    }
}
