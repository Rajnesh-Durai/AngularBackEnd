using BigBangAngular30thJune.Data;
using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBangAngular30thJune.Repository.DoctorRepository
{
    public class UserService:IUserService
    {
        private readonly DBContext _dbContext;
        public UserService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<DoctorDetails>> GetAllDoctors()
        {
            var item= await _dbContext.DoctorDetails.ToListAsync();
            if(item == null)
            {
                throw new ArgumentNullException("No Doctors Found");
            }
            return item;
        }
        public async Task<List<DoctorDetails>> GetDoctors(string name)
        {
            var item= await _dbContext.DoctorDetails.Where(x=>x.Specialization==name).Distinct().ToListAsync();
            if(item == null)
            {
                throw new ArgumentNullException("No doctors available");
            }
            return item;
        }
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            var item= await _dbContext.Appointments.AddAsync(appointment);
            if (item == null)
            {
                throw new ArgumentNullException("Appointment not Done");
            }
            await _dbContext.SaveChangesAsync();
            return item.Entity;
        }
    }
}
