using Data_BaseLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_BaseLayer
{
    public class StudyContext : DbContext
    {
        public StudyContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}