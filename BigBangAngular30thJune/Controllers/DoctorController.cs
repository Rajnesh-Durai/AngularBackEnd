using BigBangAngular30thJune.Models;
using BigBangAngular30thJune.Repository.DoctorRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Controllers
{
    [Route("DoctorView")]
    [ApiController]
    public class DoctorController:ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [Authorize(Roles ="Doctor")]
        [HttpGet("Profile")]
        public async Task<ActionResult<DoctorDetails>> GetProfile(string name)
        {
            try
            {
                var item = await _doctorService.GetProfile(name);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Authorize(Roles = "Doctor,Admin")]
        [HttpPut("UpdateDetails")]
        public async Task<ActionResult<DoctorDetails>> UpdateDoctorDetails(DoctorDetails doctor, string name)
        {
            try
            {
                var item = await _doctorService.UpdateDoctorDetails(doctor,name);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Authorize(Roles = "Doctor")]
        [HttpGet("AppointmentDetails")]
        public async Task<ActionResult<List<DoctorDTO>>> GetAppointmentDetails(string name)
        {
            try
            {
                var item = await _doctorService.GetAppointmentDetails(name);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
