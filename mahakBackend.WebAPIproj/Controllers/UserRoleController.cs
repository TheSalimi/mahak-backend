using mahakBackend.Core.Application.services;
using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Iservice;
using mahakBackend.WebAPIproj.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace mahakBackend.WebAPIproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUser_RoleService _userRoleService;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public UserRoleController(IUser_RoleService userRoleService,IUserService userService,IRoleService roleService)
        {
            _userRoleService = userRoleService;
            _userService = userService;
            _roleService = roleService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserRoleViewModel user_Role)
        {
            var user = _userService.GetById(user_Role.UserId);
            var role = _roleService.GetById(user_Role.RoleId);
            if(user == null)
            {
                return BadRequest("user is null");
            }
            else if(role == null)
            {
                return BadRequest("role is null");
            }

            User_RoleEntity User_Role = new User_RoleEntity();
            User_Role.UserId = user.Id;
            User_Role.RoleId = role.Id;
            User_Role.User = user;
            User_Role.Role = role;
                
            _userRoleService.Add(User_Role);
            return Ok("user-rule added");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userRoleService.Delete(id);
            return Ok("user-rule deleted");
        }

        [HttpGet("roles/{id}")]
        public IActionResult GetRolesById(int id) { 
            return Ok(_userRoleService.GetRolesByUserId(id));
        }

        [HttpGet("users/{roleId:int}")]
        public IActionResult GetUsersByRoleId(int roleId)
        {
            return Ok(_userRoleService.GetUsersByRoleId(roleId));
        }
    }
}
