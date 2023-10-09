using Microsoft.AspNetCore.Mvc;
namespace Hote.WebUI.ViewComponents.Default
{
    public class _ReservationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
