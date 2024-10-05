using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Request
{
    public class JobPostRequestDTO
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } //// 'open', 'in_progress', 'completed', 'cancelled'
        public DateTime CreateDate { get; set; }
    }
}
