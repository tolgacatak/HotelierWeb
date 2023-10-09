using Hotel.BusinessLayer.Abstract;
using Hotel.DTOLayer.Dtos.Contac;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContacController : ControllerBase
    {
        private readonly IContacService _contacService;

        public ContacController(IContacService contacService)
        {
            _contacService = contacService;
        }
        [HttpPost]
        public IActionResult AddContac(ContacDto contac)
        {
            Contac test = new();
            test.MessageCategoryID = contac.MessageCategoryID;
            test.Subject = contac.Subject;
            test.Message = contac.Message;
            test.Date = Convert.ToDateTime(DateTime.Now.ToString());
            test.Name = contac.Name;
            test.Mail = contac.Mail;

            _contacService.TInsert(test);
            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContac()
        {
            var values = _contacService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contacService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
           return Ok(_contacService.TGetContactCount());
        }

    }
}
