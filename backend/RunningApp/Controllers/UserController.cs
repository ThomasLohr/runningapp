using Microsoft.AspNetCore.Mvc;
using RunningApp.Dto;
using RunningApp.Models;
using RunningApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            
            this.userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return userService.GetUsers();

        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var getUser = userService.GetUserById(id);

            return Ok(getUser);
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDto dto)
        {
            var createUser = userService.CreateUser(dto);

            return Ok(createUser);
        }

        [HttpPut]
        public IActionResult UpdateUser(UpdateUserDto updateUserDto)
        {
            var update = userService.UpdateUser(updateUserDto);
            return Ok(update);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleteUser = userService.DeleteUser(id);

            if (deleteUser == null)
            {
                return NotFound();
            }
            return Ok(deleteUser);
        }
    }
}
