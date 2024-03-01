namespace ZencareLTE.Models
{
    public class CalendarSchedulerEvent
    {
        public string? Id { get; set; }
        public string? Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
