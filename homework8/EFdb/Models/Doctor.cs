namespace EFdb.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Specialization { get; set; } = "";

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public List<Appointment> Appointments { get; } = new();
    }
}
