using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Hote.WebUI.Controllers
{
    public class AdminFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream(); //akış oluşturuldu
            await file.CopyToAsync(stream); //Dosyayı ilgili akış üzerinden kopyalama
            var bytes = stream.ToArray(); //akıştaki dosyayı byte olarak tutma

            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(byteArrayContent, "file", file.FileName);
            var httpclient = new HttpClient();
            await httpclient.PostAsync("http://localhost:5140/api/FileProcess", multipartFormDataContent);
            return View();
        }
    }
}
