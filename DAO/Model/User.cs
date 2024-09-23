using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string Email { get; set; } = null!;

        [MaxLength(12)]
        public string? Phone { get; set; }

        [MaxLength(50)]
        public string Password { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        [Url]
        public string? AvatarUrl { get; set; }

        [MaxLength(10)]
        public string? Gender { get; set; }
        public bool Status { get; set; }
        public int RoleId { get; set; }
        public DateTime? CreatedAt { get; set; }

        //Navigation
        public Role Role { get; set; }
        public Profiles Profiles { get; set; }
        public ICollection<JobPost> JobPosts { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Review> ReviewsWritten { get; set; }
        public ICollection<Review> ReviewsReceived { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
    }
}
