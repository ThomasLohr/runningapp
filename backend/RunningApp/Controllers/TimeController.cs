using Microsoft.AspNetCore.Mvc;
using RunningApp.Dto;
using RunningApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly TimeService _timeService;
        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet]
        public IEnumerable<TimeDto> GetAll()
        {
            return _timeService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTime(int id)
        {
            var getTime = _timeService.GetTime(id);

            return Ok(getTime);
        }

        [HttpPost]
        public IActionResult Create(TimeDto dto)
        {
            
            var createTime = _timeService.Create(dto);
           
            return Ok(createTime); 
        }
       
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var timeToBeDeleted = _timeService.Delete(id);

            return Ok(timeToBeDeleted);

        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(TimeDto timeDto, int id)
        {
            var updatedTime = _timeService.Update(timeDto, id);

            return Ok(updatedTime);
            
        }

    }
}

