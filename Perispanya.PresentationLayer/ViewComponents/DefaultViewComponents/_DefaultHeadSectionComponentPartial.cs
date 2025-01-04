using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
