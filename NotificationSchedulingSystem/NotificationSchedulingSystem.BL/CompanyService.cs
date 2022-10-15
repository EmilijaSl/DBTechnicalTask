using NotificationSchedulingSystem.DAL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.BL
{
    public class CompanyService : ICompanyService
    {
        private readonly IDbRepository _repository;
        private readonly INotificationService _notificationService;
        public CompanyService(IDbRepository repository, INotificationService notificationService)
        {
            _repository = repository;
            _notificationService = notificationService;
        }

        public async Task<CompanyInformation> CreateCompanyAsync(string name, string companyNumber, CompanyType type, Market market)
        {
            var existingCompany = await _repository.GetCompanyAsync(name);
            if (existingCompany != null)
            {
                return null;
            }
            var newCompany = new CompanyInformation
            {
                CompanyName = name,
                CompanyNumber = companyNumber,
                Type = type,
                Market = market,
            };

            var notificationDates = await _notificationService.AsingNotifications(market, type);
            newCompany.Notifications = notificationDates.Select(i => new Notification { SendDate = i }).ToList();

            await _repository.AddCompanyAsync(newCompany);
            await _repository.CommitAsync();
            return newCompany;
        }
    }
}
