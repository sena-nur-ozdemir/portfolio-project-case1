using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHomeComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultHomeComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
