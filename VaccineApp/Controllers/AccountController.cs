using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VaccineApp.DTO;
using VaccineApp.Services;

namespace VaccineApp.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Services.Interfaces;

    [ApiController, Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<AccountDto>> Register(RegisterDto dto)
        {
            if (await _service.UserExists(dto.Email))
            {
                return BadRequest("Email already exists");
            }
            try
            {
                var user = await _service.RegisterAsync(dto);
                return Created(uri: "", user);
            }
            catch (Exception)
            {
                return BadRequest("Register Failed");
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AccountDto>> LoginAsync(LoginDto dto)
        {
            try
            {
                var user = await _service.LoginAsync(dto.Email, dto.Password);
                return user;
            }
            catch (UnauthorizedAccessException e)
            {
                return Unauthorized(e.Message);
            }
        }

        [Authorize]
        [HttpPut("UpdatePassword/{email}-{password}")]
        public async Task<ActionResult> UpdatePasswordAsync(string email, string password)
        {
            await _service.UpdateUserPassword(email, password);
            return Ok();
        }
    }
}