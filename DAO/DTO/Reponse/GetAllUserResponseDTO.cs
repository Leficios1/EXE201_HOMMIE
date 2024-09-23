using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
    public class GetAllUserResponseDTO
    {
        public List<UserResponseForPageDTO> Result { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
    public class UserResponseForPageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? AvatarUrl { get; set; }
        public string? Gender { get; set; }
        public bool status { get; set; }
        public int RoleId { get; set; }
    }
}
