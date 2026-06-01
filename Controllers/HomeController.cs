using Microsoft.AspNetCore.Mvc;
using PortfolioWeb.Models;
using PortfolioWeb.Services;
using System.Diagnostics;

namespace PortfolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public HomeController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var data = _portfolioService.GetPortfolioData();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
