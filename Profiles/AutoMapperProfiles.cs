using AutoMapper;
using ClinicPortal_API.DomainModels;
using  ClinicPortal_API.DataModels;


namespace ClinicPortal_API.Profiles
{
    public class AutoMapperProfiles : Profile
    {


        public AutoMapperProfiles()
        {
            CreateMap<Patients, Patient>()              //Creating maps for tables
             .ReverseMap();
        }
    }

}