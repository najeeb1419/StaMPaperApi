using IzlaCRM.Entity.Models;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Abp.UI;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IzlaCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;
        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork, IConfiguration config)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _config = config;
        }

        [Route("AddUser")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddUser(User input)
        {
            try
            {
                await _unitOfWork.UserRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }


        [Route("UserGetByTenant")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public IActionResult UserGetByTenant(int TenantId)
        {
            try
            {
                var result =  _unitOfWork.UserRepository.GetUserbyTenant(TenantId).Select(x => new SelectItemModel()
                {
                    Label = x.FirstName +" " +x.LastName,
                    Value = x.Id
                }).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }


        [AllowAnonymous]
        [Route("Authenticate")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public ActionResult Login( UserLoginModel userLogin)
        {
            var user = Authenticate(userLogin);
            if (user != null)
            {
                var token = GenerateToken(user);
                return Ok(new {user,token});
            }

            return NotFound("user not found");
        }

        // To generate token
        private string GenerateToken(User user)
        {
            string keyString = _config["Jwt:Key"];
            byte[] keyBytes = Encoding.UTF8.GetBytes(keyString);

            if (keyBytes.Length < 16) // If the key size is less than 128 bits (16 bytes)
            {
                keyBytes = GenerateRandomKey(16); // Generate a new random key
                keyString = Encoding.UTF8.GetString(keyBytes);
            }

            var securityKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
        new Claim(ClaimTypes.NameIdentifier,user.UserName),
        new Claim(ClaimTypes.Sid,user.Id.ToString()),
        new Claim("TenantID",user.TenantId.ToString())
    };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddDays(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private byte[] GenerateRandomKey(int keySize)
        {
            byte[] keyBytes = new byte[keySize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(keyBytes);
            }
            return keyBytes;
        }




        //To authenticate user
        private User? Authenticate(UserLoginModel userLogin)
        {
            try
            {
                var currentUser = _unitOfWork.UserRepository.Finduser(userLogin.Email, userLogin.Password);
                if (currentUser != null)
                {
                    return currentUser;
                }
                else
                {
                    throw new UserFriendlyException("User not found.");
                }
            }
            catch (Exception)
            {

                throw new UserFriendlyException("There is an error"); ;
            }
           
            
        }
    }
}
