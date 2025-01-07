using HospitalManagementBL.Services.Abstractions;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Implementations
{
    public class InsuranceService : IInsuranceService
    {
        public Task AddInsuranceAsync(Insurance insurance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInsuranceAsync(int Id, Insurance insurance)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Insurance>> GetAllInsurancesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Insurance> GetInsuranceByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateInsuranceAsync(int Id, Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
