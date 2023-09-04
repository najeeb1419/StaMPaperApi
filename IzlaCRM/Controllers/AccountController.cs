using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IzlaCRM.Controllers
{
    [EnableCors("")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(ILogger<AccountController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [Route("AddAccount")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAccount(Account input)
        {
            try
            {
                await _unitOfWork.AccountRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("GetAccounts")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                var result = await _unitOfWork.AccountRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("AccountGetById")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AccountGetById(int id)
        {
            try
            {
            var result=    await _unitOfWork.AccountRepository.GetByIdAsync(id);
            return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Updatecontent( Account input)
        {
      
            try
            {
                await _unitOfWork.AccountRepository.UpdateAsync(input);
                await _unitOfWork.SaveChangesAsync();
                return Ok(input);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _logger.LogError(ex, "An error occurred while updating the content.");
                return StatusCode(500, "An error occurred while updating the content.");
            }
        }
    }
}
