using AutoMapper;
using DemoBLL.DTOS.EmployeeModule;
using DemoDAL.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee,GetAllEmployeeDTO>()
                .ForMember(dest=>dest.EmpGender , option=>option.MapFrom(sour=>sour.Gender))
                .ForMember(dest=>dest.EmployeeType , option=>option.MapFrom(sour=>sour.EmployeeType));

            CreateMap<Employee,GetEmployeeDetailsDTO>()
                .ForMember(dest=>dest.HiringDate,option=>option.MapFrom(sour=>DateOnly.FromDateTime(sour.HiringDate)))
                .ForMember(dest => dest.Gender, option => option.MapFrom(sour => sour.Gender))
                .ForMember(dest => dest.EmployeeType, option => option.MapFrom(sour => sour.EmployeeType));

            CreateMap<AddEmployeeDTO, Employee>()
                .ForMember(dest => dest.HiringDate, option => option.MapFrom(sour => sour.HiringDate.ToDateTime(TimeOnly.MinValue)))
                .ForMember(dest => dest.Gender, option => option.MapFrom(sour => sour.Gender))
                .ForMember(dest => dest.EmployeeType, option => option.MapFrom(sour => sour.EmployeeType));

            CreateMap<UpdateEmployeeDTO, Employee>()
                .ForMember(dest => dest.HiringDate, option => option.MapFrom(sour => sour.HiringDate.ToDateTime(TimeOnly.MinValue)))
                .ForMember(dest => dest.Gender, option => option.MapFrom(sour => sour.Gender))
                .ForMember(dest => dest.EmployeeType, option => option.MapFrom(sour => sour.EmployeeType));

            //CreateMap<Employee, UpdateEmployeeDTO>().ReverseMap();
        }
    }
}
