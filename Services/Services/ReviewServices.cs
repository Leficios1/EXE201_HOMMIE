using AutoMapper;
using DAO.DTO.Reponse;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Services.Services
{
    public class ReviewServices : IReviewServices
    {
        private readonly HomieContext _context;
        private readonly IMapper _mapper;

        public ReviewServices(HomieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<ReviewResponseDTO>> create(ReviewRequestDTO dto)
        {
            var respone = new StatusResponse<ReviewResponseDTO>();
            var transaction = _context.Database.BeginTransaction();
            try
            {
                var flagCheck = await _context.JobPosts.Where(x => x.JobId == dto.JobId).SingleOrDefaultAsync();
                if (flagCheck == null || flagCheck.Status != "Done")
                {
                    respone.statusCode = HttpStatusCode.BadRequest;
                    respone.Message = "This Job not Done";
                    return respone;
                }
                var mapper = _mapper.Map<Review>(dto);
                await _context.Reviews.AddAsync(mapper);
                await _context.SaveChangesAsync();
                var reviewName = await _context.Users.Where(x => x.UserId == dto.ReviewerId).Select(x => x.Name).SingleOrDefaultAsync();
                if (string.IsNullOrEmpty(reviewName))
                {
                    respone.statusCode = HttpStatusCode.NotFound;
                    respone.Message = "Not found Review user";
                    return respone;
                }
                var result = _mapper.Map<ReviewResponseDTO>(mapper);
                result.ReviewerName = reviewName;

                transaction.Commit();
                respone.Data = result;
                respone.statusCode = HttpStatusCode.OK;
                respone.Message = "Review Successful";
                return respone;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                respone.statusCode = HttpStatusCode.InternalServerError;
                respone.Message = ex.Message;
                return respone;
            }
        }

        public async Task<StatusResponse<bool>> deleted(int reviewId)
        {
            var respone = new StatusResponse<bool>();
            try
            {
                var data = await _context.Reviews.FindAsync(reviewId);
                if (data == null)
                {
                    respone.Data = false;
                    respone.statusCode = HttpStatusCode.NotFound;
                    respone.Message = "Not found Review";
                    return respone;
                }
                _context.Remove(data);
                await _context.SaveChangesAsync();
                respone.Data = true;
                respone.statusCode = HttpStatusCode.OK;
                respone.Message = "Successful";
                return respone;
            }
            catch (Exception ex)
            {
                respone.Data = false;
                respone.statusCode = HttpStatusCode.InternalServerError;
                respone.Message = ex.Message;
                return respone;
            }
        }

        public async Task<StatusResponse<List<ReviewResponseDTO>>> getByJobPostId(int jobPostId)
        {
            var response = new StatusResponse<List<ReviewResponseDTO>>();
            var data = await _context.Reviews.Where(x => x.JobId == jobPostId).Include(r => r.Reviewer).ToListAsync();
            var mapper = _mapper.Map<List<ReviewResponseDTO>>(data);
            response.Data = mapper;
            response.statusCode = HttpStatusCode.OK;
            response.Message = "Succesful";
            return response;
        }
    }
}
