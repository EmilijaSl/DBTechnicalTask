using NotificationSchedulingSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace NotificationSchedulingSystem.Domain
{
    public class CompanyInformation
    {
        [Key]
        public int EntityId { get; set; }
        public string? CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public CompanyType Type { get; set; }
        public Market Market { get; set; }
        public virtual List<Notification> Notifications { get; set; }
    }
}
