using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunningApiControllercs : ControllerBase
    {

        private List<int> TimesSaved;

        public RunningApiControllercs()
        {
            TimesSaved = new List<int>();
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            return TimesSaved;
        }


        [HttpPost]
        public void Post([FromBody] int time)
        {
            TimesSaved.Add(time);
            TimesSaved.Add(time);
            
        }
    }
}

