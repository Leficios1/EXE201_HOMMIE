using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class TransactionHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        public int WalletId { get; set; }
        public int UserId { get; set; }

        [MaxLength(50)]
        public string TransactionType { get; set; }  // 'Deposit' hoặc 'Payment'

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [MaxLength(255)]
        public string Description { get; set; }

        // Navigation properties
        public EWallet EWallet { get; set; }
        public User User { get; set; }
    }
}
