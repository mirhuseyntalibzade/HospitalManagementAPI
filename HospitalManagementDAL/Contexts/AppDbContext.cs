using HospitalManagementCORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients {  get; set; }
        public DbSet<Gender> Genders {  get; set; }
        public DbSet<Insurance> Insurances {  get; set; } 
        public AppDbContext(DbContextOptions opt) : base(opt) {}
    }
}
