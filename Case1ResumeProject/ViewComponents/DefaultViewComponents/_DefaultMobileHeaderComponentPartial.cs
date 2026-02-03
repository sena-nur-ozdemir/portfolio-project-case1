using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultMobileHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
