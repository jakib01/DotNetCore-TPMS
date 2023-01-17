using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_TPMS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
