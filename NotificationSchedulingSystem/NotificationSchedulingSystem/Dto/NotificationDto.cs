namespace NotificationSchedulingSystem.Dto
{
    public class NotificationDto
    {
        public Guid CompanyId { get; set; }
        public List<DateTime> SendDate { get; set; }
    }
}
