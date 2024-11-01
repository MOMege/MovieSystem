using Application.Contract.Interface;
using Application.DTO;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _RoleService;
        public RoleController(IRoleService RoleService)
        {
            _RoleService = RoleService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var Role = await _RoleService.GetRoleById(id);
            return Ok(Role);
        }
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var Roles = await _RoleService.GetAllROle();
            return Ok(Roles);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletRole(int id)
        {
            await _RoleService.DeleteROle(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleDto Roledto)
        {
            await _RoleService.CreateROle(Roledto);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(int id, RoleDto roledto)
        {
            if (id != roledto.Id)
                return BadRequest();
            var Role = await _RoleService.UpdateROle(id, roledto);
            return Ok();
        }
    }
}
