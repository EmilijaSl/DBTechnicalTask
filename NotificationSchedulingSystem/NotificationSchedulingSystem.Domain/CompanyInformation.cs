using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.Domain
{
    public class CompanyInformation
    {
        [Key]
        public int EntityId { get; set; } //guid?
        public string? CompanyName { get; set; }
        public int CompanyNumber { get; set; }
        public  CompanyType Type { get; set; }
        public Market Market { get; set; }
        public virtual List<Notification> Notifications { get; set; }

    }
}
