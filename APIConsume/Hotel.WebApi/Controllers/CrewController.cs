using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewController : ControllerBase
    {
        private readonly ICrewService _crewService;
        

        public CrewController(ICrewService crewService)
        {
            _crewService = crewService;
        }

        [HttpGet]
        public IActionResult CrewList()
        {
            var values = _crewService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCrew(Crew crew)
        {
            _crewService.TInsert(crew);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCrew(int id)
        {
            var values = _crewService.TGetByID(id);
            _crewService.TDelete(values);
            return Ok();
        }
        [HttpPut] //Update
        public IActionResult UpdateCrew(Crew crew)
        {
            _crewService.TUpdate(crew);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCrew(int id)
        {
            var values = _crewService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("Last4Crew")]
        public IActionResult Last4Crew()
        {
            var values = _crewService.TLast4Crew();
            return Ok(values);
        }

    }
}
