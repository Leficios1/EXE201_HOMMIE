using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
    public class UserByTokenResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? phone { get; set; }
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int RoleId { get; set; }
        public string? AvatarUrl { get; set; }
        public string? Gender { get; set; }
        public bool status { get; set; }
    }
}
