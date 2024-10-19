using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int JobId { get; set; }
        public int WorkerId { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }  // 'pending', 'accepted', 'rejected'
        public DateTime AppliedAt { get; set; }
        public int TypeJobPost {  get; set; }

        // Navigation properties
        public JobPost JobPost { get; set; }
        public User Worker { get; set; }
    }
}
