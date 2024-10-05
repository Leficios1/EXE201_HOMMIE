using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ApplicationServices : IApplication
    {
        private readonly IBaseRepository<Application> _applicationRepository;
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public ApplicationServices(IBaseRepository<Application> applicationRepository, IMapper mapper, HomieContext context)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<StatusResponse<bool>> applicationJobPost(ApplicationRequestDTO dto)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var result = new StatusResponse<bool>();
                var data = _mapper.Map<Application>(dto);
                data.Status = "Pending";
                data.AppliedAt = DateTime.UtcNow;
                await _applicationRepository.AddAsync(data);
                await _applicationRepository.SaveChangesAsync();
                result.Data = true;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successful";
                transaction.Commit();
                return result;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public async Task<StatusResponse<bool>> changeStatus(int id, string status)
        {
            try
            {
                var result = new StatusResponse<bool>();
                var data = await _applicationRepository.GetById(id);
                if(data == null)
                {
                    result.Data = false;
                    result.statusCode= HttpStatusCode.BadRequest;
                    result.Message = "Not Found Application";
                    return result;
                }
                data.Status = status;
                _applicationRepository.Update(data);
                result.Data= true;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
