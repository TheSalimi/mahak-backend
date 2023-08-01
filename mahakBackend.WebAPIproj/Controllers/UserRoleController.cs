using mahakBackend.Core.Application.services;
using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Iservice;
using Microsoft.AspNetCore.Mvc;

namespace mahakBackend.WebAPIproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUser_RoleService _userRoleService;
        public UserRoleController(IUser_RoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] User_RoleEntity user_Role)
        {
            _userRoleService.Add(user_Role);
            return Ok("user-rule added");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userRoleService.Delete(id);
            return Ok("user-rule deleted");
        }

        [HttpGet("roles/{userCode:long}")]
        public IActionResult GetRolesById(long userCode) { 
            return Ok(_userRoleService.GetRolesByUserCode(userCode));
        }

        [HttpGet("users/{roleId:int}")]
        public IActionResult GetUsersByRoleId(int roleId)
        {
            return Ok(_userRoleService.GetUsersByRoleId(roleId));
        }
    }
}
