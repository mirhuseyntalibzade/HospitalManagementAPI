﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementCORE.Models
{
    public class Insurance : BaseEntity
    {
        public string? PersonInsurance { get; set; }
        public float Discount { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
