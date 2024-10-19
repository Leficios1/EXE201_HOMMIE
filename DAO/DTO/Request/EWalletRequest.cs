using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DTO.Request
{
    public class EWalletRequest
    {
        public int UserId {  get; set; }
        public decimal Balance {  get; set; }
    }
}
