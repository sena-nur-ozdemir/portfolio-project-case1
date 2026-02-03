using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultStatisticsComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.CompletedProjects = _context.Portfolios.Where(x => x.Status == true).Count();
            ViewBag.Services = _context.Services.Count();
            ViewBag.Testimonials = _context.Testimonials.Count();
            ViewBag.Certificates = _context.Certificates.Where(x => x.IsActive == true).Count();
            return View();
        }
    }
}
