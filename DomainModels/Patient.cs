using System;

namespace ClinicPortal_API.DomainModels
{
    public class Patient
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long InsuranceId { get; set; }
        public string Gender { get; set; }
    }
}
