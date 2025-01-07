using HospitalManagementCORE.Models;

namespace HospitalManagementBL.Services.Abstractions
{
    public interface IInsuranceService
    {
        Task<ICollection<Insurance>> GetAllInsurancesAsync();
        Task<Insurance> GetInsuranceByIdAsync(int Id);
        Task AddInsuranceAsync(Insurance insurance);
        Task UpdateInsuranceAsync(int Id, Insurance insurance);
        Task DeleteInsuranceAsync(int Id, Insurance insurance);
    }
}
