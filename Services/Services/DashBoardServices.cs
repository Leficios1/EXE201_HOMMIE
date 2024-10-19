using AutoMapper;
using DAO.DTO.Reponse;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DashBoardServices : IDashBoardServices
    {
        private readonly HomieContext _context;
        private readonly IMapper _mapper;
        public DashBoardServices(HomieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<StatusResponse<decimal>> GetTotalAmountPaid()
        {
            var result = new StatusResponse<decimal>();
            try
            {
                var totalAmountPaid = await _context.JobPosts
                    .Where(p => p.Status.ToUpper().Equals("Done".ToUpper()))
                    .SumAsync(p => p.Price);

                result.Data = totalAmountPaid;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successfully retrieved total amount paid.";
            }
            catch (Exception ex)
            {
                result.statusCode = HttpStatusCode.InternalServerError;
                result.Message = $"Error: {ex.Message}";
            }

            return result;
        }

        public Task<StatusResponse<decimal>> GetTotalProfit()
        {
            throw new NotImplementedException();
        }

        public async Task<StatusResponse<List<RenuveByMonth>>> RenuveByMonth()
        {
            var result = new StatusResponse<List<RenuveByMonth>>();
            try
            {
                var applicationsPerMonth = await _context.Applications
                    .GroupBy(a => new { a.AppliedAt.Year, a.AppliedAt.Month })
                    .Select(g => new RenuveByMonth
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        Count = g.Count()
                    })
                    .OrderBy(x => x.Year).ThenBy(x => x.Month)
                    .ToListAsync();

                if (applicationsPerMonth != null && applicationsPerMonth.Any())
                {
                    result.Data = applicationsPerMonth;
                    result.statusCode = HttpStatusCode.OK;
                    result.Message = "Successfully retrieved application counts.";
                }
                else
                {
                    result.statusCode = HttpStatusCode.NotFound;
                    result.Message = "No application data found.";
                }

            }
            catch (Exception ex)
            {
                result.statusCode = HttpStatusCode.InternalServerError;
                result.Message = $"Error: {ex.Message}";
            }
            return result;
        }

        public async Task<StatusResponse<int>> TotalApplication()
        {
            var result = new StatusResponse<int>();
            try
            {
                var totalApplication = await _context.Applications.CountAsync();
                result.Data = totalApplication;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successful";
            }catch(Exception ex)
            {
                result.statusCode = HttpStatusCode.InternalServerError;
                result.Message = $"Error: {ex.Message}";
            }
            return result;
        }

        public async Task<StatusResponse<int>> TotalPost()
        {
            var result = new StatusResponse<int>();
            try
            {
                var totalPost = await _context.JobPosts.CountAsync();
                result.Data = totalPost;
                result.statusCode = HttpStatusCode.OK;
                result.Message = "Successful";
            }
            catch (Exception ex)
            {
                result.statusCode = HttpStatusCode.InternalServerError;
                result.Message = $"Error: {ex.Message}";
            }
            return result;
        }
    }
}
