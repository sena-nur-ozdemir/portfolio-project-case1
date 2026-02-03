using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.AdminViewComponents
{
    public class _AdminDashboardRecentMessagesComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _AdminDashboardRecentMessagesComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Messages.OrderByDescending(x => x.SendDate).Take(3).ToList();
            return View(values);
        }
    }
}
