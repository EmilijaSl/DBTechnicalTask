using NotificationSchedulingSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
