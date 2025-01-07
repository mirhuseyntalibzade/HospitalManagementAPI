using AutoMapper;
using HospitalManagementBL.DTOs.InsuranceDTOs;
using HospitalManagementCORE.Models;

namespace HospitalManagementBL.Profiles
{
    public class InsuranceProfiles : Profile
    {
        public InsuranceProfiles()
        {
            CreateMap<Insurance, GetInsuranceDTO>().ReverseMap();
            CreateMap<Insurance, AddInsuranceDTO>().ReverseMap();
            CreateMap<Insurance, UpdateInsuranceDTO>().ReverseMap();
        }
        
    }
}
