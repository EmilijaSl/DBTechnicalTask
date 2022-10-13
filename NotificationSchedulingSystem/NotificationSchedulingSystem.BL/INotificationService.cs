using NotificationSchedulingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.BL
{
    public interface INotificationService
    {
        Task<IEnumerable<DateTime>> AsingNotifications(Market market, CompanyType companyType);
    }
}
