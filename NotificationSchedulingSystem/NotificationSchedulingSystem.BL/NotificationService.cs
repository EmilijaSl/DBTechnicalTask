using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.BL
{
    public class NotificationService : INotificationService
    {
        public async Task<IEnumerable<DateTime>> AsingNotifications(Market market, CompanyType companyType)
        {

            int[] notifications;
            switch (market)
            {
                case Market.Denmark:
                    notifications = new int[] { 1, 5, 10, 15, 20 };
                    break;
                case Market.Norway:
                    notifications = new int[] { 1, 5, 10, 20 };
                    break;
                case Market.Sweden:
                    if (companyType == CompanyType.Small || companyType == CompanyType.Medium)
                    {
                        notifications = new int[] { 1, 7, 14, 28 };
                    }
                    else
                    {
                        notifications = new int[0];
                    }
                    break;
                case Market.Finland:
                    if (companyType == CompanyType.Large)
                    {
                        notifications = new int[] { 1, 5, 10, 15, 20 };
                    }
                    else
                    {
                        notifications = new int[0];
                    }
                    break;
                default:
                    notifications = new int[0];
                    break;

            }
            List<DateTime> notificationsList = new List<DateTime>();
            foreach (var item in notifications)
            {
                if (item > DateTime.Today.Day)
                {
                    notificationsList.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, item));


                }
                else if (DateTime.Today.Month < 12)
                {
                    notificationsList.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, item));
                }
                else
                {
                    notificationsList.Add(new DateTime(DateTime.Today.Year + 1, 1, item));
                }
            }
            return notificationsList;
        }
    }
}

