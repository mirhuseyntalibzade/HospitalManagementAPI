using HospitalManagementBL.DTOs.InsuranceDTOs;
using HospitalManagementBL.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancesController : ControllerBase
    {
        readonly IInsuranceService _service;
        public InsurancesController(IInsuranceService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddInsurance(AddInsuranceDTO patientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _service.AddInsuranceAsync(patientDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInsurances()
        {
            try
            {
                ICollection<GetInsuranceDTO> patients = await _service.GetAllInsurancesAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetInsuranceById(int Id)
        {
            try
            {
                GetInsuranceDTO patient = await _service.GetInsuranceByIdAsync(Id);
                return Ok(patient);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateInsurance(int Id, UpdateInsuranceDTO patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _service.UpdateInsuranceAsync(Id, patient);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("id")]
        public async Task<IActionResult> DeleteInsurance(int Id)
        {
            try
            {
                await _service.DeleteInsuranceAsync(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("delete/id")]
        public async Task<IActionResult> SoftDeleteInsurance(int Id)
        {
            try
            {
                await _service.SoftDeleteInsuranceAsync(Id);
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
