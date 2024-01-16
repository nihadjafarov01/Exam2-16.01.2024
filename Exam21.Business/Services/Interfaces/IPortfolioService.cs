using Exam21.Core.Models;

namespace Exam21.Business.Services.Interfaces
{
    public interface IPortfolioService
    {
        IQueryable<Portfolio> GetAll(bool noTracking = true);
    }
}
