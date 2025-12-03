namespace EFdb.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; } = "";
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        
        public int? AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }

        public List<Prescription> Prescriptions { get; } = new();
    }
}
