using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.BL
{
    public interface INotificationService
    {
        Task<IEnumerable<DateTime>> AsingNotifications(Market market, CompanyType companyType);
    }
}
