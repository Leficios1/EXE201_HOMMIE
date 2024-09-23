using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }
        public int JobId { get; set; }
        public int ReviewerId { get; set; }
        public int ReviewedId { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public JobPost JobPost { get; set; }
        public User Reviewer { get; set; }
        public User Reviewed { get; set; }
    }
}
