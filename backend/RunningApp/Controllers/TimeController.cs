using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningApp.Models;
using RunningApp.Repository;
using System.Net.WebSockets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {

        private TimeRepository _timeRepository;

        //public TimeController(TimeRepository timeRepository)
        //{
        //    _timeRepository = timeRepository; 
            
        //}
        public TimeController(TimeRepository timeRepository)
        {
            _timeRepository = timeRepository;
        }

        [HttpGet]
        public IEnumerable<Time> GetTimes()
        {
            return _timeRepository.GetTimes();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTime(int id)
        {
            var getTime = _timeRepository.GetTime(id);

            return Ok(getTime);
        }

        [HttpPost]
        public IActionResult CreateTime(Time newTime)
        {
            var createTime = _timeRepository.CreateTime(newTime);
            
            return Ok(createTime); 
        }

        [HttpDelete]
        public IActionResult DeleteTime(int? id)
        {
            var timeToBeDeleted = _timeRepository.DeleteTime(id);

            return Ok(timeToBeDeleted);

        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateTime(Time time, int id)
        {
            var timeToBeUpdated = _timeRepository.UpdateTime(time, id);

            return Ok(timeToBeUpdated);
            
        }

    }
}

