using AutoMapper;
using Homework4.Entity.Dto;
using Homework4.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, DtoEmployee>().ReverseMap();
            CreateMap<Request, DtoRequest>().ReverseMap();
            CreateMap<Department, DtoDepartment>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<User, DtoLoginUser>();
            CreateMap<DtoLogin, User>();
        }
    }
}
