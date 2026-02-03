using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.AdminViewComponents
{
    public class _AdminNavbarComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _AdminNavbarComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.CompletedProjects = _context.Portfolios.Count();
            ViewBag.UnreadMessages = _context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
