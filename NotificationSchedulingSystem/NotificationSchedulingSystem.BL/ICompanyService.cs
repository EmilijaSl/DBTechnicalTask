using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;

namespace NotificationSchedulingSystem.BL
{
    public interface ICompanyService
    {
        Task<CompanyInformation> CreateCompanyAsync(string name, string companyNumber, CompanyType type, Market market);  //int[]? notifications
    }
}
