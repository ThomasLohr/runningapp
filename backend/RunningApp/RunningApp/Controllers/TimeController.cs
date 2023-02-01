using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningApp.Models;

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


        [HttpPost]
        public void Post(string firstName, string lastName, int age, string totalTime)
        {
            var time = new Time(firstName, lastName, age, totalTime);

            _dbContext.Times.Add(time);
            _dbContext.SaveChanges();
        }
    }
}

