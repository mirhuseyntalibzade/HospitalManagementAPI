using FluentValidation;
using HospitalManagementBL.DTOs.GenderDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBL.Validators.GenderValidators
{
    public class UpdateGenderValidator : AbstractValidator<UpdateGenderDTO>
    {
        public UpdateGenderValidator()
        {
            RuleFor(address => address.PersonGender)
                .NotEmpty()
                .WithMessage("Gender is required.");
        }
    }
}
