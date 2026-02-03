using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultSkillComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();
            return View(values);    
        }
    }
}
