using Exam21.Business.Repositories.Interfaces;
using Exam21.Core.Models.Common;
using Exam21.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Exam21.Business.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        Exam21DbContext _context { get; }

        public GenericRepository(Exam21DbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool noTracking = true)
            => noTracking ? Table.AsNoTracking() : Table;
    }
}
