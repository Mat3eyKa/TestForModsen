using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TestForModsen.Data;
using TestForModsen.Data.Auth;
using TestForModsen.Models;

namespace TestForModsen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly ModsenContext db;

        public AuthController(IConfiguration configuration, IUserService userService, ModsenContext authContext) =>
           (_configuration, _userService, db) = (configuration, userService, authContext);

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Auth([FromBody] LoginModel data)
        {
            if (_userService.IsValidUserInformation(data))
                return Ok(new { Token = GenerateJwtToken(data.UserName), Message = "Success" });

            return BadRequest("Not valid Username or Password");
        }

        private string GenerateJwtToken(string id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", id) }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
