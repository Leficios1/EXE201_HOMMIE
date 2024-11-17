using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
     public class JobPostResponseDTO
    {
        public int JobId { get; set; }
        public int EmployerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal? SquareMeters { get; set; }
        public int? NumberOfFloors { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public int JobType { get; set; }
        public List<CategoryJobpost> CategoryJobPost { get; set; }
    }
    public class CategoryJobpost
    {
        public int CategoriesId { get; set; }
    }
}
