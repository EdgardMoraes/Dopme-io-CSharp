using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Modulo05.JWT.Models;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Modulo05.JWT.Controllers;

// lógica para validar a auth 

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public AuthController(IConfiguration configuration) => _configuration = configuration;

    [HttpPost]
    [AllowAnonymous]
    // [Authorize(Roles = "Admin")]
    public IActionResult Logar([FromBody] Login login)
    {
        if (login.Email != "Admin" || login.Senha != "Admin") return Unauthorized();
        var o = _configuration.GetSection("Jwt");
        var k = new SymmetricSecurityKey(Encoding.UTF32.GetBytes(o["Key"]!));
        var c = new SigningCredentials(k, SecurityAlgorithms.HmacSha256);
        var r = new[] { new Claim(JwtRegisteredClaimNames.Email, login.Email) };

        var jst = new JwtSecurityToken
        (
            issuer: o["Issuer"],
            audience: o["Audience"],
            claims: r,
            expires: DateTime.UtcNow.AddDays(1),
            signingCredentials: c
        );
        return Ok(new { jst = new JwtSecurityTokenHandler().WriteToken(jst) });
    }
}