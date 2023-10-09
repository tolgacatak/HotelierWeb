using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.DashBoard
{
    public class _DashBoardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
