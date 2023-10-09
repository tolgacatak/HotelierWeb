using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
