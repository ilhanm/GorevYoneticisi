using Microsoft.EntityFrameworkCore;
using System;
namespace GorevYoneticisi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        
        public DbSet<Models.Gorev> Gorev { get; set; }
        
    }
}
