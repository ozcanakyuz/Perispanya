using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
