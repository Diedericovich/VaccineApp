namespace VaccineApp.Controllers
{
    using DTO;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController, Authorize, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task AddUserAsync(UserDto user)
        {
            await _service.AddUserAsync(user);
        }

        [HttpDelete("{id:int})")]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            try
            {
                await _service.DeleteUserAsync(id);
                return Ok("Delete OK");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<UserDto> GetUserAsync(int id)
        {
            return await _service.GetUserAsync(id);
        }

        [HttpGet("{email}")]
        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            return await _service.GetUserByEmailAsync(email);
        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            return await _service.GetUsersAsync();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(UserDto user)
        {
            await _service.UpdateUserAsync(user);
            return Ok("Update OK");
        }
    }
}