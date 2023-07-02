using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBangAngular30thJune.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PatientName { get; set; }=string.Empty;
        public int PatientAge { get; set; }
        public string DiseaseName { get; set; } = string.Empty;
        [ForeignKey("DoctorDetails")]
        public int DoctorDetailsId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime AppointmentDate { get; set; }
        public string? AppointmentTime { get; set; }
    }
}
