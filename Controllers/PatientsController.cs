using AutoMapper;
using ClinicPortal_API.Db;
using ClinicPortal_API.DomainModels;
using ClinicPortal_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ClinicPortal_API.Controllers
{
    [ApiController]

    public class PatientsController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientsController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }



        [HttpGet]
        [Route("[controller]")]

        public async Task<IActionResult> GetAllPatients(int skip = 0, int take = 5)//
        {
            try
            {
                var pagedResults = await _patientRepository.GetPatients(skip, take);
                return Ok(pagedResults);

            }

            catch(Exception)
            {


                return StatusCode(500, "Internal server error");
            
            
            }
        }


        [HttpGet]
        [Route("[controller]/{PatientId:int}")]

        public  async Task<IActionResult> GetPatient([FromRoute] int PatientId)
        {                                                                 


            var patient = await _patientRepository.GetPatient(PatientId); //Fetch patient details from database


           if (patient == null) //if patient doesnt exist
            {
                return NotFound();
            }
            else
            {


                return Ok(_mapper.Map<Patient>(patient));//datamodel of patient will get
            }//converted to a domain model of patient
           
        }


     


    }
}
//Return Patient 