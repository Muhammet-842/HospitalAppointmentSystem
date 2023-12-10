using System.ComponentModel.DataAnnotations;

namespace HospitaAppointmentSystem.Data
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public string? PatientSurname { get; set; }
        public string? PatientEmail { get; set; }
        public string? PatientPhone { get; set; }
    }
}