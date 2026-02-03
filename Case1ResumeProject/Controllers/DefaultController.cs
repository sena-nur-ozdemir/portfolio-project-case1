using Microsoft.AspNetCore.Mvc;

namespace Case1ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
