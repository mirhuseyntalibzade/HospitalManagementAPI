using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementCORE.Models
{
    public class Gender : BaseAuditableEntity
    {
        public string? PersonGender { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}
