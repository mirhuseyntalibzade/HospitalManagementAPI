using AutoMapper;
using HospitalManagementBL.DTOs.InsuranceDTOs;
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
    public class InsuranceService : IInsuranceService
    {
        readonly IInsuranceRepository _repository;
        readonly IMapper _mapper;
        public InsuranceService(IInsuranceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetInsuranceDTO>> GetAllInsurancesAsync()
        {
            ICollection<Insurance> insurances = await _repository.GetAllAsync();
            ICollection<GetInsuranceDTO> insurancesDto = _mapper.Map<ICollection<GetInsuranceDTO>>(insurances);
            return insurancesDto;
        }

        public async Task<GetInsuranceDTO> GetInsuranceByIdAsync(int Id)
        {
            Insurance insurance = await _repository.GetInsuranceByIdWithPatients(Id);
            if (insurance is null)
            {
                throw new Exception("Insurance could not be found");
            }
            GetInsuranceDTO dto = _mapper.Map<GetInsuranceDTO>(insurance);
            return dto;
        }

        public async Task AddInsuranceAsync(AddInsuranceDTO insuranceDTO)
        {
            Insurance insurance = _mapper.Map<Insurance>(insuranceDTO);
            await _repository.AddAsync(insurance);
            await _repository.SaveChangesAsync();

        }

        public async Task DeleteInsuranceAsync(int Id)
        {
            Insurance insurance = await _repository.GetByIdAsync(Id);
            _repository.Delete(insurance);
        }


        public async Task UpdateInsuranceAsync(int Id, UpdateInsuranceDTO updateInsuranceDTO)
        {
            await GetInsuranceByIdAsync(Id);

            Insurance updatedInsurance = _mapper.Map<Insurance>(updateInsuranceDTO);
            updatedInsurance.Id = Id;
            _repository.Update(updatedInsurance);
            _repository.SaveChangesAsync();
        }

        public async Task SoftDeleteInsuranceAsync(int Id)
        {
            Insurance insurance = await _repository.GetByIdAsync(Id);
            if (insurance.isDeleted)
            {
                throw new Exception("Insurance is already deleted.");
            }
            insurance.isDeleted = true;
            insurance.DeletedDate = DateTime.UtcNow.AddHours(4);
            _repository.Update(insurance);
            await _repository.SaveChangesAsync();
        }

        public async Task RevertSoftDeleteAsync(int Id)
        {
            Insurance insurance = await _repository.GetByIdAsync(Id);
            if (!insurance.isDeleted)
            {
                throw new Exception("Insurance is already reverted.");
            }
            insurance.isDeleted = false;
            insurance.DeletedDate = null;
            _repository.Update(insurance);
            await _repository.SaveChangesAsync();
        }
    }
}
