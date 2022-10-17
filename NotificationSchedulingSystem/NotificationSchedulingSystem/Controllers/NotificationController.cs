using Microsoft.AspNetCore.Mvc;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.Dto;

namespace NotificationSchedulingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ICompanyService _service;
        public NotificationController(ICompanyService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> CreateNewCompany([FromBody] CreationDto creationDto)
        {
            var company = await _service.CreateCompanyAsync(creationDto.CompanyName, creationDto.CompanyNumber, creationDto.Type, creationDto.Market);
            return company != null ? Ok(company.Notifications.Select(n => new NotificationDto
            {
                EntityId = company.EntityId,
                SendDate = n.SendDate
            })) : BadRequest(new { ErrorMessage = "Company already exist" });
        }
    }
}
