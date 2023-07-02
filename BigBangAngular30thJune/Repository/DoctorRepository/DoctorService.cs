using BigBangAngular30thJune.Data;
using BigBangAngular30thJune.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBangAngular30thJune.Repository.DoctorRepository
{
    public class DoctorService:IDoctorService
    {
        private readonly DBContext _dbContext;
        public DoctorService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DoctorDetails> GetProfile(string name)
        {
            var check= _dbContext.DoctorDetails.SingleOrDefault(x=>x.DoctorName==name);
            if (check == null)
            {
                throw new ArgumentNullException("No Profiles Found");
            }
            return check;
        }
        public async Task<DoctorDetails> UpdateDoctorDetails(DoctorDetails doctor, string name)
        {
            var existingDoctor =  _dbContext.DoctorDetails.SingleOrDefault(x => x.DoctorName == name);

            if (existingDoctor == null)
            {
                throw new ArgumentNullException("Doctor not found");
            }

            // Update the doctor's details
            existingDoctor.DoctorName = doctor.DoctorName;
            existingDoctor.Specialization = doctor.Specialization;
            existingDoctor.YearsOfExperience = doctor.YearsOfExperience;
            existingDoctor.EducationLevel = doctor.EducationLevel;
            existingDoctor.EmailId = doctor.EmailId;
            existingDoctor.PhoneNumber = doctor.PhoneNumber;
            existingDoctor.AlternatePhoneNumber = doctor.AlternatePhoneNumber;

            await _dbContext.SaveChangesAsync();
            return existingDoctor;
        }
        public async Task<List<DoctorDTO>> GetAppointmentDetails(string name)
        {
            var item = await ( from appmt in _dbContext.Appointments
                               join doc in _dbContext.DoctorDetails on appmt.DoctorDetailsId equals doc.Id
                               where doc.DoctorName==name
                               select new DoctorDTO
                               {
                                   PatientName = appmt.PatientName,
                                   PatientAge = appmt.PatientAge,
                                   DiseaseName = appmt.DiseaseName,
                                   AppointmentDate = appmt.AppointmentDate,
                                   AppointmentTime = appmt.AppointmentTime
                               }
                ).ToListAsync();
            if( item == null ) 
            {
                throw new ArgumentNullException("No Appointment For You");
            }
            return item;
        }
    }
}
