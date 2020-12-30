using System;
using Microsoft.EntityFrameworkCore;

namespace Studentz.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
    }
}
