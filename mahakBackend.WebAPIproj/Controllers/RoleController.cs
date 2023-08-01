using mahakBackend.Core.Domain.entities;
using mahakBackend.Core.Domain.Iservice;
using Microsoft.AspNetCore.Mvc;

namespace mahakBackend.WebAPIproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_roleService.GetAllRoles());
        }

        [HttpGet("{id}")]
        public IActionResult GetAllById(int id)
        {
           var role = _roleService.GetById(id);
            if(role == null)
            {
                return BadRequest("there is no role with this id");
            }

            return Ok(role);
        }

        [HttpPost]
        public IActionResult Add([FromBody] RoleEntity role)
        {
            if (role == null)
            {
                return BadRequest("role is null");
            }

            _roleService.Add(role);
            return Ok("Role has been added successfuly!");
        }

        [HttpPut]
        public IActionResult Update([FromBody] RoleEntity role)
        {
            if (role == null)
            {
                return BadRequest("role is null");
            }

            _roleService.Update(role);
            return Ok("Role has been updated successfuly!");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var role = _roleService.GetById(id);
            if (role == null)
            {
                return BadRequest("There is no role with this id");
            }

            _roleService.Delete(id);
            return Ok("Role deleted successfuly!");
        }
    }
}
