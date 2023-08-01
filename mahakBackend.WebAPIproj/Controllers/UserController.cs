using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace mahakBackend.WebAPIproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;   
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserEntity user)
        {
            if(user == null)
            {
                return BadRequest("User data is null");
            }
            _userRepository.Add(user);
            return Ok("User added successfully.");
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userRepository.GetById(id);
            if (user==null){
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
            _userRepository.Update(user);
            return Ok("User updated successfully.");
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            if (_userRepository.GetById(id) == null)
            {
                return BadRequest("There is no user with this ID!");
            }
            _userRepository.Delete(id);
            return Ok("User updated successfully.");
        }

        [HttpGet]
        public IActionResult GetAllUsers() { 
            var userList = _userRepository.GetAllUsers();
            if(userList == null)
            {
                return BadRequest("There is no user");
            }
            else
            {
                return Ok(userList);
            }
        }
    }
}
