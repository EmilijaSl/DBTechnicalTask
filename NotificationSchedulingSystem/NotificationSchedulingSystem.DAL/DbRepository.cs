using Microsoft.EntityFrameworkCore;
using NotificationSchedulingSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSchedulingSystem.DAL
{
    public class DbRepository : IDbRepository
    {
        private readonly SystemDbContext _dbContext;

        public DbRepository(SystemDbContext context)
        {
            _dbContext = context;
        }

        public async Task AddCompanyAsync(CompanyInformation company)
        { 
        _dbContext.Company.Add(company);
        }
        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CompanyInformation> GetCompanyAsync(string name)
        {
            return await _dbContext.Company.FirstOrDefaultAsync(i => i.CompanyName == name);
        }
        public async Task<CompanyInformation> GetCompanyByIdAsync(int id)
        {
            return await _dbContext.Company.FirstOrDefaultAsync(i => i.EntityId == id);
        }

       
    }
}
