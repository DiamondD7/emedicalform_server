using emedicalform_server.Model;
using Microsoft.EntityFrameworkCore;

namespace emedicalform_server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        public DbSet<Patients> Patients { get; set; }  
    }
}
