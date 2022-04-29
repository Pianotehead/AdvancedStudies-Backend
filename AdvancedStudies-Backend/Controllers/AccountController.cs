using AdvancedStudies_Backend.Data;
using AdvancedStudies_Backend.Models.Domain;
using AdvancedStudies_Backend.Models.DTO;
using AdvancedStudies_Backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedStudies_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;
        private readonly ApplicationContext _context;

        public AccountController(UserManager<User> userManager, TokenService tokenService, ApplicationContext context)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return Unauthorized();
            return new UserDto
            {
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var user = new User
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                UserName = registerDto.Email,
                Email = registerDto.Email
            };
            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return ValidationProblem();
            }

            await _userManager.AddToRoleAsync(user, "Student");
            
            return StatusCode(201);
        }
        [HttpPut("currentUser")]
        public async Task<ActionResult> UpdateProfile(UpdateProfileDto updateProfileDto)
        {
            var existingUser = await _userManager.FindByEmailAsync(updateProfileDto.Email);

            if (existingUser == null) return NotFound();

            existingUser.FirstName = updateProfileDto.FirstName;
            existingUser.LastName = updateProfileDto.LastName;
            existingUser.ReceiveEmails = updateProfileDto.ReceiveEmails;
            existingUser.CurrentAddress = updateProfileDto.CurentAddress;
            existingUser.PhoneNumber = updateProfileDto.PhoneNumber;
            existingUser.Gender = updateProfileDto.Gender;
            existingUser.About = updateProfileDto.About;
            existingUser.WebsiteLink = updateProfileDto.WebsiteLink;
            existingUser.TwitterLink = updateProfileDto.TwitterLink;
            existingUser.FacebookLink = updateProfileDto.FacebookLink;
            existingUser.LinkedinLink = updateProfileDto.LinkedinLink;
            existingUser.Experience = updateProfileDto.Experience;
            existingUser.Education = updateProfileDto.Education;

            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest(new ProblemDetails { Title = "Problem updating user" });

            return NoContent();
        }

        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity?.Name);
            if (user == null) return NotFound();
            return new UserDto
            {
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }

    }
}
