using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
    public class ReviewResponseDTO
    {
        public int ReviewId {  get; set; }
        public string ReviewerName { get; set; }
        public int ReviewedId {  get; set; }
        public int JobId { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
