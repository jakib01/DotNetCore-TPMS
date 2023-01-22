using DotNetCore_TPMS.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_TPMS.Controllers.User
{
    public class PendingTaskController : Controller
    {

        private readonly AppDbContext appDbContext;

        public PendingTaskController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var pendingTask = appDbContext.Movements
                                .Where(a=>a.AssignedTo == 74 && a.IsCurrent == true)
                                .Select(a => new
                                {
                                    a.Id, a.Serial,a.TaskId,a.ModuleId,a.PageId,a.ProjectId,a.TrackerId,a.FromStage,a.ToStage,a.Progress,a.MovedBy,
                                    a.AssignedTo,a.Priority,a.CreatedAt
                                })
                                .OrderBy(a=>a.ProjectId)
                                .ThenBy(a=>a.TrackerId)
                                .ThenByDescending(a=>a.CreatedAt)
                                .ToList();

            return View();
        }
    }
}
