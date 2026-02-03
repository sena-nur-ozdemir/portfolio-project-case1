using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPreloaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
