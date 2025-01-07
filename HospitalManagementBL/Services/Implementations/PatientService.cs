using AutoMapper;
using HospitalManagementBL.DTOs.PatientDTOs;
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
    public class PatientService : IPatientService
    {
        readonly IPatientRepository _repository;
        readonly IMapper _mapper;
        public PatientService(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetPatientDTO>> GetAllPatientsAsync()
        {
            ICollection<Patient> patients = await _repository.GetAllAsync();
            ICollection<GetPatientDTO> patientsDto = _mapper.Map<ICollection<GetPatientDTO>>(patients);
            return patientsDto;
        }

        public async Task<GetPatientDTO> GetPatientByIdAsync(int Id)
        {
            Patient patient = await _repository.GetByIdAsync(Id);
            if (patient is null)
            {
                throw new Exception("Patient could not be found");
            }
            GetPatientDTO dto = _mapper.Map<GetPatientDTO>(patient);
            return dto;
        }

        public async Task AddPatientAsync(AddPatientDTO patientDTO)
        {
            Patient patient = _mapper.Map<Patient>(patientDTO);
            await _repository.AddAsync(patient);
            await _repository.SaveChangesAsync();

        }

        public async Task DeletePatientAsync(int Id)
        {
            Patient patient = await _repository.GetByIdAsync(Id);
            _repository.Delete(patient);
        }


        public async Task UpdatePatientAsync(int Id, UpdatePatientDTO updatePatientDTO)
        {
            await GetPatientByIdAsync(Id);

            Patient updatedPatient = _mapper.Map<Patient>(updatePatientDTO);
            updatedPatient.Id = Id;
            _repository.Update(updatedPatient);
            _repository.SaveChangesAsync();
        }

        public async Task SoftDeletePatientAsync(int Id)
        {
            Patient patient = await _repository.GetByIdAsync(Id);
            if (patient.isDeleted)
            {
                throw new Exception("Patient is already deleted.");
            }
            patient.isDeleted = true;
            patient.DeletedDate = DateTime.UtcNow.AddHours(4);
            _repository.Update(patient);
            await _repository.SaveChangesAsync();
        }

        public async Task RevertSoftDeleteAsync(int Id)
        {
            Patient patient = await _repository.GetByIdAsync(Id);
            if (!patient.isDeleted)
            {
                throw new Exception("Patient is already reverted.");
            }
            patient.isDeleted = false;
            patient.DeletedDate = null;
            _repository.Update(patient);
            await _repository.SaveChangesAsync();
        }
    }
}
