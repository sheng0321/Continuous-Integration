using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ConestogaVirtualGameStore.Server.Data.Enums;
using ConestogaVirtualGameStore.Server.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.Server.Data.Models;
using ConestogaVirtualGameStore.Server.Data;
using ConestogaVirtualGameStore.Server.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Web;
using Microsoft.AspNetCore.Authorization;

namespace ConestogaVirtualGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration, ApplicationDbContext context, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _context = context;
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (await _userManager.Users.AnyAsync(u => u.DisplayName == model.DisplayName))
            {
                return BadRequest("Display Name is already taken.");
            }

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                DisplayName = model.DisplayName
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                string defaultRole = "Member";
                await _userManager.AddToRoleAsync(user, defaultRole);

                UserProfile userProfile = new UserProfile
                {
                    UserId = user.Id,
                    DisplayName = model.DisplayName,
                    Email = model.Email
                };

                try
                {
                    _context.UserProfiles.Add(userProfile);
                    await _context.SaveChangesAsync();

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Action("ConfirmEmail", "Auth", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);

                    await _emailSender.SendEmailAsync(model.Email, "Confirm your email", $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>.");

                    return Ok("User registered successfully. Please check your email to confirm your account.");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }

            return BadRequest(result.Errors);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    return BadRequest("You need to confirm your email before you can log in.");
                }

                if (await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var token = await GenerateJwtToken(user);
                    return Ok(new { Token = token });
                }
            }

            return Unauthorized(new { error = "Invalid email or password." });// updated by lxd
        }

        [Authorize]
        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok("Password updated successfully.");
            }

            return BadRequest(result.Errors);
        }

        private async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim("DisplayName", user.DisplayName)
            };

            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpGet("confirmemail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return BadRequest("User ID and code are required.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return Ok("Email confirmed successfully.");
            }

            return BadRequest("Error confirming your email.");
        }

        //updated by lxd
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { error = "Invalid request data." });//updated by lxd

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest(new { error = "User not found." });//updated by lxd

            // Generate a string code
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var encodedCode = HttpUtility.UrlEncode(code); // Encode the code to ensure it can be safely sent via email

            // Generate the reset link
            var resetLink = $"http://localhost:3000/reset-password?email={model.Email}&code={encodedCode}";

            // Send the code via email
            //await _emailSender.SendEmailAsync(model.Email, "Reset Password", $"Your password reset code is: {encodedCode}");

            // Send the reset link via email
            await _emailSender.SendEmailAsync(model.Email, "Reset Password", $"Please reset your password by clicking on the link: <a href='{resetLink}'>Reset Password</a>");

            return Ok(new { message = "Password reset link has been sent to your email." });//updated by lxd
        }

        //updated by lxd
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(model.Email!);
            if (user == null)
                return BadRequest("User not found.");

            // Decode the code
            // var decodedCode = HttpUtility.UrlDecode(model.ResetCode);

            var result = await _userManager.ResetPasswordAsync(user, model.ResetCode!, model.NewPassword!);
            if (result.Succeeded)
                return Ok("Password has been reset successfully.");

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return BadRequest(ModelState);
        }

    }
}
