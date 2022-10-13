using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Dto;

namespace NotificationSchedulingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ICompanyService _service;
        private readonly INotificationService _notification;

        public NotificationController(ICompanyService service, INotificationService notification)
        {
            _service = service;
            _notification = notification;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> CreateNewCompany([FromBody] CreationDto creationDto)
        {
            var company = await _service.CreateCompanyAsync(creationDto.CompanyName, creationDto.CompanyNumber, creationDto.Type, creationDto.Market);

            return company != null ? Ok(company.Notifications.Select(n=>new NotificationDto
            {
                EntityId = n.Id,
                SendDate = n.SendDate
            })) : BadRequest(new { ErrorMessage = "User already exist" });

        }
       


 
      
    }
}
