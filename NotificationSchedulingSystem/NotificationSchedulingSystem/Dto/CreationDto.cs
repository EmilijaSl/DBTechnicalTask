using NotificationSchedulingSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingSystem.Dto
{
    public class CreationDto
    {
        public string CompanyName { get; set; }
        [Required]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Enter valid company number.")]
        public string CompanyNumber { get; set; }
        [Required]
        public CompanyType Type { get; set; }
        [Required]
        public Market Market { get; set; }
    }
}
