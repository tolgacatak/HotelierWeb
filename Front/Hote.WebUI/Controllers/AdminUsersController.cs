using Hote.WebUI.Dtos.AppUserDto;
using Hote.WebUI.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hote.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5140/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsonData);
                return View(values);

            }
            return View();
        }

        //public IActionResult Index()
        //{
        //    var values = _userManager.Users.ToList();
        //    return View(values);
        //}
    }
}
