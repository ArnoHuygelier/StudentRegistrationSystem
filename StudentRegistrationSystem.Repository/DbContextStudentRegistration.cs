﻿using Microsoft.EntityFrameworkCore;
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

        public DbSet<Student> Students { get; set; }

        public DbSet<Cursus> Cursus { get; set; }

        public DbSet<Inschrijving> Inschrijvingen { get; set; }

        public DbSet<Docent> Docenten { get; set; }
    }
}
