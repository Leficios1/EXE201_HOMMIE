using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProfilesServices : IProfilesServices
    {
        private readonly IBaseRepository<Profiles> _profileRepository;
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public ProfilesServices(IBaseRepository<Profiles> profileRepository, HomieContext context, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<Profiles>> CreateProfiles(ProfilesRequestDTO dto)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var result = new StatusResponse<Profiles>();
                if (dto == null)
                {
                    result.Data = null;
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "DTO null";
                    return result;
                }
                var data = await _profileRepository.Get().Where(x => x.UserId == dto.UserId).SingleOrDefaultAsync();
                if (data != null)
                {
                    result.Data = null;
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "This user has Profiles";
                    return result;
                }
                var mapper = _mapper.Map<Profiles>(dto);
                await _profileRepository.AddAsync(mapper);
                await _profileRepository.SaveChangesAsync();
                transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }

        }

        public async Task<StatusResponse<Profiles>> UpdateProfiles(int id, ProfilesRequestDTO dto)
        {
            try
            {
                var result = new StatusResponse<Profiles>();
                if (dto == null)
                {
                    result.Data = null;
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "DTO null";
                    return result;
                }
                var data = await _profileRepository.GetById(id);
                if (data == null)
                {
                    result.Data = null;
                    result.statusCode = System.Net.HttpStatusCode.NotFound;
                    result.Message = "Not found Profiles";
                }
                else
                {
                    data.Bio = dto.Bio;
                    data.Skills = dto.Skills;
                    data.Experience = dto.Experience;
                    data.Availability = dto.Availability;
                    data.RatingAvg = dto.RatingAvg;
                    _profileRepository.Update(data);
                    result.Data = data;
                    result.Message = "Successful";
                    result.statusCode = System.Net.HttpStatusCode.OK;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
