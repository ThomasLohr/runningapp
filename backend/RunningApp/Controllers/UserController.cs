using Microsoft.AspNetCore.Mvc;
using RunningApp.Models;
using RunningApp.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserRepository _userRepository;
        public UserController()
        {
           _userRepository = new UserRepository();
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();

        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var getUser = _userRepository.GetUser(id);

            return Ok(getUser);
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userRepository.CreateUser(user);
            return Ok(user);
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
            return Ok(user);


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleteUser = _userRepository.DeleteUser(id);

            if (deleteUser == null)
            {
                return NotFound();
            }
            return Ok(deleteUser);
        }
    }
}
