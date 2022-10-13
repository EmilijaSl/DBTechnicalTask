using AutoFixture;
using Moq;
using NotificationSchedulingSystem.BL;
using NotificationSchedulingSystem.Controllers;
using NotificationSchedulingSystem.DAL;

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


       
    }
}