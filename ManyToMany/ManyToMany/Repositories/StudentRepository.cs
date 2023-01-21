using ManyToMany.Entities;

namespace ManyToMany.Repositories
{
    public class StudentRepository
    {
        private readonly ManyToManyDbContext _context;

        public StudentRepository(ManyToManyDbContext context)
        {
            this._context = context;
        }
        public void Insert(Student student)
        {
            _context.Students.Add(student);
        }

    }
}
