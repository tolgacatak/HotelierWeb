using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.DashBoard
{
    public class _DashBoardHeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
