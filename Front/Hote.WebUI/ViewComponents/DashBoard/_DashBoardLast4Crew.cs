using Hote.WebUI.Dtos.CrewDto;
using Hote.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hote.WebUI.ViewComponents.DashBoard
{
    public class _DashBoardLast4Crew : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashBoardLast4Crew(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5140/api/Crew/Last4Crew");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast4CrewDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
