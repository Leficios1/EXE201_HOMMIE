using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Request
{
    public class ProfilesRequestDTO
    {
        public int UserId { get; set; }
        public string? Bio { get; set; }
        public string? Skills { get; set; }
        public string Experience { get; set; }
        public string? Availability { get; set; }
        public decimal RatingAvg { get; set; }
    }
}
