using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningApp.Models;
using System.Net.WebSockets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {

        private List<Time> _times;

        private RunningDbContext _dbContext;

        public TimeController()
        {
            _times = new List<Time>();
            _dbContext = new RunningDbContext();

        }

        [HttpGet]
        public IEnumerable<Time> GetTimes()
        {
            return _dbContext.Times;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTime(int id)
        {
            var getTime = _dbContext.Times.FirstOrDefault(x => x.Id == id);

            _dbContext.SaveChanges();

            return Ok(getTime);
        }



        [HttpPost]
        public IActionResult Post(Time newTime)
        {
            _dbContext.Times.Add(newTime);
            _dbContext.SaveChanges();

            return Ok(); 
        }

        [HttpDelete]
        
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound("id was null");
            }

            var timeToDel = _dbContext.Times.FirstOrDefault(x => x.Id == id);

            if (timeToDel == null)
            {
                return NotFound("could not find time");
            }
            _dbContext.Times.Remove(timeToDel);
            _dbContext.SaveChanges();

            return Ok();

        }
        [HttpPut]
        [Route("{id}")]
        public void Update(Time time, int id)
        {
            time.Id= id;
           
            _dbContext.Times.Update(time);
            _dbContext.SaveChanges();
        }

    }
}

