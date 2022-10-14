using AutoFixture;
using Moq;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.DAL;

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


        [Fact]
        //public async void Test1(CompanyInformation company)
            
        //{
        //    company.CompanyName = "Norfa";
        //    var result = 
        //    _dbRepositoryMock.Setup(i => i.GetCompanyAsync(It.IsAny<string>())).ReturnsAsync(company);

        //    var result = await _sut.
        //}
    }
}