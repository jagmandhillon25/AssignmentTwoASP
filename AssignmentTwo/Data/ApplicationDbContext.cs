using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AssignmentTwo.Models;

namespace AssignmentTwo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AssignmentTwo.Models.Category>? Category { get; set; }
        public DbSet<AssignmentTwo.Models.Event>? Event { get; set; }
    }
}