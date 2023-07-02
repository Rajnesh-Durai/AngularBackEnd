using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Repository.AdminRepository
{
    public interface IAdminService
    {
 
        public Task<string> AddDoctor(DoctorDetails doctorDetails);
        public Task<string> DeleteDoctors(int id);
    }
}
