using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBangAngular30thJune.Repository.DoctorRepository
{
    public class DoctorDTO
    {
        public string PatientName { get; set; } = string.Empty;
        public int PatientAge { get; set; }
        public string DiseaseName { get; set; } = string.Empty;

        [Column(TypeName = "Date")]
        public DateTime AppointmentDate { get; set; }
        public string? AppointmentTime { get; set; }
    }
}
