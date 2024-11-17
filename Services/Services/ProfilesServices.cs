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
                var userData = await _context.Users.Where(x => x.UserId == dto.UserId).SingleOrDefaultAsync();
                if (userData.RoleId != 3)
                {
                    result.Data = null;
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "This user is not Employee";
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
                mapper.RatingAvg = 5;
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

        public async Task<StatusResponse<Profiles>> getProfile(int Userid)
        {
            try
            {
                var result = new StatusResponse<Profiles>();
                var data = await _profileRepository.Get().Where(x => x.UserId == Userid).SingleOrDefaultAsync();
                if (data == null)
                {
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "not found Profiles";
                    return result;
                }
                result.Data = data;
                result.statusCode = System.Net.HttpStatusCode.OK;
                result.Message = "Succesful";
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<Profiles>> getProfileUserifHaveApplication(int applicationId)
        {
            var result = new StatusResponse<Profiles>();
            try
            {
                var data = await _context.Applications.FindAsync(applicationId);
                if (data == null)
                {
                    result.statusCode = System.Net.HttpStatusCode.NotFound;
                    result.Message = "not found Application";
                    return result;
                }
                else
                {
                    var dataUser = await _context.Users.FindAsync(data.WorkerId);
                    if (dataUser == null)
                    {
                        result.statusCode = System.Net.HttpStatusCode.NotFound;
                        result.Message = "not found User";
                        return result;
                    }
                    else if (dataUser.RoleId == 3)
                    {
                        var dataProfile = await _context.Profiles.Where(x => x.UserId == dataUser.UserId).SingleOrDefaultAsync();
                        result.Data = dataProfile;
                        result.statusCode = System.Net.HttpStatusCode.OK;
                        result.Message = "Succesful";
                        return result;
                    }
                    else
                    {
                        result.statusCode = System.Net.HttpStatusCode.Forbidden;
                        result.Message = "You don't have Permission to see User Profile";
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                result.statusCode = System.Net.HttpStatusCode.InternalServerError;
                result.Message = ex.Message;
                return result;
            }
        }

        public async Task<StatusResponse<bool>> isFirstLogin(int userId)
        {
            try
            {
                var result = new StatusResponse<bool>();
                var data = await _context.Profiles.Where(x => x.UserId == userId).SingleOrDefaultAsync();
                if (data == null)
                {
                    result.Data = false;
                    result.statusCode = System.Net.HttpStatusCode.OK;
                    result.Message = "This is first time Employee login";
                    return result;
                }
                else
                {
                    result.Data = true;
                    result.statusCode = System.Net.HttpStatusCode.OK;
                    result.Message = "No need create profiles";
                    return result;
                }
            }
            catch (Exception ex)
            {
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
