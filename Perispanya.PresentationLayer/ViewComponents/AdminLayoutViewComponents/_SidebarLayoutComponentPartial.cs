﻿using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
