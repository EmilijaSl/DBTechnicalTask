using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.Domain
{
    public class Notification
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Company))]
        public int EntityId { get; set; }
        public DateTime SendDate { get; set; }
        public virtual CompanyInformation Company { get; set; }

    }
}
