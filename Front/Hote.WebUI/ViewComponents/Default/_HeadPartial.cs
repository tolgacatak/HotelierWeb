using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke() //Invoke çağırmak anlamında kullanılır
        { 
            return View(); 
        }
    }
}
