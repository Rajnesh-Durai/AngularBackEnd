using BigBangAngular30thJune.Data;
using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBangAngular30thJune.Repository.AdminRepository
{
    public class AdminService:IAdminService
    {

        private readonly DBContext _dbContext;
        
        public AdminService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<string> AddDoctor(DoctorDetails doctorDetails)
        {
            var item= await _dbContext.DoctorDetails.AddAsync(doctorDetails);
            if (item == null)
            {
                throw new ArgumentNullException("No Doctors Found");
            }
            await _dbContext.SaveChangesAsync();
            return "Added Successfully";
        }
        public async Task<string> DeleteDoctors(int id)
        {
            var item = await _dbContext.DoctorDetails.FindAsync(id);

            if (item == null)
            {
                throw new ArgumentNullException("Appointment not found");
            }
            _dbContext.DoctorDetails.Remove(item);
            await _dbContext.SaveChangesAsync();
            return "Deleted Successfully";
        }
    }
}
