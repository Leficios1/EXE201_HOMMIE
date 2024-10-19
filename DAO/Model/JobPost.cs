using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAO.Model
{
    public class JobPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        [ForeignKey("Employer")]
        public int EmployerId {  get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public string Location {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Status {  get; set; }
        public DateTime CreateDate { get; set; }
        public int JobType {  get; set; } // 1 for User post, 2 for Employee Post

        public User Employer { get; set; }
        public ICollection<Application> Applications { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<CategoryJobPost> CategoryJobPosts { get; set; }
    }
}
