using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultFooterSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
