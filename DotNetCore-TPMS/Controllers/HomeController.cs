using DotNetCore_TPMS.Models;
using DotNetCore_TPMS.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCore_TPMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;


        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            this.appDbContext = appDbContext;
        }


        public IActionResult Index()
        {
            var data = this.appDbContext.Users.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}