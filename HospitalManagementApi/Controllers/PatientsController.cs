using HospitalManagementBL.DTOs.PatientDTOs;
using HospitalManagementBL.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        readonly IPatientService _service;
        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(AddPatientDTO patientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _service.AddPatientAsync(patientDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            try
            {
                ICollection<GetPatientDTO> patients = await _service.GetAllPatientsAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPatientById(int Id)
        {
            try
            {
                GetPatientDTO patient = await _service.GetPatientByIdAsync(Id);
                return Ok(patient);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdatePatient(int Id, UpdatePatientDTO patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _service.UpdatePatientAsync(Id, patient);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("id")]
        public async Task<IActionResult> DeletePatient(int Id)
        {
            try
            {
                await _service.DeletePatientAsync(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("delete/id")]
        public async Task<IActionResult> SoftDeletePatient(int Id)
        {
            try
            {
                await _service.SoftDeletePatientAsync(Id);
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
