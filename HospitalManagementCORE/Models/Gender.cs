using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementCORE.Models
{
    public class Gender : BaseEntity
    {
        public string? PersonGender { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
