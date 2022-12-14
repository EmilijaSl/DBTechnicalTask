using Microsoft.EntityFrameworkCore;
using NotificationSchedulingSystem.Domain;

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
        public async Task<CompanyInformation> GetCompanyByIdAsync(Guid id) //string
        {
            return await _dbContext.Company.FirstOrDefaultAsync(i => i.EntityId == id);
        }
    }
}
