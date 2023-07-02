using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Repository.DoctorRepository
{
    public interface IDoctorService
    {
        public Task<DoctorDetails> GetProfile(string name);
        public Task<DoctorDetails> UpdateDoctorDetails(DoctorDetails doctor, string name);
        public Task<List<DoctorDTO>> GetAppointmentDetails(string name);
    }
}
