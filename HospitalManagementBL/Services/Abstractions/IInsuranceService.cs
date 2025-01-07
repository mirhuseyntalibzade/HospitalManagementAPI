using HospitalManagementBL.DTOs.InsuranceDTOs;
using HospitalManagementCORE.Models;

namespace HospitalManagementBL.Services.Abstractions
{
    public interface IInsuranceService
    {
        Task<ICollection<GetInsuranceDTO>> GetAllInsurancesAsync();
        Task<GetInsuranceDTO> GetInsuranceByIdAsync(int Id);
        Task AddInsuranceAsync(AddInsuranceDTO genderDTO);
        Task UpdateInsuranceAsync(int Id, UpdateInsuranceDTO genderDTO);
        Task DeleteInsuranceAsync(int Id);
        Task SoftDeleteInsuranceAsync(int Id);
        Task RevertSoftDeleteAsync(int Id);
    }
}
