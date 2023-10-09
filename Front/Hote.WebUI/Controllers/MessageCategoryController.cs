using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
