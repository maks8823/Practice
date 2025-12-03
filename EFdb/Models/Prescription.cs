namespace EFdb.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medication { get; set; } = "";
        public string Dosage { get; set; } = "";
        public int Quantity { get; set; }
        public DateTime IssuedAt { get; set; } = DateTime.UtcNow;

        public int? AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }

        public int? MedicalRecordId { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }
    }
}
