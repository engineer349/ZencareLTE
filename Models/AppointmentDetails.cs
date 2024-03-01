namespace ZencareLTE.Models
{
    public class AppointmentDetails
    {
        public int PId { get; set; }

        public int DId { get; set; }

        public string? DoctorName { get; set; }

        public string? PatientName { get; set; }

        public int PatientAge { get; set; }

        public string? PatientGender { get; set; }

        public int PatientContactNo { get; set; }

        public string? PatientAddress { get; set; }


        public DateOnly AppointmentDate { get; set; }


        public TimeOnly AppointmentTime { get; set; }


        public string? PatientDisease { get; set; }

        public string? ReasonType { get; set; }
    }


}
