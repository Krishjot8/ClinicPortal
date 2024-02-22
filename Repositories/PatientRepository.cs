using ClinicPortal_API.DataModels;
using ClinicPortal_API.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicPortal_API.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientAdminDbContext context;

        public PatientRepository(PatientAdminDbContext context)
        {
            this.context = context;
        }

      

        public async Task<Patients> GetPatient(int patientid)
        {
            return await context.Patients.FirstOrDefaultAsync(x => x.PatientId == patientid);
        }

        public async Task<Patients> GetPatientbyInsuranceId(long insuranceid)
        {

            return await context.Patients.FirstOrDefaultAsync(x => x.InsuranceId == insuranceid);
        }

        public async Task<PagedResults> GetPatients(int skip = 0, int take = 5)
        {

            var totalCount = await context.Patients.CountAsync();// total count for patients
            var patients = await context.Patients.Skip(skip).Take(take).ToListAsync(); //get patients for current page

            return new PagedResults
            {

                TotalCount = totalCount,
                Results = patients

            };
        }

       

        
    }
}
  