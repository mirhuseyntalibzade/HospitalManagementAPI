using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.DTOs.InsuranceDTOs
{
    public class UpdateInsuranceDTO
    {
        public string? PersonInsurance { get; set; }
        public float Discount { get; set; }
    }
}
