﻿using Microsoft.AspNetCore.Mvc;

namespace Perispanya.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}