using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Iservice;
using Microsoft.AspNetCore.Mvc;
using mahakBackend.WebAPIproj.ViewModel;


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
            return Ok(UserViewModel.mapEntityToModel(user));
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

        [HttpPut("AddToUsers")]
        public IActionResult AddedToUsers(int id,string description)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return BadRequest("There is no user with this ID!");
            }

            user.Description = description;
            user.isAdded = true;
            user.JoinDate = DateTime.Now;
            user.LastActivity = DateTime.Now;
            user.UserCode = (user.Id+100000).ToString();

            _userService.Update(user);
            return Ok("new user is added successful");
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
            var userList = _userService.GetAllUsers();
            if (userList == null)
            {
                return BadRequest("user list is null! ");
            }
            var users = new List<UserViewModel>();
            foreach(UserEntity user in userList)
            {
                users.Add(UserViewModel.mapEntityToModel(user));
            }
            return Ok(users);
        }
    }
}
