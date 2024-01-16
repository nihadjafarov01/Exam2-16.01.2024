using Exam21.Core.Models;
using Exam21.Core.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace Exam21.Business.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        DbSet<T> Table { get; }
        IQueryable<T> GetAll(bool noTracking = true);
    }
}
