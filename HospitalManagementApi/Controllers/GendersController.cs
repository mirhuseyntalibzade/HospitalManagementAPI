using HospitalManagementBL.DTOs.GenderDTOs;
using HospitalManagementBL.Services.Abstractions;
using HospitalManagementBL.Validators.GenderValidators;
using HospitalManagementCORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        readonly IGenderService _service;
        public GendersController(IGenderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddGender(AddGenderDTO genderDTO)
        {
            var validator = new AddGenderValidator();
            var results = validator.Validate(genderDTO);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    return BadRequest($"Error: {failure.ErrorMessage}");
                }
            }
            try
            {
                await _service.AddGenderAsync(genderDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenders()
        {
            try
            {
               ICollection<GetGenderDTO> genders= await _service.GetAllGendersAsync();
                return Ok(genders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpGet("id")]
        public async Task<IActionResult> GetGenderById(int Id)
        {
            try
            {
                GetGenderDTO gender = await _service.GetGenderByIdAsync(Id);
                return Ok(gender);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateGender(int Id, UpdateGenderDTO gender)
        {
            var validator = new UpdateGenderValidator();
            var results = validator.Validate(gender);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    return BadRequest($"Error: {failure.ErrorMessage}");
                }
            }
            try
            {
                await _service.UpdateGenderAsync(Id, gender);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("id")]
        public async Task<IActionResult> DeleteGender(int Id)
        {
            try
            {
                await _service.DeleteGenderAsync(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("delete/id")]
        public async Task<IActionResult> SoftDeleteGender(int Id)
        {
            try
            {
                await _service.SoftDeleteGenderAsync(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("revert/id")]

        public async Task<IActionResult> RevertSoftDelete(int Id)
        {
            try
            {
                await _service.RevertSoftDeleteAsync(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
