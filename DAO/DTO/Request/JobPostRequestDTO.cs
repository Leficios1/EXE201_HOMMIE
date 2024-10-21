using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Request
{
    public class JobPostRequestDTO
    {
        //Thêm chiều rộng căn nhà và số tầng nếu User post bài
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal? SquareMeters { get; set; }
        public int? NumberOfFloors { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } //// 'open', 'in_progress', 'completed', 'cancelled'
        public DateTime CreateDate { get; set; }
        public List<JobPostCategory> Categorys { get; set; }

    }
    public class JobPostCategory
    {
        public int CategoryId { get; set; }
    }
}
