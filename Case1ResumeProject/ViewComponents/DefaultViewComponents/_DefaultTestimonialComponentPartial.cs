using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultTestimonialComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}
