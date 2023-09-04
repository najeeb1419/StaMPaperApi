using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IzlaCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly ILogger<PermissionController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PermissionController(ILogger<PermissionController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [Route("AddPermission")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddPermission(Permission input)
        {
            try
            {
                await _unitOfWork.PermissionRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("AddRolePermission")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddRolePermission(List<RolePermission> input)
        {
            try
            {
                await _unitOfWork.RolePermissionRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();
                return Ok(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
