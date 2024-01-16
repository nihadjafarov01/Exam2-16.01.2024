using Exam21.Business.Repositories.Interfaces;
using Exam21.Business.Services.Interfaces;
using Exam21.Core.Models;

namespace Exam21.Business.Services.Implements
{
    public class PortfolioService : IPortfolioService
    {
        IPortfolioRepository _repo {  get; }

        public PortfolioService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public IQueryable<Portfolio> GetAll(bool noTracking = true)
            => _repo.GetAll();
    }
}
