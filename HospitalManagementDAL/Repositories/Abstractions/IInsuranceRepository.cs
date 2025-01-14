﻿using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL.Repositories.Abstractions
{
    public interface IInsuranceRepository : IGenericRepository<Insurance>
    {
        Task<Insurance> GetInsuranceByIdWithPatients(int Id);
    }
}
