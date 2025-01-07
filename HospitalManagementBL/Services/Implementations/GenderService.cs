using HospitalManagementBL.Services.Abstractions;
using HospitalManagementCORE.Models;
using HospitalManagementDAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Services.Implementations
{
    public class GenderService : IGenderService
    {
        readonly IGenderRepository _repository;
        public GenderService(IGenderRepository repository)
        {
            _repository = repository;
        }
        public async Task<ICollection<Gender>> GetAllGendersAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Gender> GetGenderByIdAsync(int Id)
        {
            Gender gender = await _repository.GetByIdAsync(Id);
            if (gender is null)
            {
                throw new Exception("Gender could not be found");
            }
            return gender;
        }
        
        public async Task AddGenderAsync(Gender gender)
        {
            await _repository.AddAsync(gender);
        }

        public async Task DeleteGenderAsync(int Id, Gender gender)
        {
            Gender deletedGender = await GetGenderByIdAsync(Id);
            _repository.Delete(deletedGender);
        }


        public async Task UpdateGenderAsync(int Id, Gender gender)
        {
            Gender updatedGender = await GetGenderByIdAsync(Id);
            _repository.Update(updatedGender);
        }
    }
}
