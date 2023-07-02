using BigBangAngular30thJune.Models;
using BigBangAngular30thJune.Repository.AdminRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BigBangAngular30thJune.Controllers
{
    [Route("AdminView")]
    [ApiController]
    public class OwnerController:ControllerBase
    {
        private readonly IAdminService _adminService;
        public OwnerController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("AddNewDoctor")]
        public async Task<ActionResult<string>> AddDoctor(DoctorDetails doctorDetails)
        {
            try
            {
                var item = await _adminService.AddDoctor(doctorDetails);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("RemoveADoctor")]
        public async Task<ActionResult<string>> DeleteDoctors(int id)
        {
            try
            {
                var item = await _adminService.DeleteDoctors(id);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
