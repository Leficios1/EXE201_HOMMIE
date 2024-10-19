using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class MappingEntites : Profile
    {
        public MappingEntites()
        {
            CreateMap<UserRequestDTO, User>().ReverseMap();
            CreateMap<UserResponseDTO, User>().ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id)).ReverseMap();
            CreateMap<JobPost, JobPostRequestDTO>().ForMember(dest => dest.UserId, otp => otp.MapFrom(src => src.EmployerId)).ReverseMap();
            CreateMap<ProfilesRequestDTO, Profiles>().ReverseMap();
            CreateMap<EWalletResponse, EWallet>().ReverseMap();
            CreateMap<Application, ApplicationRequestDTO>().ReverseMap();
            CreateMap<Category, CategoryResponse>().ReverseMap(); 
        }


    }
}
