using ManyToMany.Entities;

namespace ManyToMany.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly ManyToManyDbContext _context;

        public UnitOfWork(ManyToManyDbContext context)
        {
            this._context = context;
        }
        public void CommitChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
