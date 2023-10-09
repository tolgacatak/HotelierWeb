using Hote.WebUI.Dtos.BookingDto;
using Hote.WebUI.Dtos.CrewDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hote.WebUI.ViewComponents.DashBoard
{
    public class _DashBoardLast6Bookings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashBoardLast6Bookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5140/api/Booking/Last6Bookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast6BookingsDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
