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
        Task<ICollection<Gender>> GetAllGendersAsync();
        Task<Gender> GetGenderByIdAsync(int Id);
        Task AddGenderAsync(Gender gender);
        Task UpdateGenderAsync(int Id, Gender gender);
        Task DeleteGenderAsync(int Id, Gender gender);
    }
}
