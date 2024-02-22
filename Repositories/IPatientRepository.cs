using ClinicPortal_API.DataModels;
using ClinicPortal_API.Db;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ClinicPortal_API.Repositories
{
    public interface IPatientRepository
    {

    

        Task<Patients> GetPatient(int patientid);


        Task<Patients> GetPatientbyInsuranceId(long InsuranceId);


        Task<PagedResults>GetPatients(int skip = 0, int take = 5);

    }
}
