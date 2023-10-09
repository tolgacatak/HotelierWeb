using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); } 
    }
}
