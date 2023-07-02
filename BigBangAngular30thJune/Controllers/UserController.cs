using BigBangAngular30thJune.Models;
using BigBangAngular30thJune.Repository.DoctorRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Controllers
{
    [Route("PatientView")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [Authorize(Roles ="Patient,Admin")]
        [HttpGet("ListOfDoctors")]
        public async Task<ActionResult<List<DoctorDetails>>> GetAllDoctors()
        {
            try
            {
                var item = await _userService.GetAllDoctors();
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Authorize(Roles = "Patient,Admin")]
        [HttpGet("DoctorsBased")]
        public async Task<ActionResult<List<DoctorDetails>>> GetDoctors( string name)
        {
            try
            {
                var item = await _userService.GetDoctors(name);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Authorize(Roles = "Patient,Admin")]
        [HttpPost("BookingAnAppointmant")]
        public async Task<ActionResult<Appointment>> BookAppointment(Appointment appointment)
        {
            try
            {
                var item = await _userService.BookAppointment(appointment);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
