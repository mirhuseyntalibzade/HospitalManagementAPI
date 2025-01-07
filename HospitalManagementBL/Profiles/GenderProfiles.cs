using AutoMapper;
using HospitalManagementBL.DTOs.GenderDTOs;
using HospitalManagementCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Profiles
{
    public class GenderProfiles : Profile
    {
        public GenderProfiles()
        {
            CreateMap<Gender, GetGenderDTO>().ReverseMap();
            CreateMap<Gender, AddGenderDTO>().ReverseMap();
            CreateMap<Gender, UpdateGenderDTO>().ReverseMap();
        }
    }
}
