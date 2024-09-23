using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Reponse
{
    public class TokenReponse
    {
        public string TokenString { get; set; } = null!;
        public DateTime Expiration { get; set; }
    }
}
