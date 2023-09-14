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
    public class BankEmployeePaymentController : ControllerBase
    {
        private readonly ILogger<BankEmployeePaymentController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public BankEmployeePaymentController(ILogger<BankEmployeePaymentController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [Route("AddBankEmployeePayment")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddBankEmployeePayment(BankEmployeePayment input)
        {
            try
            {
                await _unitOfWork.BankEmployeePaymentRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }


        [Route("BankEmployeePaymentGetById")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> BankEmployeePaymentGetById(int id)
        {
            try
            {
            var result=    await _unitOfWork.BankEmployeePaymentRepository.GetByIdAsync(id);
            return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("GetBankEmployeePaymentByReceiptId")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public  IActionResult GetBankEmployeePaymentByReceiptId(int id)
        {
            try
            {
                var result =  _unitOfWork.BankEmployeePaymentRepository.GetBankEmployeePaymentByReceiptId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("UpdateBankEmployeePayment")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateBankEmployeePayment( BankEmployeePayment input)
        {
      
            try
            {
                await _unitOfWork.BankEmployeePaymentRepository.UpdateAsync(input);
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
