using Microsoft.AspNetCore.Mvc;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Dto;
using System.Linq;

namespace NotificationSchedulingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ICompanyService _service;
        private readonly INotificationService _notificationService;
        public NotificationController(ICompanyService service, INotificationService notificationService)
        {
            _service = service;
            _notificationService = notificationService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> CreateNewCompany([FromBody] CreationDto creationDto)
        {
            var company = await _service.CreateCompanyAsync(creationDto.CompanyName, creationDto.CompanyNumber, creationDto.Type, creationDto.Market);
            if (company != null)
            {
                var response = new NotificationDto
                {
                    CompanyId = company.EntityId,
                    SendDate = company.Notifications.Select(n => n.SendDate).ToList()
                };
                return Ok(response);
            }
            return BadRequest(new { ErrorMessage = "Company already exist" });
        }
    }
}
