namespace EFdb.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }


        public List<Appointment> Appointments { get; } = new();
        public List<MedicalRecord> MedicalRecords { get; } = new();
    }
}
