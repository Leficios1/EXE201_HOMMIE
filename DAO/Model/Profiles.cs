using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Profiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileId { get; set; }
        public int UserId {  get; set; }
        public string? Bio {  get; set; }
        public string? Skills {  get; set; }
        public string Experience { get; set; }
        public string? Availability{ get; set; }
        public decimal RatingAvg {  get; set; }
        public User User { get; set; }
    }
}
