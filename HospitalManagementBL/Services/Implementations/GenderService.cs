using AutoMapper;
using HospitalManagementBL.DTOs.GenderDTOs;
using HospitalManagementBL.Services.Abstractions;
using HospitalManagementCORE.Models;
using HospitalManagementDAL.Repositories.Abstractions;

namespace HospitalManagementBL.Services.Implementations
{
    public class GenderService : IGenderService
    {
        readonly IGenderRepository _repository;
        readonly IMapper _mapper;
        public GenderService(IGenderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetGenderDTO>> GetAllGendersAsync()
        {
            ICollection<Gender> genders = await _repository.GetAllAsync();
            ICollection<GetGenderDTO> gendersDto = _mapper.Map<ICollection<GetGenderDTO>>(genders);
            return gendersDto;
        }

        public async Task<GetGenderDTO> GetGenderByIdAsync(int Id)
        {
            Gender gender = await _repository.GetGenderByIdWithPatients(Id);
            if (gender is null)
            {
                throw new Exception("Gender could not be found");
            }
            GetGenderDTO dto = _mapper.Map<GetGenderDTO>(gender);
            return dto;
        }
        
        public async Task AddGenderAsync(AddGenderDTO genderDTO)
        {
            Gender gender = _mapper.Map<Gender>(genderDTO);
            await _repository.AddAsync(gender);
            await _repository.SaveChangesAsync();
                        
        }

        public async Task DeleteGenderAsync(int Id)
        {
            Gender gender = await _repository.GetByIdAsync(Id);
            _repository.Delete(gender);
        }


        public async Task UpdateGenderAsync(int Id, UpdateGenderDTO updateGenderDTO)
        {
            await GetGenderByIdAsync(Id);

            Gender updatedGender = _mapper.Map<Gender>(updateGenderDTO);
            updatedGender.Id = Id;
            _repository.Update(updatedGender);
            _repository.SaveChangesAsync();
        }

        public async Task SoftDeleteGenderAsync(int Id)
        {
            Gender gender = await _repository.GetByIdAsync(Id);
            if (gender.isDeleted)
            {
                throw new Exception("Gender is already deleted.");
            }
            gender.isDeleted = true;
            gender.DeletedDate = DateTime.UtcNow.AddHours(4);
            _repository.Update(gender);
            await _repository.SaveChangesAsync();
        }

        public async Task RevertSoftDeleteAsync(int Id)
        {
            Gender gender = await _repository.GetByIdAsync(Id);
            if (!gender.isDeleted)
            {
                throw new Exception("Gender is already reverted.");
            }
            gender.isDeleted = false;
            gender.DeletedDate = null;
            _repository.Update(gender);
            await _repository.SaveChangesAsync();
        }
    }
}
