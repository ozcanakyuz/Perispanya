using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
