using Exam21.Business.Repositories.Interfaces;
using Exam21.Core.Models;
using Exam21.DAL.Contexts;

namespace Exam21.Business.Repositories.Implements
{
    public class PortfolioRepository : GenericRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(Exam21DbContext context) : base(context)
        {
        }
    }
}
