using System;
using Microsoft.EntityFrameworkCore;
using Studentz.Models;

namespace Studentz.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }

        public DbSet<Studentz.Models.Course> Course { get; set; }
    }
}
