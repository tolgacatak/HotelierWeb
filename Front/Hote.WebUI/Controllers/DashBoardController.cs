using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
