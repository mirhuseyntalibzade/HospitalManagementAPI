using HospitalManagementCORE.Enum;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.DTOs.PatientDTOs
{
    public class GetPatientDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DOB { get; set; }
        public string? PhoneNumber { get; set; }
        public string? SeriaNumber { get; set; }
        public string? RegistrationAddress { get; set; }
        public string? CurrentAddress { get; set; }
        public string? Email { get; set; }
        public int GenderId { get; set; }
        public int InsuranceId { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public bool isDelete { get; set; }
        public string? DeletedBy { get; set; }
        public string? DeletedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
    }
}
