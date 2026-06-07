using Microsoft.AspNetCore.Mvc;
using HarishPortfolio.Models;

namespace HarishPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = new PortfolioData();
            return View(data);
        }
    }
}
