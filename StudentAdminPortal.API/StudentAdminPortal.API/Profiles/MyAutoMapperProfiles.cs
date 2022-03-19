using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.Models;

namespace StudentAdminPortal.API.Profiles
{
    public class MyAutoMapperProfiles:Profile
    {
        public MyAutoMapperProfiles()
        {
            CreateMap<Student,StudentDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Adress, AdressDto>().ReverseMap();

        }
    }
}
