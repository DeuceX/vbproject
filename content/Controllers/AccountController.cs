using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.Dto.Customer;
using BLL.Services.Interfaces;
using Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Web.Authentication;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;
        private readonly ICustomerService _userService;

        public AccountController(
            UserManager<Customer> userManager,
            SignInManager<Customer> signInManager,
            ICustomerService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] CustomerLoginDto model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var token = GenerateToken(model.Email);
                var user = _userService.GetCustomerByTerm(model.Email);

                return Json(new { user, token });
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] CustomerRegistrationDto data)
        {
            if (ModelState.IsValid)
            {
                var user = new Customer
                {
                    UserName = data.Email,
                    Email = data.Email,
                    FullName = data.FullName,
                    DateOfBirthsday = data.DateOfBirthsday
                };

                var result = await _userManager.CreateAsync(user, data.Password);

                if (result.Succeeded)
                {
                    return Ok("User has been successfully created");
                }
            }

            return BadRequest("Server error");
        }

        private string GenerateToken(string username)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    AuthenticationOptions.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256)),
                new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
