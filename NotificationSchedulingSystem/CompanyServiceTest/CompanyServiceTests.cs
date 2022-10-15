using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.DAL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CompanyServiceTest
{
    public class CompanyServiceTests
    {
        private readonly Mock<IDbRepository> _dbRepositoryMock;
        private readonly Mock<INotificationService> _notificationServiceMock;
        private readonly CompanyService _sut;
        private readonly Fixture _fixture;

        public CompanyServiceTests()
        {
            _dbRepositoryMock = new Mock<IDbRepository>();
            _notificationServiceMock = new Mock<INotificationService>();
            _fixture = new Fixture();
            _sut = new CompanyService(_dbRepositoryMock.Object, _notificationServiceMock.Object);
        }


        [Theory, AutoData]
        public void Test1(CompanyInformation company)

        {
    

            //_dbRepositoryMock.Setup(a => a.GetCompanyAsync("Norfa")).ReturnsAsync(company);
            //var result = _sut.CreateCompanyAsync("Norfa", "0000000000", CompanyType.small, Market.Denmark);

            //Assert.NotNull(result);
        }
    }
}
