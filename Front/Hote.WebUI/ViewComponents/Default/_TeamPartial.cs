using Hote.WebUI.Dtos.ServiceDto;
using Hote.WebUI.Dtos.TeamDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hote.WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
            private readonly IHttpClientFactory _httpClientFactory;

            public _TeamPartial(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }
            public async Task<IViewComponentResult> InvokeAsync()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("http://localhost:5140/api/Crew"); //ilgili adresteki Api yi consume etmeye çalışıyoruz.
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultTeamDto>>(jsonData);
                    return View(values);

                }
                return View();
            }
    }
}
