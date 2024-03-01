namespace ZencareLTE.Models
{
    public class PrescriptionDetails
    {
        public int Id { get; set; }

        public int DId { get; set; }

        public string? DoctorName { get; set; }

        public int PId { get; set; }

        public string? PatientName { get; set; }

        public int PatientAge { get; set; }

        public string? Gender { get; set; }

        public int PatientContactNo { get; set; }

        public string? PatientDiagnosis { get; set; }

        public string? PrescriptionDetail { get; set; }
    }
}
