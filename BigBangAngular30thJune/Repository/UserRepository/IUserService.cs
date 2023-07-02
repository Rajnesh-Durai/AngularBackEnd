using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Repository.DoctorRepository
{
    public interface IUserService
    {
        public Task<List<DoctorDetails>> GetAllDoctors();
        public Task<List<DoctorDetails>> GetDoctors(string name);
        public Task<Appointment> BookAppointment(Appointment appointment);
    }
}
