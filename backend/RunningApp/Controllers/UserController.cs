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
        public IEnumerable<User> GetAll()
        {
            return userService.GetAll();

        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var getUser = userService.GetUserById(id);

            return Ok(getUser);
        }

        [HttpPost]
        public IActionResult Create(CreateUserDto dto)
        {
            var createUser = userService.Create(dto);

            return Ok(createUser);
        }

        [HttpPut]
        public IActionResult Update(UpdateUserDto updateUserDto)
        {
            var update = userService.Update(updateUserDto);
            return Ok(update);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteUser = userService.Delete(id);

            if (deleteUser == null)
            {
                return NotFound();
            }
            return Ok(deleteUser);
        }
    }
}
