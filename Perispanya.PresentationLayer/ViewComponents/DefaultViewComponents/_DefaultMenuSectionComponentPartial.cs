using Microsoft.AspNetCore.Mvc;
using Perispanya.BusinnesLayer.Abstract;

namespace Perispanya.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultMenuSectionComponentPartial : ViewComponent
    {
        public readonly IProductService _productService;

        public _DefaultMenuSectionComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
    }
}
