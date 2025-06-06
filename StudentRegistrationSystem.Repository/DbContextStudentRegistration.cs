using Microsoft.EntityFrameworkCore;
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
    }
}
