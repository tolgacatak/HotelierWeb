﻿using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
