using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using mahakBackend.Core.Domain.Iservice;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace mahakBackend.WebAPIproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserEntity user)
        {
            if (user == null)
            {
                return BadRequest("User data is null");
            }
            _userService.Add(user);
            return Ok("User added successfully.");
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return BadRequest("There is no user with this ID!");
            }
            return Ok(user);
        }

        [HttpPut]
        public IActionResult UpdateUser(UserEntity user)
        {
            if (user == null)
            {
                return BadRequest("There is no user with this ID!");
            }
            _userService.Update(user);
            return Ok("User updated successfully.");
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            if (_userService.GetById(id) == null)
            {
                return BadRequest("There is no user with this ID!");
            }
            _userService.Delete(id);
            return Ok("User updated successfully.");
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }
    }
}
