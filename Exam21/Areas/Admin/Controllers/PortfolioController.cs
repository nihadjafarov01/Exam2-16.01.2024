using Exam21.Business.Repositories.Implements;
using Exam21.Business.Repositories.Interfaces;
using Exam21.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Exam21.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        IPortfolioService _service {  get; }

        public PortfolioController(IPortfolioService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll().ToList();
            return View(data);
        }
    }
}
