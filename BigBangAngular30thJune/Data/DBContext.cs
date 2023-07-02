using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BigBangAngular30thJune.Models;
using BigBangAngular30thJune.Authentication;

namespace BigBangAngular30thJune.Data
{
    public class DBContext : IdentityDbContext<ApplicationUser>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<TokenInfo> TokenInfo { get; set; }
        public DbSet<DoctorDetails> DoctorDetails { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
