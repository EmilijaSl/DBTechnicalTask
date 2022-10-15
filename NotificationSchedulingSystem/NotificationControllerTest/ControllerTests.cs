using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.Controllers;
using NotificationSchedulingSystem.DAL;
using NotificationSchedulingSystem.Domain;
using NotificationSchedulingSystem.Domain.Enums;
using NotificationSchedulingSystem.Dto;

namespace NotificationControllerTest
{
    public class ControllerTests
    {
        private readonly Mock<ICompanyService> _companyServiceMock;
        private readonly Mock<INotificationService> _notificationServiceMock;
        private readonly NotificationController _sut;
        private IFixture _fixture;

        public ControllerTests()
        {
            _companyServiceMock = new Mock<ICompanyService>();
            _notificationServiceMock = new Mock<INotificationService>();
            _sut = new NotificationController(_companyServiceMock.Object, _notificationServiceMock.Object);
            _fixture = new Fixture();
        }

        [Theory, AutoData]
        public async Task Test1(CompanyInformation company, string message)
        {
            _companyServiceMock.Setup(c => c.CreateCompanyAsync("Test", "0000000000", CompanyType.small, Market.Denmark)).ReturnsAsync(company);

            var result = _sut.CreateNewCompany(company)
            
        }

    }
}