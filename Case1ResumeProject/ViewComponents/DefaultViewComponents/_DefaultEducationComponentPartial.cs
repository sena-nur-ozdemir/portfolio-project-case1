using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultEducationComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultEducationComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Educations.ToList();
            return View(values);
        }
    }
}
