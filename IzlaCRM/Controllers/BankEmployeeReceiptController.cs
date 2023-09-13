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
    public class BankEmployeeReceiptController : ControllerBase
    {
        private readonly ILogger<BankEmployeeReceiptController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public BankEmployeeReceiptController(ILogger<BankEmployeeReceiptController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        [Route("GetBankEmployeeReceipts")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public IActionResult GetBankEmployeeReceipts()
        {
            try
            {
                var result = _unitOfWork.BankEmployeeReceiptRepository.GetBankEmployeeReceipts();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("AddBankEmployeeReceipt")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddBankEmployeeReceipt(BankEmployeeReceipt input)
        {
            try
            {
                await _unitOfWork.BankEmployeeReceiptRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }


        [Route("BankEmployeeReceiptGetById")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> BankEmployeeReceiptGetById(int id)
        {
            try
            {
                var result = await _unitOfWork.BankEmployeeReceiptRepository.GetByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("UpdateBankEmployeeReceipt")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateBankEmployeeReceipt(BankEmployeeReceipt input)
        {

            try
            {
                await _unitOfWork.BankEmployeeReceiptRepository.UpdateAsync(input);
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


        [Route("DeleteBankEmployeeReceipt")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteBankEmployeeReceipt(int id)
        {
            try
            {
                await _unitOfWork.BankEmployeeReceiptRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
                return Ok(id);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _logger.LogError(ex, "An error occurred while deleting the content.");
                return StatusCode(500, "An error occurred while deleting the content.");
            }
        }
    }
}
