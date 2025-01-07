using HospitalManagementCORE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementCORE.Models
{
    public class Patient : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DOB { get; set; }
        public string? PhoneNumber { get; set; }
        public string? SeriaNumber { get; set; }
        public string? RegistrationAddress { get; set; }
        public string? CurrentAddress { get; set; }
        public string? Email { get; set; }

        public int GenderId { get; set; }
        public Gender? Gender { get; set; }
        
        public int InsuranceId { get; set; }
        public Insurance? Insurance { get; set; }
        
        public BloodGroup BloodGroup { get; set; }
    }
}
