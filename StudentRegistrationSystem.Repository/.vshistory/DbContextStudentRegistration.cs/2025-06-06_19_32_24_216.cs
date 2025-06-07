using Microsoft.EntityFrameworkCore;
using StudentRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Repository
{
    public class DbContextStudentRegistration : DbContext
    {
        public DbContextStudentRegistration(DbContextOptions<DbContextStudentRegistration> options) : base(options)
        {
            
        }

        public DbSet<Student> students { get; set; }

        public DbSet<Cursus> cursus { get; set; }

        public DbSet<Inschrijving> inschrijvingen { get; set; }

        public DbSet<Docent> Docenten { get; set; }
    }
}
