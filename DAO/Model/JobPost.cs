﻿using System;
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
        public string Status {  get; set; } //// 'open', 'in_progress', 'completed', 'cancelled'
        public DateTime CreateDate { get; set; }

        public User Employer { get; set; }
        public ICollection<Application> Applications { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}