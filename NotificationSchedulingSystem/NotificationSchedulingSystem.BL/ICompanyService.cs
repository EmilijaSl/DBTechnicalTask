using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.BL
{
    public interface ICompanyService
    {
       // CompanyInformation CreateNewCompany(CompanyInformation company);
        Task<CompanyInformation> CreateCompanyAsync(string name, int companyNumber, CompanyType type, Market market);  //int[]? notifications
    }
}
