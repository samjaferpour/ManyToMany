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
        public IEnumerable<Student> GetAll()
        {
            var students = _context.Students.ToList();
            return students;
        }
        public Student FindByName(string name)
        {
            var student = _context.Students.SingleOrDefault(x => x.Name == name);
            return student;
        }

    }
}
