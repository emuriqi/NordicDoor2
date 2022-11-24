using Microsoft.EntityFrameworkCore;
using NordicDoorWeb.Models;


namespace NordicDoorWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public DbSet<AnsattModel> Ansatte { get; set; }    
    }
}