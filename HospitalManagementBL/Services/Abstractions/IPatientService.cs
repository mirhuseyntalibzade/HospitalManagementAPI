using HospitalManagementBL.DTOs.PatientDTOs;
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
        Task<ICollection<GetPatientDTO>> GetAllPatientsAsync();
        Task<GetPatientDTO> GetPatientByIdAsync(int Id);
        Task AddPatientAsync(AddPatientDTO genderDTO);
        Task UpdatePatientAsync(int Id, UpdatePatientDTO genderDTO);
        Task DeletePatientAsync(int Id);
        Task SoftDeletePatientAsync(int Id);
        Task RevertSoftDeleteAsync(int Id);
    }
}
