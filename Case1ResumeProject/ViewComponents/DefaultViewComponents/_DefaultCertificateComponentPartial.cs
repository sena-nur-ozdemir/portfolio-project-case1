using Case1ResumeProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultCertificateComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultCertificateComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Certificates.Where(x => x.IsActive == true).ToList();
            return View(values);
        }
    }
}
