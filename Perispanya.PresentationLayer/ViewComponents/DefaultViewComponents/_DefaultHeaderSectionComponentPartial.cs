using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeaderSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
