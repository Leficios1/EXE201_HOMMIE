using DAO.DTO.Reponse;
using DAO.DTO.Request;
using DAO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Repository.Interface;
using Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly IBaseRepository<User> _userRepo;
        private readonly IConfiguration _configuration;
        public AuthServices(IBaseRepository<User> userRepo, IConfiguration configuration)
        {
            _userRepo = userRepo;
            _configuration = configuration;
        }

        public async Task<StatusResponse<TokenReponse>> LoginAccount(AuthRequestDTO dto)
        {
            var response = new StatusResponse<TokenReponse>();
            try
            {
                var checkUser = await _userRepo.Get().Include(x => x.Role).Where(x => x.Password == dto.Password && x.Email.ToLower().Trim() == dto.Email.ToLower().Trim()).FirstOrDefaultAsync();

                if (checkUser == null)
                {
                    response.statusCode = HttpStatusCode.Unauthorized;
                    response.Message = "Thông tin đăng nhập không đúng!!!";
                    return response;
                }
                else
                {
                    JwtSecurityToken token = GetToken(checkUser);

                    var returnedToken = new TokenReponse()
                    {
                        TokenString = new JwtSecurityTokenHandler().WriteToken(token),
                        Expiration = token.ValidTo
                    };
                    response.Data = returnedToken;
                    response.statusCode = HttpStatusCode.OK;
                    response.Message = "Login Successful!";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.statusCode = HttpStatusCode.InternalServerError;
                response.Message = ex.Message;
                return response;
            }
        }

        public JwtSecurityToken GetToken(User user)
        {
            List<Claim> authClaims = new List<Claim>
            {
                 new Claim(ClaimTypes.Name, user.Name),
                 new Claim(ClaimTypes.Email, user.Email),
                 new Claim(ClaimTypes.Role, user.RoleId.ToString()),
                 new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString())
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(

                issuer: _configuration["JWT:ValidAudience"],
                audience: _configuration["JWT:ValidIssuer"],
                claims: authClaims,
                expires: DateTime.Now.AddDays(3),
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }

        public ClaimsPrincipal DecodeToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]);

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "http://localhost:5028",
                    ValidAudience = "http://localhost:5028",
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var claimsIdentity = new ClaimsIdentity(jwtToken.Claims);

                return new ClaimsPrincipal(claimsIdentity);
            }
            catch (Exception ex)
            {
                // Xử lý trường hợp token không hợp lệ
                Console.WriteLine($"Token validation failed: {ex.Message}");
                return null;
            }
        }
        public async Task<UserByTokenResponse> GetUserByToken(string token)
        {
            var principals = DecodeToken(token);
            if (principals == null) throw new BadHttpRequestException("The token is invalid");

            var idClaim = principals.FindFirst(ClaimTypes.NameIdentifier);
            if (idClaim == null) throw new Exception("Token is invalid. There is no indentity of name");

            var id = idClaim.Value;
            var user = await _userRepo.Get().Select(x => new UserByTokenResponse()
            {
                Id = x.UserId,
                Name = x.Name,
                status = x.Status,
                DateOfBirth = x.DateOfBirth,
                AvatarUrl = x.AvatarUrl,
                Gender = x.Gender,
                Email = x.Email,
                phone = x.Phone,
                RoleId = x.RoleId,

            }).FirstOrDefaultAsync(x => x.Id.ToString().Equals(id));

            if (user == null) throw new Exception("There is no user has by id:");

            return user;

        }
        private long ToUnixEpochDate(DateTime date)
        {
            return (long)Math.Round((date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }
    }
}

