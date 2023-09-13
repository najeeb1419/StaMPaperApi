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
    public class BankEmployeeController : ControllerBase
    {
        private readonly ILogger<BankEmployeeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public BankEmployeeController(ILogger<BankEmployeeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [Route("GetBankEmployees")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetBankEmployees()
        {
            try
            {
                var data = await _unitOfWork.BankEmployeeRepository.GetAllAsync();
                data = data.Where(x => x.IsDeleted == false);
                await _unitOfWork.SaveChangesAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("AddBankEmployee")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddBankEmployee(BankEmployee input)
        {
            try
            {
                await _unitOfWork.BankEmployeeRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();
                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }


        [Route("BankEmployeeGetById")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> BankEmployeeGetById(int id)
        {
            try
            {
                var result = await _unitOfWork.BankEmployeeRepository.GetByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("UpdateBankEmployee")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateBankEmployee(BankEmployee input)
        {
            try
            {
                await _unitOfWork.BankEmployeeRepository.UpdateAsync(input);
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

        [Route("DeleteBankEmployee")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteBankEmployee(int id)
        {
            try
            {
                await _unitOfWork.BankEmployeeRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
                return Ok("Ok");
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
