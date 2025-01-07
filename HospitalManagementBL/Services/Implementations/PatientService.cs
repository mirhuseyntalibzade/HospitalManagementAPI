using HospitalManagementBL.Services.Abstractions;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Implementations
{
    public class PatientService : IPatientService
    {
        public Task AddPatientAsync(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task DeletePatientAsync(int Id, Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Patient>> GetAllPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetPatientByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatientAsync(int Id, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
