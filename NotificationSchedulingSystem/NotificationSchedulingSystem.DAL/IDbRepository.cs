using NotificationSchedulingSystem.Domain;

namespace NotificationSchedulingSystem.DAL
{
    public interface IDbRepository
    {
        Task AddCompanyAsync(CompanyInformation company);
        Task CommitAsync();
        Task<CompanyInformation> GetCompanyAsync(string name);
        Task<CompanyInformation> GetCompanyByIdAsync(int id);
    }
}
