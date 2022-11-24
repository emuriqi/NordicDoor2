using Microsoft.EntityFrameworkCore;
using NordicDoor.Models;
using NordicDoorWeb.Models;


namespace NordicDoorWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public DbSet<AnsattModel> Ansatte { get; set; }
        public DbSet<ForslagModel> Forslags { get; set; }

    }
}