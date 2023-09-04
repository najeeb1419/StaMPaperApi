using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IzlaCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public RoleController(ILogger<RoleController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [Route("AddRole")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> AddRole(Role input)
        {
            try
            {
                await _unitOfWork.RoleRepository.AddAsync(input);
                await _unitOfWork.SaveChangesAsync();


                return Ok("New Role Added");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }

        [Route("GetRoles")]
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles(int TenantId)
        {
            try
            {
                var res = await _unitOfWork.RoleRepository.GetAllAsync(TenantId);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }
        [Route("DeleteRole")]
        [HttpGet]
        public async Task<ActionResult<Role>> DeleteRole(int id)
        {
            try
            {
                await _unitOfWork.RoleRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                return StatusCode(500, "An error occurred");
            }
        }
    }
}
