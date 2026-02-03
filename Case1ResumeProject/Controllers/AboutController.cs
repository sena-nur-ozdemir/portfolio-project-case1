using Case1ResumeProject.Context;
using Case1ResumeProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.Controllers
{
    public class AboutController:Controller
    {
        private readonly ResumeContext _context;

        public AboutController(ResumeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var value = _context.Abouts.Find(1);

            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var value = _context.Abouts.Find(about.AboutId);

            if (value == null)
            {
                return NotFound();
            }

            value.NameSurname = about.NameSurname;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;
            value.CvUrl = about.CvUrl;


            // CV YOLU (wwwroot/files)
            if (!string.IsNullOrEmpty(about.CvUrl))
            {
                value.CvUrl = about.CvUrl;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
