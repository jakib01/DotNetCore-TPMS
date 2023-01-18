using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_TPMS.Controllers.User
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
