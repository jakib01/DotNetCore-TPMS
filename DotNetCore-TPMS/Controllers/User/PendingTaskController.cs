using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_TPMS.Controllers.User
{
    public class PendingTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
