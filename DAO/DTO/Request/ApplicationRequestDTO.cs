using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Request
{
    public class ApplicationRequestDTO
    {
        public int JobId { get; set; }
        public int WorkerId { get; set; }
        public string Message { get; set; }
    }
}
