using ClinicPortal_API.Db;
using System.Collections.Generic;

namespace ClinicPortal_API.DataModels
{
    public class PagedResults
    {

        public int TotalCount { get; set; }

        public IEnumerable<Patients> Results { get; set; }

      
    }
}
