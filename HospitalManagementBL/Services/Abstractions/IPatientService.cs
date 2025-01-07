using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Abstractions
{
    public interface IPatientService
    {
        Task<ICollection<Patient>> GetAllPatientsAsync();
        Task<Patient> GetPatientByIdAsync();
        Task AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(int Id, Patient patient);
        Task DeletePatientAsync(int Id, Patient patient);
    }
}
