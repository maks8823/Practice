namespace EFdb.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime ScheduledAt { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public MedicalRecord? MedicalRecord { get; set; }
        public List<Prescription> Prescriptions { get; } = new();
    }
}
