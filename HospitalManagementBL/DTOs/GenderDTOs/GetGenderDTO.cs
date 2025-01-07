using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.DTOs.GenderDTOs
{
    public class GetGenderDTO
    {
        public int Id { get; set; }
        public string PersonGender { get; set; }
        public ICollection<Patient>? Patients { get; set; }
        public bool isDelete { get; set; }
        public string? DeletedBy { get; set; }
        public string? DeletedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
    }
}
