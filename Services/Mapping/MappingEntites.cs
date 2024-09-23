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
        }
    }
}
