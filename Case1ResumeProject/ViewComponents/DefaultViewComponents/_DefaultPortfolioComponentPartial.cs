using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultPortfolioComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
