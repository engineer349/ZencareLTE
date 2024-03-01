namespace ZencareLTE.Models
{
    public class BedRegistrationDetails
    {
        public int PId { get; set; }

        public string? PatientName { get; set; }

        public int BId { get; set; }

        public string? BedRype { get; set; }

        public string? RoomType { get; set; }

        public DateOnly BedRequiredDate { get; set; }

        public string? ReasonType { get; set; }


    }
}
