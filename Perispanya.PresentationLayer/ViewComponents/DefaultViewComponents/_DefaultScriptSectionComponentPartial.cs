using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultScriptSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
