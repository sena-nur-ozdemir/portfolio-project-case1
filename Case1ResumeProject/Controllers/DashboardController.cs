using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ResumeContext _context;

        public DashboardController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.Find(1);

            ViewBag.totalProjects = _context.Portfolios.Count();
            ViewBag.activeProjects = _context.Portfolios.Where(x => x.Status == true).Count();
            ViewBag.totalSkills = _context.Skills.Count();
            ViewBag.totalMessages = _context.Messages.Count();
            ViewBag.totalCertificates = _context.Certificates.Count();
            ViewBag.activeCertificates = _context.Certificates.Where(x => x.IsActive == true).Count();
            ViewBag.unreadMessages = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.totalEducations = _context.Educations.Count();
            ViewBag.totalExperiences = _context.Experiences.Count();
            ViewBag.totalServices = _context.Services.Count();
            ViewBag.totalTestimonials = _context.Testimonials.Count();
            return View(about);
        }
    }
}
