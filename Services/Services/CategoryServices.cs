using AutoMapper;
using DAO.DTO.Reponse;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IBaseRepository<Category> _Categoryrepository;
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public CategoryServices(IBaseRepository<Category> categoryrepository, HomieContext context, IMapper mapper)
        {
            _Categoryrepository = categoryrepository;
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<List<CategoryResponse>>> getAllCategory()
        {
            try
            {
                var result = new StatusResponse<List<CategoryResponse>>();
                var data = await _Categoryrepository.Get().ToListAsync();
                if(data != null)
                {
                    var mapper = _mapper.Map<List<CategoryResponse>>(data);
                    result.Data = mapper;
                    result.statusCode = System.Net.HttpStatusCode.OK;
                    result.Message = "Successful";
                }
                else
                {
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "DB Null";
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }

        public async Task<StatusResponse<CategoryResponse>> getCategoryById(int id)
        {
            try
            {
                var result = new StatusResponse<CategoryResponse>();
                var data = await _Categoryrepository.GetById(id);
                if (data != null)
                {
                    var mapper = _mapper.Map<CategoryResponse>(data);
                    result.Data = mapper;
                    result.statusCode = System.Net.HttpStatusCode.OK;
                    result.Message = "Successful";
                }
                else
                {
                    result.statusCode = System.Net.HttpStatusCode.BadRequest;
                    result.Message = "DB Null";
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
