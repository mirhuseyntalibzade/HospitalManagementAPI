using HospitalManagementBL.DTOs.GenderDTOs;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Abstractions
{
    public interface IGenderService
    {
        Task<ICollection<GetGenderDTO>> GetAllGendersAsync();
        Task<GetGenderDTO> GetGenderByIdAsync(int Id);
        Task AddGenderAsync(AddGenderDTO genderDTO);
        Task UpdateGenderAsync(int Id, UpdateGenderDTO genderDTO);
        Task DeleteGenderAsync(int Id);
        Task SoftDeleteGenderAsync(int Id);
        Task RevertSoftDeleteAsync(int Id);
    }
}
