using HospitalManagementBL.Services.Abstractions;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Implementations
{
    public class GenderService : IGenderService
    {
        public Task AddGenderAsync(Gender gender)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGenderAsync(int Id, Gender gender)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Gender>> GetAllGendersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetGenderByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGenderAsync(int Id, Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
