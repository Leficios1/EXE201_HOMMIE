using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class CategoryJobPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //ForgeinKey
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //ForgeinKey
        public int JobPostId {  get; set; }
        public JobPost JobPost { get; set; }

    }
}
