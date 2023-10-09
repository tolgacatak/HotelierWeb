using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.Controllers
{
    public class RoomController : Controller // Admin tarafı için oluşturuldu
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
