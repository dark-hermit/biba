using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectVS2019.Models;

namespace ProjectVS2019.Data
{
    public class ProjectVS2019Context : DbContext
    {
        public ProjectVS2019Context (DbContextOptions<ProjectVS2019Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Vote> Elections { get; set; }
        public DbSet<Election> Votes { get; set; }
    }
}
