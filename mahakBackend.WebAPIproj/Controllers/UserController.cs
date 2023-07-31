using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Irepository;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Post([FromBody] UserEntity user)
        {
            if(user == null)
            {
                return BadRequest("User data is null");
            }
            _userRepository.Add(user);
            return Ok("User added successfully.");
        }
    }
}
