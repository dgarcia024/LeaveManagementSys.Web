using LeaveManagementSys.Web.Data.DBModels;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSys.Web.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
    }
}
