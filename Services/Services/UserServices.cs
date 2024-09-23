using AutoMapper;
using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using DAO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Services.Services
{
    public class UserServices : IUserServices
    {
        private readonly IBaseRepository<User> _Userrepository;
        private readonly IMapper _mapper;
        private readonly HomieContext _context;

        public UserServices(IBaseRepository<User> userrepository, IMapper mapper, HomieContext context)
        {
            _Userrepository = userrepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<StatusResponse<UserResponseDTO>> CreateUser(UserRequestDTO user)
        {
            var response = new StatusResponse<UserResponseDTO>();
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    if (await CheckEmailExist(user.Email) || await CheckPhoneExist(user.Phone))
                    {
                        response.statusCode = HttpStatusCode.BadRequest;
                        response.Message = "Email or Phone existed.";
                        return response;
                    }
                    var createUser = _mapper.Map<User>(user);
                    createUser.AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg";
                    await _Userrepository.AddAsync(createUser);
                    await _Userrepository.SaveChangesAsync();
                    var result = await _Userrepository.Get().OrderBy(x => x.UserId).Include(x => x.Role).LastAsync();
                    var returned = _mapper.Map<UserResponseDTO>(result);
                    response.Data = returned;
                    response.statusCode = HttpStatusCode.OK;
                    response.Message = "Successful";
                    transaction.Commit();
                    return response;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }

        private async Task<bool> CheckEmailExist(string email)
        {
            var result = await _Userrepository.FindOne(x => x.Email.ToLower().Trim() == email.Trim().ToLower());
            if (result != null)
            {
                return true;
            }
            else
                return false;
        }

        private async Task<bool> CheckPhoneExist(string phone)
        {
            var result = await _Userrepository.FindOne(x => x.Phone.Trim() == phone.Trim());
            if (result != null)
            {
                return true;
            }
            else
                return false;
        }

        public Task<StatusResponse<bool>> DeletedUser(int userid)
        {
            throw new NotImplementedException();
        }

        public async Task<StatusResponse<GetAllUserResponseDTO>> getAll(int? pageNumber, int? pageSize)
        {
            var response = new StatusResponse<GetAllUserResponseDTO>();
            try
            {
                pageNumber ??= 1;
                pageSize ??= 15;

                if (pageNumber <= 0 || pageSize <= 0)
                {
                    response.statusCode = HttpStatusCode.BadRequest;
                    response.Message = "Page not found!";
                    return response;
                }
                var totalUsers = await _Userrepository.Get().CountAsync();
                var totalPages = (int)Math.Ceiling((double)totalUsers / pageSize.Value);

                var users = await _Userrepository.Get()
                    .Include(x => x.Role)
                    .OrderBy(u => u.UserId)
                    .Skip((pageNumber.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value)
                    .AsNoTracking()
                    .ToListAsync();

                var userDtos = users.Select(u => new UserResponseForPageDTO
                {
                    Id = u.UserId,
                    Name = u.Name,
                    Email = u.Email,
                    phone = u.Phone,
                    DateOfBirth = u.DateOfBirth,
                    AvatarUrl = u.AvatarUrl,
                    Gender = u.Gender,
                    status = u.Status,
                    RoleId = u.RoleId
                }).ToList();

                var responseDTO = new GetAllUserResponseDTO
                {
                    Result = userDtos,
                    TotalPages = totalPages,
                    CurrentPage = pageNumber.Value,
                    PageSize = pageSize.Value,
                    TotalItems = totalUsers
                };

                response.Data = responseDTO;
                response.statusCode = HttpStatusCode.OK;
                response.Message = "Successfully fetched users.";
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<StatusResponse<UserResponseDTO>> getUserById(int id)
        {
            var response = new StatusResponse<UserResponseDTO>();
            var user = await _Userrepository.GetById(id);
            if (user == null)
            {
                response.statusCode = HttpStatusCode.NotFound;
                response.Message = "Not Found user";
                return response;
            }
            var userResponseDto = _mapper.Map<UserResponseDTO>(user);
            response.Data = userResponseDto;
            response.statusCode = HttpStatusCode.OK;
            response.Message = "Succesful";
            return response;
        }

        public async Task<StatusResponse<UserResponseDTO>> UpdateUser(int userid, UserRequestDTO user)
        {
            var response = new StatusResponse<UserResponseDTO>();
            var existedUser = await _Userrepository.GetById(userid);
            if (existedUser != null)
            {
                existedUser.DateOfBirth = user.DateOfBirth;
                existedUser.Gender = user.Gender;
                existedUser.Name = user.Name;
                existedUser.Phone = user.Phone;
                existedUser.Email = user.Email;
                _Userrepository.Update(existedUser);
                await _Userrepository.SaveChangesAsync();
                var map = _mapper.Map<UserResponseDTO>(existedUser);
                response.Data = map;
                response.statusCode = HttpStatusCode.OK;
                response.Message = "Update Successful";
                return response;
            }
            else
            {
                response.statusCode = HttpStatusCode.NotFound;
                response.Message = "Not Found user";
                return response;
            }
        }
    }
}
