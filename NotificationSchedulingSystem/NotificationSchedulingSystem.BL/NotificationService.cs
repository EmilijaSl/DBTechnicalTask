using NotificationSchedulingSystem.DAL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.BL
{
    public class NotificationService :INotificationService
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
                    if (companyType == CompanyType.small || companyType == CompanyType.medium)
                    {
                        notifications = new int[] { 1, 7, 14, 28 };
                    }
                    else
                    {
                        notifications = new int[0];
                    }
                    break;
                case Market.Finland:
                    if (companyType == CompanyType.large)
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
                else if(DateTime.Today.Month < 12)
                {
                    notificationsList.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, item));
                }
                else
                {
                    notificationsList.Add(new DateTime(DateTime.Today.Year + 1, 1 , item));
                }
            }
            DateTime exactDate = DateTime.Today.Date;
            return notificationsList;
        }

    



    }
}

