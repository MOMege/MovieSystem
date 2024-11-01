using Application.Contract.Interface;
using Application.DTO;
using Domain.Entities.Commen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieSystemApi.Controllers
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
        [HttpGet]
        public async Task<IActionResult> GetALlUsers()
        {
            var users = await _userService.GetALlUser();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
                return BadRequest();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto User)
        {
            await _userService.CreateUser(User);
            return Ok();
        }


        [HttpPut("{id}")]
        public  async Task<IActionResult> UpdateUser( int id ,UserUpdateDto User) {
            if (id != User.Id)
               return BadRequest();

                var user = await _userService.UpdateUser(id, User);
            return Ok();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
        

    }
}
