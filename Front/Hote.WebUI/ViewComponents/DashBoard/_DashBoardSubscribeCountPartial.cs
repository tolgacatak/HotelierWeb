using Hote.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Hote.WebUI.ViewComponents.DashBoard
{
    public class _DashBoardSubscribeCountPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {


    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/tolga.catakk"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "ffad08374emshaa24b03e9f4c7fep1663e2jsn222a70878649" },
    //    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
    //            ViewBag.Instagramfollowers = resultInstagramFollowersDtos.followers;
    //            ViewBag.Instagramfollowing = resultInstagramFollowersDtos.following;

    //        }

    //        var client2 = new HttpClient();
    //        var request2 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=tolgacatakk"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "ffad08374emshaa24b03e9f4c7fep1663e2jsn222a70878649" },
    //    { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    //},
    //        };
    //        using (var response2 = await client2.SendAsync(request2))
    //        {
    //            response2.EnsureSuccessStatusCode();
    //            var body2 = await response2.Content.ReadAsStringAsync();
    //            ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
    //            ViewBag.Twitterfollowers = resultTwitterFollowersDto.data.user_info.followers_count;
    //            ViewBag.Twitterfollowing = resultTwitterFollowersDto.data.user_info.friends_count;

    //        }

    //        var client3 = new HttpClient();
    //        var request3 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=www.linkedin.com%2Fin%2Ftolga-%C3%A7atak-74634b201"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "ffad08374emshaa24b03e9f4c7fep1663e2jsn222a70878649" },
    //    { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    //},
    //        };
    //        using (var response3 = await client3.SendAsync(request3))
    //        {
    //            response3.EnsureSuccessStatusCode();
    //            var body3 = await response3.Content.ReadAsStringAsync();
    //            ResultLinkedinFollowersDto resultLinkedinFollowersDto = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);

    //            ViewBag.Linkedinconnections = resultLinkedinFollowersDto.data.connections_count;
    //            ViewBag.Linkedinfollowers = resultLinkedinFollowersDto.data.followers_count;
    //        }
            return View();
        }
    }
}
