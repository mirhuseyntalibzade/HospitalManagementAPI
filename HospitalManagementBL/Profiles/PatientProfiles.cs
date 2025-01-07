using AutoMapper;
using HospitalManagementBL.DTOs.PatientDTOs;
using HospitalManagementCORE.Models;

namespace HospitalManagementBL.Profiles
{
    public class PatientProfiles : Profile
    {
        public PatientProfiles()
        {
            CreateMap<Patient, GetPatientDTO>().ReverseMap();
            CreateMap<Patient, AddPatientDTO>().ReverseMap();
            CreateMap<Patient, UpdatePatientDTO>().ReverseMap();
        }
    }
}
