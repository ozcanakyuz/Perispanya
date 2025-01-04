using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultFourcupSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
